using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Dictionary<string, double> notas = new Dictionary<string, double>();
			notas.Add("Ana Perez", 85.8);
			notas.Add("Luis Hernadez", 90.3);
			notas.Add("Carlos Recinos", 75.5);

			double suma = 0;

			foreach (var estudiante in notas)
			{
				suma += estudiante.Value;
			}

			double promedio = suma/notas.Count;

			Console.WriteLine("El promedio general del grupo es: " + promedio);
		}
	}
}
