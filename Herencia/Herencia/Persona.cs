using System;

namespace Herencia
{
	public class Persona
	{
		protected string _Codigo;
		protected string _Nombre;
		protected string _Apellido;

		public Persona ()
		{
		}

		public Persona (string C, string N,string A) // CONSTRUCTOR
		{
			this._Codigo = C;
			this._Nombre = N;
			this._Apellido = A;
		}

		public virtual string RetornarDatos()
		{
			return "Persona: " + this._Nombre + " " + this._Apellido + " " + this._Codigo;; 

		}

	}
}

