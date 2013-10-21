using System;

namespace Herencia
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			Persona p = new Persona ("021", "Daniel", "Garcia");
			string persona = p.RetornarDatos ();
			Console.WriteLine(persona);
		

			Alumno a = new Alumno("0234","Alfonso","Ramirez");
			string alumno = a.RetornarDatos ();
			Console.WriteLine (alumno);

			
		}
	}
}
