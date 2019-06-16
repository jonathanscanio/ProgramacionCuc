using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeOperations
{
    public class Multiplicacion
    {
        public int operador1;
        public int operador2; 
        public int resultado;

        public void RealizarMultiplicacion()
        {
            
            while (operador2 !=0)
            {
                resultado += operador1;
                operador2 -= 1;
            }
            
        }

    }
}
