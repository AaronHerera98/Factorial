using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nnumero_Factorizado
{
    class Factorizar
    {
        public int num { get; set; }
        public int numero { get; set; }

        public Factorizar()
        {
            num = 0;
            numero = 0;
        }
        public void factor()
        {

            for (int i = 0; i >= num; i++)
            {
                i = i + 1;

                num = num * i;

                numero = numero + num;
            }
            
        }
    }
}
