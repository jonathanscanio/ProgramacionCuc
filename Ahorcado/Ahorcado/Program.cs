using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Program
    {
        static void Main(string[] args)
        {

            //PEDIR PALABRA
            Palabra palabra1 = new Palabra("ahorcado");
            Console.WriteLine(palabra1.cadena);
            //CREAR GUIONES
            palabra1.PasarGuiones(palabra1.cadena); 
            Console.WriteLine(palabra1.guiones.ToString());
        }
    }
}
