using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, (string	Nombre, int Edad, string Carrera)> estudiantes= new Dictionary<int, (string, int, string)>();


			for (int i = 0; i < 3; i++)
			{
				Console.Clear();
				Console.WriteLine("Ingrese el carné del estudiante: ");
				int carne = int.Parse(Console.ReadLine());

				Console.WriteLine("Ingrese el nombre:");
				string nombre = Console.ReadLine();

				Console.WriteLine("Ingrese la edad:");
				int edad = int.Parse(Console.ReadLine());
				if (edad<1 || edad>100)
				{
					Console.WriteLine("edad no valida");
				}
				else
				{
					Console.WriteLine("Ingrese la carrera:");
					string carrera = Console.ReadLine();
					estudiantes.Add(carne, (nombre, edad, carrera));
				}
			}
			Console.Clear() ;
			Console.WriteLine("LISTA DE ESTUDIANTES");

			foreach (var estudiante in estudiantes)
			{
				Console.WriteLine("Carné: " + estudiante.Key + " Nombre: " + estudiante.Value.Nombre +  " | Edad: " + estudiante.Value.Edad +	  " | Carrera: " + estudiante.Value.Carrera);
			}
			Console.ReadKey();
		}
	}
}
