using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, double> notas = new Dictionary<string, double>();

			string nombre;
			double calificacion;

			for (int i = 0; i < 5; i++)
			{
				Console.Clear();
				Console.WriteLine("Ingrese el nombre del estudiante:");
				nombre = (Console.ReadLine());

				if (notas.ContainsKey(nombre))
				{
					Console.WriteLine("El nombre ya existe");
				}
				else
				{
					Console.WriteLine("Ingrese su nota:");
					calificacion=double.Parse(Console.ReadLine());
					notas.Add(nombre, calificacion);
				}
			}

			Console.WriteLine("LISTA DE ESTUDIANTES: ");

			foreach (var estudiante in notas)
			{
				Console.WriteLine("Nombre: "+ estudiante.Key + "  /  Nota: " + estudiante.Value);
			}
		}
	}
}
