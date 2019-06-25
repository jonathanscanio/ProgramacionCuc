using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
   public class triangulo
    {
        public int altura = 0;
        public int baseT = 0;
        public int sup;
        
        public void
  CalculoSup()
        {
            sup = (baseT * altura)/2;
            Console.WriteLine(sup);
        }
    }
}
