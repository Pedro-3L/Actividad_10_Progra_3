using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> productos = new Dictionary<int, string>();

			int codigo;
			string nombre;

			for (int i = 0; i < 5; i++)
			{
				Console.Clear();
				Console.WriteLine("Ingrese el codigo del producto:");
				codigo = int.Parse(Console.ReadLine());

				if (productos.ContainsKey(codigo))
				{
					Console.WriteLine("El codigo ya existe");
				}
				else
				{
					Console.WriteLine("Ingrese el nombre del producto:");
					nombre = Console.ReadLine();
					productos.Add(codigo, nombre);
				}
				Console.ReadKey();
			}

			Console.WriteLine("LISTA DE PRODUCTOS: ");

			foreach (var producto in productos)
			{
				Console.WriteLine(producto.Key + " - " + producto.Value);
			}
		}
	}
}
