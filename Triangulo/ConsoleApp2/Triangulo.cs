using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Triangulo
    {
        public int b, h, L1;
        public int perimetro, sup;

        public Triangulo(int b, int h, int L1) {
           
            perimetro = b + h + L1;
            sup = (b * h) / 2;
        }
    }
}
