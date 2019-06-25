using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulito = new Triangulo(2, 3, 5);
            Console.WriteLine(triangulito.perimetro);
            Console.WriteLine(triangulito.sup);
        }
    }
}
