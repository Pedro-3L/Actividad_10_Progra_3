using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> productos = new Dictionary<int, string>();
			productos.Add(2020, "Cereal");
			productos.Add(2010, "Pan");
			productos.Add(2030, "Manzna");

			foreach (var item in productos)
			{
				Console.WriteLine("Codigo:" + item.Key+" | Nombre:" + item.Value);
			}




		}
	}
}
