using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Ejercicio4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> ciudad = new Dictionary<int, string>();
			ciudad.Add(1, "Nueva York");
			ciudad.Add(2, "Shangai");
			ciudad.Add(3, "Barcelona");
			ciudad.Add(4, "Londres");
			ciudad.Add(5, "Los Angeles");
		
			Console.WriteLine("Ingrese el codigo que desee conocer su ciudad: ");
			int codigo=int.Parse(Console.ReadLine());
			if (ciudad.ContainsKey(codigo))
			{
				Console.WriteLine(ciudad[codigo]);
			}
			else
			{
				Console.WriteLine("El codigo no esta en el diccionario");
			}
		}
	}
}
