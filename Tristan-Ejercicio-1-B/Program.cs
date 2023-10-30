using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tristan_Ejercicio_1_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor N: ");
            int N = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int contador = 0;

            Console.Write("Los " + N + " terminos pares son: ");

            while (contador < N)
            {
                if (a % 2 == 0)
                {
                    Console.Write(a + " ");
                    contador ++;
                }
                int temporal = a;
                a = b;
                b = temporal + b;
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
