using System;
using System.Collections.Generic;

namespace Ejercicio_17
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> productos = new Dictionary<int, string>();
			int opcion;
			do
			{
				Console.Clear();
				Console.WriteLine("INVENTARIO");
				Console.WriteLine("1 Añadir");
				Console.WriteLine("2 Eliminar");
				Console.WriteLine("3 Mostrar");
				Console.WriteLine("4 Salir");
				Console.Write("Seleccione una opcion: ");
				opcion = int.Parse(Console.ReadLine());

				Console.Clear();
				switch (opcion)
				{
					case 1:
						Console.Clear();
						Console.Write("Ingrese el codigo del producto: ");
						int id = int.Parse(Console.ReadLine());
						Console.Write("Ingrese el nombre del producto: ");
						string nombre = Console.ReadLine();
						productos.Add(id, nombre);
						break;

					case 2:
						Console.Write("Ingrese el codigo del producto: ");
						id = int.Parse(Console.ReadLine());
						productos.Remove(id);
						break;

					case 3:
						foreach (var item in productos)
						{
							Console.WriteLine( + item.Key + " | " + item.Value);
						}
						Console.ReadKey();
						break;

					case 4:
						Console.Clear();
						Console.WriteLine("Saliendoo...");
						Console.ReadKey();
						break;

					default:
						Console.Clear();
						Console.WriteLine("Opcion no valida");
						Console.ReadKey();
						break;
				}
			} while (opcion != 4);

		}
	}
}
