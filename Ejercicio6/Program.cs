using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> estudiantes = new Dictionary<int, string>();
			estudiantes.Add(1, "Pablo");
			estudiantes.Add(2, "Pedro");
			estudiantes.Add(3, "Juan");
			estudiantes.Remove(1);

			foreach (var item in estudiantes)
			{
				Console.WriteLine(item.Key +"-"+ item.Value);
			}
		}
	}
}
