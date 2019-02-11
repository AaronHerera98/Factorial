using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nnumero_Factorizado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el numero a factorizar");

            Factorizar obj = new Factorizar();

            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero es: "+ obj.Factorial(num));

            Console.ReadKey();

        }
    }
}
