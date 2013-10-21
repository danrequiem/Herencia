using System;

namespace Herencia
{
	public class Alumno:Persona
	{
		public Alumno ()
		{
		}
		public Alumno(string C, string N, string A):base(C,N,A)
		{
			this._Codigo = C;
			this._Nombre = N;
			this._Apellido = A;
		}
		public override string RetornarDatos()
		{
			return "Alumno: "+ this._Nombre +" " + this._Apellido+ " " + this._Codigo;

		}
	}
}

