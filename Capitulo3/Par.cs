using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo3
{
    class Par
    {
        public static void Evaluar()
        {
			int Matricula;

			Console.WriteLine("Ingrece el numero que desee evaluar: ");
			Matricula = Convert.ToInt32(Console.ReadLine());

			if (Matricula % 2 == 0)
			{
				Console.WriteLine("El numero es par.");
			}
			else
			{
				Console.WriteLine("El numero no es par.");
			}
		}
    }
}
