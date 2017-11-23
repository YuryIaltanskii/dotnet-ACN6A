using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_todos_los_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Total = new List<string>();

            Console.WriteLine("--- PRESIONE CTRL+C PARA SALIR --- ");
            Console.WriteLine("Ingrese un numero: ");
            var numero = Console.ReadLine();

            int result = 0;

            while (result == 0)
            {
                Total.Add(numero);
                Console.WriteLine("Numero agregado al array");

                IEnumerable<int> ints = Total.Select(int.Parse);
                int total_num = ints.Sum();
                Console.WriteLine("TOTAL: " + total_num);

                Console.WriteLine("Ingrese un numero: ");
                numero = Console.ReadLine();
            }
            

            Console.ReadKey();
        }
    }
}
