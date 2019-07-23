using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejericio_Stock
{
    class Program
    {
        static void Main(string[] args)
        {

            Articulo miArticulo = new Articulo();
            Console.Write("Dame el nombre: ");
            miArticulo.nombre = Console.ReadLine();
            Console.Write("Dame el precio: ");
            miArticulo.precio = Double.Parse(Console.ReadLine());
            Console.Write("Dame el Stock: ");
            miArticulo.stock = int.Parse(Console.ReadLine());
            miArticulo.Descuento();
            Console.WriteLine(miArticulo.ToString());


        }
    }
}
