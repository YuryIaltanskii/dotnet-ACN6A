using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre: ");
            var nombre = Console.ReadLine();

            Console.WriteLine("Apellido: ");
            var apellido = Console.ReadLine();

            Console.WriteLine("Hola, " + nombre +" "+ apellido + "!");
            Console.ReadKey();
        }
    }
}
