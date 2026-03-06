using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> usuario = new Dictionary<string, string>();
			usuario.Add("Juan777", "123");
			usuario.Add("Lando133", "contrasenna");
			usuario.Add("Rex_$", "pongancafe");
	

			Console.WriteLine("Ingrese el usuario que desee conocer su contraseña: ");
			string nombre = Console.ReadLine();
			if (usuario.ContainsKey(nombre))
			{
				Console.WriteLine("Contraseña: "+ usuario[nombre]);
			}
			else
			{
				Console.WriteLine("El codigo no esta en el diccionario");
			}

		}
	}
}
