using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_promedio_de_los_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Total = new List<string>();

            Console.WriteLine("Ingrese un numero: ");
            var numero = Console.ReadLine();

            while (Convert.ToInt32(numero) != 0)
            {
                Total.Add(numero);
                Console.WriteLine("Numero agregado al array");
                Console.WriteLine("Ingrese un numero: ");
                numero = Console.ReadLine();
            }

            Console.WriteLine("0 ingreasado, END");
            IEnumerable<double> ints = Total.Select(double.Parse);
            double total_num = ints.Average();
            Console.WriteLine("EL PROMEDIO ES: " + total_num);

            Console.ReadKey();
        }
    }
}
