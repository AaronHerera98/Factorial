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

            obj.num = Convert.ToInt32(Console.ReadLine());

            obj.factor();

            Console.WriteLine("El numero es: "+ obj.numero);

            Console.ReadKey();

        }
    }
}
