using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejericio_Stock
{
    class Articulo
    {

        public string nombre;
        public double precio;
        public double precioDescuento;
        public int stock;

        public void Descuento()
        {
            if (stock <= 3)
            {
                precioDescuento = precio * 0.8;
            }
            else
            {
                precioDescuento = precio * 0.7;
            }
            
        }
        public override string ToString()
        {
            string mensaje = "";
            mensaje += "\nNOMBRE DEL ARÍCULO: " + nombre + "\nPRECIO: " + precio.ToString() + "\nPRECIO CON DESCUENTO: " + precioDescuento.ToString() + "\nSTOCK: " + stock.ToString();

            return mensaje;
        }
    }
}
