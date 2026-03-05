using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string>estudiantes = new Dictionary<int, string>();
			estudiantes.Add(123, "Pablo");
			estudiantes.Add(345, "Pedro");
			estudiantes.Add(567, "Juan");
			Console.WriteLine(estudiantes[123]);

		}
	}
}
