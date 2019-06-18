using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionNumeroEntero
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberFromUserInput="";
            int numberAsInt;
            //test
            bool isInt;
            do
            {
                Console.WriteLine("Ingrese un numero entero");
                numberFromUserInput = Console.ReadLine();
                isInt = int.TryParse(numberFromUserInput, out numberAsInt);
                if (!isInt)
                {
                    Console.WriteLine("Su numero no es entero");
                }
            }
            while (!isInt);

        }
    }
}
