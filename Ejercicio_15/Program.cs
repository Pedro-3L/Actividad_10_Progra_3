using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> empelados = new Dictionary<int, string>();
			string respuesta = "";
			do
			{
				Console.Clear();
				Console.WriteLine("Ingrese el ID del empleado:");
				int codigo = int.Parse(Console.ReadLine());

				if (empelados.ContainsKey(codigo))
				{
					Console.WriteLine("El ID ya existe");
				}
				else
				{
					Console.WriteLine("Ingrese el nombre del empleado:");
					string nombre = Console.ReadLine();
					empelados.Add(codigo, nombre);
				}
				Console.WriteLine("Desea ingresar otro empleado: ");
				respuesta = Console.ReadLine();
			} while (respuesta != "no" && respuesta == "si");
			foreach (var item in empelados)
			{
				Console.WriteLine("ID: "+item.Key + " - Nombre: " + item.Value);
			}
		}
	}
}
