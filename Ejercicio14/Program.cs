using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> ciudades = new Dictionary<int, string>();
			ciudades.Add(1, "Nueva York");
			ciudades.Add(2, "Shangai");
			ciudades.Add(3, "Barcelona");
			ciudades.Add(4, "Londres");
			ciudades.Add(5, "Los Angeles");

			Console.WriteLine("Claves:");
			foreach (var ciudad in ciudades)
			{
				Console.Write(ciudad.Key + ", ");
			}
			Console.WriteLine();
			Console.WriteLine("Valores:");
			foreach (var ciudad in ciudades)
			{
				Console.Write(ciudad.Value + ", ");
			}
		}
	}
}
