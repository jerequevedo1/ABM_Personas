
namespace AppPersonasABM
{
	partial class frmABM
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblApellido = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtDocumento = new System.Windows.Forms.TextBox();
			this.lblDocumento = new System.Windows.Forms.Label();
			this.lblTipoDocumento = new System.Windows.Forms.Label();
			this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
			this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
			this.lblEstadoCivil = new System.Windows.Forms.Label();
			this.lblSexo = new System.Windows.Forms.Label();
			this.rbtFemenino = new System.Windows.Forms.RadioButton();
			this.rbtMasculino = new System.Windows.Forms.RadioButton();
			this.chkFallecido = new System.Windows.Forms.CheckBox();
			this.lblFallecido = new System.Windows.Forms.Label();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.grdPersonas = new System.Windows.Forms.DataGridView();
			this.cApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.grdPersonas)).BeginInit();
			this.SuspendLayout();
			// 
			// lblApellido
			// 
			this.lblApellido.AutoSize = true;
			this.lblApellido.Location = new System.Drawing.Point(34, 37);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(44, 13);
			this.lblApellido.TabIndex = 0;
			this.lblApellido.Text = "Apellido";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(99, 33);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(165, 20);
			this.txtApellido.TabIndex = 0;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(347, 33);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(204, 20);
			this.txtNombre.TabIndex = 1;
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(292, 37);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(44, 13);
			this.lblNombre.TabIndex = 2;
			this.lblNombre.Text = "Nombre";
			// 
			// txtDocumento
			// 
			this.txtDocumento.Location = new System.Drawing.Point(391, 78);
			this.txtDocumento.Name = "txtDocumento";
			this.txtDocumento.Size = new System.Drawing.Size(160, 20);
			this.txtDocumento.TabIndex = 3;
			// 
			// lblDocumento
			// 
			this.lblDocumento.AutoSize = true;
			this.lblDocumento.Location = new System.Drawing.Point(292, 82);
			this.lblDocumento.Name = "lblDocumento";
			this.lblDocumento.Size = new System.Drawing.Size(62, 13);
			this.lblDocumento.TabIndex = 4;
			this.lblDocumento.Text = "Documento";
			// 
			// lblTipoDocumento
			// 
			this.lblTipoDocumento.AutoSize = true;
			this.lblTipoDocumento.Location = new System.Drawing.Point(34, 82);
			this.lblTipoDocumento.Name = "lblTipoDocumento";
			this.lblTipoDocumento.Size = new System.Drawing.Size(86, 13);
			this.lblTipoDocumento.TabIndex = 6;
			this.lblTipoDocumento.Text = "Tipo Documento";
			// 
			// cboTipoDocumento
			// 
			this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTipoDocumento.FormattingEnabled = true;
			this.cboTipoDocumento.Location = new System.Drawing.Point(143, 78);
			this.cboTipoDocumento.Name = "cboTipoDocumento";
			this.cboTipoDocumento.Size = new System.Drawing.Size(121, 21);
			this.cboTipoDocumento.TabIndex = 2;
			// 
			// cboEstadoCivil
			// 
			this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboEstadoCivil.FormattingEnabled = true;
			this.cboEstadoCivil.Location = new System.Drawing.Point(143, 124);
			this.cboEstadoCivil.Name = "cboEstadoCivil";
			this.cboEstadoCivil.Size = new System.Drawing.Size(121, 21);
			this.cboEstadoCivil.TabIndex = 4;
			// 
			// lblEstadoCivil
			// 
			this.lblEstadoCivil.AutoSize = true;
			this.lblEstadoCivil.Location = new System.Drawing.Point(34, 128);
			this.lblEstadoCivil.Name = "lblEstadoCivil";
			this.lblEstadoCivil.Size = new System.Drawing.Size(62, 13);
			this.lblEstadoCivil.TabIndex = 9;
			this.lblEstadoCivil.Text = "Estado Civil";
			// 
			// lblSexo
			// 
			this.lblSexo.AutoSize = true;
			this.lblSexo.Location = new System.Drawing.Point(292, 128);
			this.lblSexo.Name = "lblSexo";
			this.lblSexo.Size = new System.Drawing.Size(31, 13);
			this.lblSexo.TabIndex = 12;
			this.lblSexo.Text = "Sexo";
			// 
			// rbtFemenino
			// 
			this.rbtFemenino.AutoSize = true;
			this.rbtFemenino.Location = new System.Drawing.Point(345, 155);
			this.rbtFemenino.Name = "rbtFemenino";
			this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
			this.rbtFemenino.TabIndex = 6;
			this.rbtFemenino.TabStop = true;
			this.rbtFemenino.Text = "Femenino";
			this.rbtFemenino.UseVisualStyleBackColor = true;
			// 
			// rbtMasculino
			// 
			this.rbtMasculino.AutoSize = true;
			this.rbtMasculino.Location = new System.Drawing.Point(345, 126);
			this.rbtMasculino.Name = "rbtMasculino";
			this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
			this.rbtMasculino.TabIndex = 5;
			this.rbtMasculino.TabStop = true;
			this.rbtMasculino.Text = "Masculino";
			this.rbtMasculino.UseVisualStyleBackColor = true;
			// 
			// chkFallecido
			// 
			this.chkFallecido.AutoSize = true;
			this.chkFallecido.Location = new System.Drawing.Point(517, 127);
			this.chkFallecido.Name = "chkFallecido";
			this.chkFallecido.Size = new System.Drawing.Size(15, 14);
			this.chkFallecido.TabIndex = 7;
			this.chkFallecido.UseVisualStyleBackColor = true;
			// 
			// lblFallecido
			// 
			this.lblFallecido.AutoSize = true;
			this.lblFallecido.Location = new System.Drawing.Point(456, 128);
			this.lblFallecido.Name = "lblFallecido";
			this.lblFallecido.Size = new System.Drawing.Size(49, 13);
			this.lblFallecido.TabIndex = 12;
			this.lblFallecido.Text = "Fallecido";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(37, 196);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(75, 23);
			this.btnNuevo.TabIndex = 8;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(118, 196);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 23);
			this.btnEditar.TabIndex = 9;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnBorrar
			// 
			this.btnBorrar.Location = new System.Drawing.Point(199, 196);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(75, 23);
			this.btnBorrar.TabIndex = 10;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(37, 576);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 12;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(118, 576);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 13;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(476, 576);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 14;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// grdPersonas
			// 
			this.grdPersonas.AllowUserToAddRows = false;
			this.grdPersonas.AllowUserToDeleteRows = false;
			this.grdPersonas.AllowUserToResizeColumns = false;
			this.grdPersonas.AllowUserToResizeRows = false;
			this.grdPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cApellido,
            this.cNombres,
            this.cTipoDocumento,
            this.cDocumento});
			this.grdPersonas.Location = new System.Drawing.Point(37, 233);
			this.grdPersonas.Name = "grdPersonas";
			this.grdPersonas.ReadOnly = true;
			this.grdPersonas.RowHeadersVisible = false;
			this.grdPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdPersonas.Size = new System.Drawing.Size(514, 329);
			this.grdPersonas.TabIndex = 11;
			this.grdPersonas.SelectionChanged += new System.EventHandler(this.grdPersonas_SelectionChanged);
			// 
			// cApellido
			// 
			this.cApellido.HeaderText = "Apellido";
			this.cApellido.Name = "cApellido";
			this.cApellido.ReadOnly = true;
			this.cApellido.Width = 150;
			// 
			// cNombres
			// 
			this.cNombres.HeaderText = "Nombres";
			this.cNombres.Name = "cNombres";
			this.cNombres.ReadOnly = true;
			this.cNombres.Width = 150;
			// 
			// cTipoDocumento
			// 
			this.cTipoDocumento.HeaderText = "Tipo Doc";
			this.cTipoDocumento.Name = "cTipoDocumento";
			this.cTipoDocumento.ReadOnly = true;
			this.cTipoDocumento.Width = 80;
			// 
			// cDocumento
			// 
			this.cDocumento.HeaderText = "Documento";
			this.cDocumento.Name = "cDocumento";
			this.cDocumento.ReadOnly = true;
			this.cDocumento.Width = 130;
			// 
			// frmABM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(587, 626);
			this.Controls.Add(this.grdPersonas);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.chkFallecido);
			this.Controls.Add(this.rbtMasculino);
			this.Controls.Add(this.rbtFemenino);
			this.Controls.Add(this.lblFallecido);
			this.Controls.Add(this.lblSexo);
			this.Controls.Add(this.cboEstadoCivil);
			this.Controls.Add(this.lblEstadoCivil);
			this.Controls.Add(this.cboTipoDocumento);
			this.Controls.Add(this.lblTipoDocumento);
			this.Controls.Add(this.txtDocumento);
			this.Controls.Add(this.lblDocumento);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.lblApellido);
			this.Name = "frmABM";
			this.Text = "ABM Personas";
			this.Load += new System.EventHandler(this.frmABM_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdPersonas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblApellido;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtDocumento;
		private System.Windows.Forms.Label lblDocumento;
		private System.Windows.Forms.Label lblTipoDocumento;
		private System.Windows.Forms.ComboBox cboTipoDocumento;
		private System.Windows.Forms.ComboBox cboEstadoCivil;
		private System.Windows.Forms.Label lblEstadoCivil;
		private System.Windows.Forms.Label lblSexo;
		private System.Windows.Forms.RadioButton rbtFemenino;
		private System.Windows.Forms.RadioButton rbtMasculino;
		private System.Windows.Forms.CheckBox chkFallecido;
		private System.Windows.Forms.Label lblFallecido;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.DataGridView grdPersonas;
		private System.Windows.Forms.DataGridViewTextBoxColumn cApellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn cNombres;
		private System.Windows.Forms.DataGridViewTextBoxColumn cTipoDocumento;
		private System.Windows.Forms.DataGridViewTextBoxColumn cDocumento;
	}
}

