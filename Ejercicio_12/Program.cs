using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> productos = new Dictionary<int, string>();
			string respuesta= "";
			do {
			Console.Clear();
			Console.WriteLine("Ingrese el codigo del producto:");
			int codigo = int.Parse(Console.ReadLine());

			if (productos.ContainsKey(codigo))
			{
				Console.WriteLine("El codigo ya existe");
			}
			else
			{
				Console.WriteLine("Ingrese el nombre del producto:");
				string nombre = Console.ReadLine();
				productos.Add(codigo, nombre);
			}
				Console.WriteLine("Desea ingresar otro: ");
				respuesta = Console.ReadLine();
			} while (respuesta != "no" && respuesta == "si");
			foreach (var item in productos)
			{
				Console.WriteLine( + item.Key + " - " + item.Value);
			}

		}
	}
}
