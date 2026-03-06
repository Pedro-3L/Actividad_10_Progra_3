using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> inventario = new Dictionary<int, string>();
			inventario.Add(1, "Laptop");
			inventario.Add(2, "Mouse Pad");
			inventario.Add(3, "Teclado");
			inventario.Add(4, "Mesa de escritorio");
			Console.Clear();
			Console.WriteLine("--INVENTARIO--");
			foreach (var item in inventario)
			{

				Console.WriteLine("Codigo: " + item.Key + " | Producto: " + item.Value);
			}
			Console.ReadKey();

			Console.Clear();
			Console.Write("Coloque el codigo del producto que desee eliminar: ");
			int codigo = int.Parse(Console.ReadLine());
			
			inventario.Remove(codigo);
			Console.Clear();
			Console.WriteLine("INVENTARIO MODIFICADO");
			foreach (var item in inventario)
			{

				Console.WriteLine("Codigo: " + item.Key + " | Producto: " + item.Value);
			}
			Console.ReadKey();

		}
	}
}
