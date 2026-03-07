using System;
using System.Collections.Generic;

namespace Ejercicio_18
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> usuarios = new Dictionary<string, string>();

			string usuario;
			string contraseña;
			string respuesta = " ";
			do
			{
				Console.Clear();
				Console.WriteLine("Ingrese el nombre de usuario:");
				usuario = Console.ReadLine();

				if (usuarios.ContainsKey(usuario))
				{
					Console.WriteLine("El usuario ya existe.");
				}
				else
				{
					Console.WriteLine("Ingrese la contraseña:");
					contraseña = Console.ReadLine();

					usuarios.Add(usuario, contraseña);
					Console.WriteLine("Usuario registrado correctamente.");
				}
				Console.WriteLine("Desea ingresar otro : ");
				respuesta = Console.ReadLine();
			} while (respuesta != "no" && respuesta == "si");

			Console.Clear();
			Console.WriteLine("LISTA DE USUSARIOS INGRESADOS:");
			foreach (var item in usuarios)
			{
				Console.WriteLine("Usuario: " + item.Key + " Contraseña: " + item.Value);
			}
			Console.ReadKey();
		}
	}
}
