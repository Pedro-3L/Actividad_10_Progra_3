using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string>estudiantes = new Dictionary<int, string>();
			estudiantes.Add(20233, "Lacan	  Gabriel");
			estudiantes.Add(32423, "Recinos	  Javier");
			estudiantes.Add(56456, "Martinez  Fernanda");
			estudiantes.Add(20981, "Montes	  Sofia");
			estudiantes.Add(97887, "Gonzalez  Manuel");
			foreach (var item in estudiantes)
			{
				Console.WriteLine("No.Carne:" + item.Key + " | Nombre Alumno: " + item.Value);
			}



		}
	}
}
