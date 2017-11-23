using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dos_valores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el 1er valor: ");
            var valor1 = Console.ReadLine();

            Console.WriteLine("Ingrese el 2do valor: ");
            var valor2 = Console.ReadLine();

            Console.WriteLine("El divisor maximo: " + GCD(Convert.ToInt32(valor1), Convert.ToInt32(valor2)));

            Console.ReadKey();
        }

        private static int GCD(int a, int b) {
            if (a < 1 || b < 1) {
                throw new ArgumentException("a or b is less than 1");
            }
            int r = 0;
            while (b != 0) {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}
