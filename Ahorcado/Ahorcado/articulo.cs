using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class articulo
    {
        public int stock;
        public float precio;
        public float CalculoDescuento()
        {
            if (stock < 3)
                precio = precio - (precio * 20) / 100;
            else
                precio = precio - (precio * 30) / 100;
            return precio;
        }
    }
}
