using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, double> estudiantes = new Dictionary<string, double>();
			int opcion;
			do
			{
				Console.WriteLine("1 Agregar estudiante");
				Console.WriteLine("2 Modificar");
				Console.WriteLine("3 Mostrar");
				Console.WriteLine("0 Salir");
				Console.Write("Seleccione una opcion: ");
				opcion = int.Parse(Console.ReadLine());
				switch (opcion)
				{
					case 1:
						Console.Write("Ingrese el nombre: ");
						string nombre = Console.ReadLine();
						Console.Write("Ingrese la nota: ");
						double nota = double.Parse (Console.ReadLine());
						estudiantes.Add(nombre, nota);
						break;
					case 2:
						Console.Write("Ingrese el nombre del estudiante: ");
						nombre = Console.ReadLine();
						Console.Write("Ingrese la nueva nota: ");
						nota = int.Parse(Console.ReadLine());
						estudiantes[nombre] = nota;
						break;
					case 3:
						foreach (var item in estudiantes)
						{
							Console.WriteLine("Nombre: " + item.Key + " Nota: " + item.Value);
						}
						break;
				}
			} while (opcion != 0);
		}

	}
}

