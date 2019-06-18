using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            //HECHO POR CHARLY
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("TRIANGULOS EQUILATEROS E ISÓCELES");

            Console.Write("\nDame el valor de los Lados: ");
            triangulo.lado = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dame el valor de la Base: ");
            triangulo.basee = Convert.ToDouble(Console.ReadLine());
            Console.Write("Conoces la Altura <si/no>");
            string leer = Console.ReadLine();
            switch (leer.ToLower())
            {
                case "si":
                    Console.Write("Dame la altura: ");
                    triangulo.altura = Convert.ToDouble(Console.ReadLine());
                    break;
                case "no":
                    triangulo.SacarAltura();
                    break;
                default:break;
            }
            triangulo.CalcularPerimetro();
            triangulo.CalcularArea();

            Console.WriteLine("\n LA ALTURA ES: " + triangulo.altura + "m");
            Console.WriteLine("\n EL PERIMETRO ES: " + triangulo.perimetro + "m");
            Console.WriteLine("\n EL AREA ES: " + triangulo.area + "m²");


        }
        
    }
}
