using System;
using System.Collections.Generic;

namespace Ejercicio_16
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> estudiantes = new Dictionary<int, string>();
			int opcion;
			do
			{
				Console.WriteLine("DICCIONARIO DE ESTUDIANTES");
				Console.WriteLine("1- Añadir");
				Console.WriteLine("2- Mostrar");
				Console.WriteLine("3- Salir");
				Console.Write("Seleccione una opcion: ");
				opcion = int.Parse(Console.ReadLine());

				Console.Clear();
				switch (opcion)
				{
					case 1:
						Console.Clear();
						Console.Write("Ingrese el numero de carne: ");
						int id = int.Parse(Console.ReadLine());
						Console.Write("Ingrese el nombre: ");
						string nombre = Console.ReadLine();
						estudiantes.Add(id, nombre);
						break;

					case 2:
						foreach (var item in estudiantes)
						{
							Console.WriteLine("Carne: " + item.Key + " Nombre: " + item.Value);
						}
						Console.ReadKey();
						break;

					case 3:
						Console.Clear();
						Console.WriteLine("Saliendoo...");
						break;
				}
			} while (opcion != 3);
		}
	}
}
