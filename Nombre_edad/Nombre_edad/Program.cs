using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombre_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre: ");
            var nombre = Console.ReadLine();

            Console.WriteLine("Edad: ");
            var edad = Console.ReadLine();

            int result;
            bool ed = int.TryParse(edad, out result);

            while(ed == false) {
                Console.WriteLine("Por favor, ingrese un numero valido");
                Console.WriteLine("Edad: ");
                edad = Console.ReadLine();
                ed = int.TryParse(edad, out result);
            }

            if (Convert.ToInt32(edad) <= 18)
            {
                Console.WriteLine(nombre + ", Usted es menor de edad");
            }
            else {
                Console.WriteLine(nombre + ", Usted es mayor de edad");
            }

            Console.ReadKey();
        }
    }
}
