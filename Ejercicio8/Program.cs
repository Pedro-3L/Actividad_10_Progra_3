using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int,string>empleado = new Dictionary<int, string>();
			empleado.Add(1, "Jonás Martinez");
			empleado.Add(2, "Luis Rodriguez");
			empleado.Add(3, "Wilson Hernandez");
			empleado.Add(4, "Roberto Juarez");
			Console.Clear();
			Console.WriteLine("LISTA DE EMPLEADOS");
			foreach (var item in empleado)
			{
			
				Console.WriteLine("ID: " + item.Key + " | Nombre: " + item.Value);
			}
			Console.ReadKey();

			Console.Clear();
			Console.Write("ID a modificar: ");
			int id = int.Parse(Console.ReadLine());
			Console.Write("Nuevo nombre: ");
			string nombre = Console.ReadLine();
			empleado[id] = nombre;
			Console.Clear() ;
			Console.WriteLine("LISTA DE EMPLEADOS MODIFICADA");
			foreach (var item in empleado)
			{

				Console.WriteLine("ID: " + item.Key + " | Nombre: " + item.Value);
			}
			Console.ReadKey();

		}
	}
}
