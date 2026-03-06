using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, double> nota_estudiantes = new Dictionary<string, double>();
			nota_estudiantes.Add("Pedro", 75.5);
			nota_estudiantes.Add("Roberto", 5.78);
			nota_estudiantes.Add("Javier", 95);
			nota_estudiantes.Add("Manuel", 54);
			nota_estudiantes.Add("Isaac", 17.52);
			nota_estudiantes.Add("Gabriel", 33.3);
			nota_estudiantes.Add("Andy", 7.3);

			Console.WriteLine("Ingrese el nombre de un estudiante que desee conocer su nota (inicie con mayuscula): ");
			string nombre = Console.ReadLine();
			if (nota_estudiantes.ContainsKey(nombre)) 
			{
				Console.WriteLine(nota_estudiantes[nombre]);
			}
			else
			{
				Console.WriteLine("El nombre no esta en el diccionario");
			}
		}
	}
}
