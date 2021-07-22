using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPersonasABM
{
	class Persona
	{
		private string apellido, nombre;
		private int tipoDocumento, documento, estadoCivil, sexo;
		private bool fallecio;

		public Persona()
		{
			apellido = "";
			nombre = "";
			tipoDocumento = 0;
			documento = 0;
			estadoCivil = 0;
			sexo = 0;
			fallecio = true;
		}
		public Persona(string apellido,string nombre, int tipoDocumento,int documento, int estadoCivil, int sexo, bool fallecio)
		{
			this.apellido = apellido;
			this.nombre = nombre;
			this.tipoDocumento = tipoDocumento;
			this.documento = documento;
			this.estadoCivil = estadoCivil;
			this.sexo = sexo;
			this.fallecio = fallecio;
		}
		public string pApellido
		{
			get { return apellido; }
			set { apellido=value; }
		}
		public string pNombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		public int pTipoDocumento
		{
			get { return tipoDocumento; }
			set { tipoDocumento = value; }
		}
		public int pDocumento
		{
			get { return documento; }
			set { documento = value; }
		}
		public int pEstadoCivil
		{
			get { return estadoCivil; }
			set { estadoCivil = value; }
		}
		public int pSexo
		{
			get { return sexo; }
			set { sexo = value; }
		}
		public bool pFallecio
		{
			get { return fallecio; }
			set { fallecio = value; }
		}
		public string toString()
		{
			return apellido + ", " + nombre;
		}
	}
}
