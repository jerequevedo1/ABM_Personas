using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppPersonasABM
{
	public partial class frmABM : Form
	{

		bool nuevo = false;

		List<Persona> lPersonas = new List<Persona>();
		
		SqlConnection conexion = new SqlConnection(@"Data Source=NOTEBOOK-JERE\SQLEXPRESS;Initial Catalog=TUPPI;Integrated Security=True");
		
		SqlCommand comando = new SqlCommand(); 

		SqlDataReader lector; 
		public frmABM()
		{
			InitializeComponent();
		}
		private void frmABM_Load(object sender, EventArgs e)
		{
			habilitarCargaDatos(false);
			cargarCombo(cboTipoDocumento, "tipo_documento");
			cargarCombo(cboEstadoCivil, "estado_civil");
			cargarGrilla();
		}
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			nuevo = true;
			limpiarCargaDatos();
			habilitarCargaDatos(true);
			txtApellido.Focus();
		}
		private void btnEditar_Click(object sender, EventArgs e)
		{
			nuevo = false;
			habilitarCargaDatos(true);
			txtDocumento.Enabled = false;
			txtApellido.Focus(); 
		}
		private void btnBorrar_Click(object sender, EventArgs e)
		{
			string consultaSQL;

			DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar esta persona?", "Eliminando Persona", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
			if (dialogResult == DialogResult.Yes)
			{
				int i = grdPersonas.CurrentCell.RowIndex;

				consultaSQL = $"DELETE personas WHERE documento={lPersonas[i].pDocumento}";
				modificarTabla(consultaSQL);

				grdPersonas.ClearSelection();
				cargarGrilla();
			}
			
		}
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			string sentenciaSQL;

			if (validarCampos())
			{
				Persona p = new Persona();
				p.pApellido = txtApellido.Text;
				p.pNombre = txtNombre.Text;
				p.pTipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue);
				p.pDocumento = Convert.ToInt32(txtDocumento.Text);
				p.pEstadoCivil = Convert.ToInt32(cboEstadoCivil.SelectedValue);
				if (rbtFemenino.Checked)
					p.pSexo = 1;
				else
					p.pSexo = 2;
				p.pFallecio = chkFallecido.Checked;
				
				if (nuevo)
				{
					try
					{
						sentenciaSQL = "INSERT INTO personas (apellido,nombres,tipo_documento,documento,estado_civil,sexo,fallecio) " +
							"VALUES (@apellido,@nombres,@tipo_documento,@documento,@estado_civil,@sexo,@fallecio)";

						altaBajaPersonas(p, sentenciaSQL);
						MessageBox.Show("Se guardo una nueva Persona correctamente.", "Guardando Persona", MessageBoxButtons.OK, MessageBoxIcon.Information);
						cargarGrilla();
					}
					catch (SqlException)
					{
						MessageBox.Show("Ya se encuentra otra persona registrada con el mismo documento.", "Error al insertar nueva Persona",MessageBoxButtons.OK,MessageBoxIcon.Error);
						return;
					}

			}
				else
				{
					sentenciaSQL = "UPDATE personas SET apellido=@apellido, nombres=@nombres,tipo_documento=@tipo_documento," +
									"estado_civil=@estado_civil,sexo=@sexo,fallecio=@fallecio WHERE documento=@documento";

					altaBajaPersonas(p, sentenciaSQL);
					MessageBox.Show("Se edito la Persona correctamente.", "Editando Persona", MessageBoxButtons.OK, MessageBoxIcon.Information);
					cargarGrilla();
				}

				habilitarCargaDatos(false);
				nuevo = false;
			}
		}
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			if(nuevo) limpiarCargaDatos();
			habilitarCargaDatos(false);
			grdPersonas.Focus();
			cargarCampos(grdPersonas.CurrentCell.RowIndex);
			nuevo = false;
		}
		private void btnSalir_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea salir de la aplicacion?", "Cerrando Aplicacion", 
										MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if (dialogResult == DialogResult.Yes) Close();
			else grdPersonas.Focus();
		}
		private void grdPersonas_SelectionChanged(object sender, EventArgs e)
		{
			cargarCampos(grdPersonas.CurrentCell.RowIndex);
		}
		private DataTable consultarTabla(string consultaSQL)
		{
			DataTable tabla = new DataTable();
			conexion.Open();
			comando.Connection = conexion;
			comando.CommandType = CommandType.Text;
			comando.CommandText = consultaSQL;
			tabla.Load(comando.ExecuteReader()); 
			conexion.Close();

			return tabla;
		}
		private void modificarTabla(string sentenciaSQL)
		{
			conexion.Open();
			comando.Connection = conexion;
			comando.CommandType = CommandType.Text;
			comando.CommandText = sentenciaSQL;
			comando.ExecuteNonQuery();
			conexion.Close();
		}
		private void altaBajaPersonas(Persona oPersona, string sentenciaSQL) 
		{
			comando.Parameters.Clear();

			comando.Parameters.AddWithValue("@apellido", oPersona.pApellido);
			comando.Parameters.AddWithValue("@nombres", oPersona.pNombre);
			comando.Parameters.AddWithValue("@tipo_documento", oPersona.pTipoDocumento);
			comando.Parameters.AddWithValue("@documento", oPersona.pDocumento);
			comando.Parameters.AddWithValue("@estado_civil", oPersona.pEstadoCivil);
			comando.Parameters.AddWithValue("@sexo", oPersona.pSexo);
			comando.Parameters.AddWithValue("@fallecio", oPersona.pFallecio);

			modificarTabla(sentenciaSQL);
		}
		private void cargarCombo(ComboBox combo, string nombreTabla)
		{
			DataTable tabla = consultarTabla("SELECT * FROM " + nombreTabla);
			combo.DataSource = tabla;
			combo.DisplayMember = tabla.Columns[1].ColumnName;
			combo.ValueMember = tabla.Columns[0].ColumnName;
		}
		private void cargarList()
		{
			lPersonas.Clear();

			conexion.Open();
			comando.Connection = conexion;
			comando.CommandType = CommandType.Text;
			comando.CommandText = "SELECT * FROM personas ORDER BY 1,2";
			lector = comando.ExecuteReader();

			while (lector.Read())	
			{
				Persona p = new Persona();

				p.pDocumento = lector.GetInt32(3);
				if (!lector.IsDBNull(0)) p.pApellido = lector.GetString(0);
				if (!lector.IsDBNull(1)) p.pNombre = lector.GetString(1);
				if (!lector.IsDBNull(2)) p.pTipoDocumento = lector.GetInt32(2);
				if (!lector.IsDBNull(4)) p.pEstadoCivil = lector.GetInt32(4);
				if (!lector.IsDBNull(5)) p.pSexo = lector.GetInt32(5);
				if (!lector.IsDBNull(6)) p.pFallecio = lector.GetBoolean(6);

				lPersonas.Add(p);
			}

			lector.Close();
			conexion.Close();
		}
		private void cargarGrilla()
		{
			cargarList();

			DataTable tabla = consultarTabla("SELECT p.apellido,p.nombres,t.n_tipo_documento,p.documento " +
												"FROM personas p,tipo_documento t " +
												"WHERE p.tipo_documento=t.id_tipo_documento " +
												"ORDER BY 1,2");
			grdPersonas.Rows.Clear();
			for (int i = 0; i < tabla.Rows.Count; i++)
			{
				grdPersonas.Rows.Add(tabla.Rows[i]["apellido"], tabla.Rows[i][1], tabla.Rows[i][2], tabla.Rows[i][3]);
			}
			grdPersonas.Focus();
		}
		private void cargarCampos(int posicion)
		{
			txtApellido.Text = lPersonas[posicion].pApellido;
			txtNombre.Text = lPersonas[posicion].pNombre;
			cboTipoDocumento.SelectedValue = lPersonas[posicion].pTipoDocumento;
			txtDocumento.Text = lPersonas[posicion].pDocumento.ToString();
			cboEstadoCivil.SelectedValue = lPersonas[posicion].pEstadoCivil;
			if (lPersonas[posicion].pSexo == 1) rbtFemenino.Checked = true;
			else rbtMasculino.Checked = true;
			chkFallecido.Checked = lPersonas[posicion].pFallecio;
		}
		private bool validarCampos()
		{
			if (txtApellido.Text == "")
			{
				MessageBox.Show("Ingrese un Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtApellido.Focus();
				return false;
			}
			if (txtNombre.Text == "")
			{
				MessageBox.Show("Ingrese un Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtNombre.Focus();
				return false;
			}
			if (cboTipoDocumento.SelectedIndex == -1)
			{
				MessageBox.Show("Seleccione un Tipo de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cboTipoDocumento.Focus();
				return false;
			}
			if (txtDocumento.Text == "")
			{
				MessageBox.Show("Ingrese un Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtDocumento.Focus();
				return false;
			}
			else
			{
				try
				{
					int.Parse(txtDocumento.Text);
				}
				catch (FormatException)
				{
					MessageBox.Show("El Documento debe contener valores numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtDocumento.Focus();
					return false;
				}
				catch (OverflowException)
				{
					MessageBox.Show("El Documento debe contener 8 valores numericos como maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtDocumento.Focus();
					return false;
				}
				catch (Exception)
				{
					MessageBox.Show("Error al ingresar el Documento. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtDocumento.Focus();
					return false;
				}

			}
			if (cboEstadoCivil.SelectedIndex == -1)
			{
				MessageBox.Show("Seleccione un Estado Civil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cboEstadoCivil.Focus();
				return false;
			}
			if (!rbtFemenino.Checked && !rbtMasculino.Checked)
			{
				MessageBox.Show("Seleccione un Sexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				rbtFemenino.Focus();
				return false;
			}


			return true;
		}
		private void limpiarCargaDatos()
		{
			txtApellido.Clear();
			txtNombre.Clear();
			txtDocumento.Clear();
			cboTipoDocumento.SelectedIndex = -1; 
			cboEstadoCivil.SelectedIndex = -1;
			rbtFemenino.Checked = false;
			rbtMasculino.Checked = false;
			chkFallecido.Checked = false;
		}
		private void habilitarCargaDatos(bool x)
		{
			txtApellido.Enabled = x;
			txtNombre.Enabled = x;
			cboTipoDocumento.Enabled = x;
			txtDocumento.Enabled = x;
			cboEstadoCivil.Enabled = x;
			rbtFemenino.Enabled = x;
			rbtMasculino.Enabled = x;
			chkFallecido.Enabled = x;
			btnGuardar.Enabled = x;
			btnCancelar.Enabled = x;
			btnNuevo.Enabled = !x;
			btnEditar.Enabled = !x;
			btnBorrar.Enabled = !x;
			btnSalir.Enabled = !x;
			grdPersonas.Enabled = !x;
		}

	}
}
