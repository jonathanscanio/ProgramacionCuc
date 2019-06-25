using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloClases
{
    class Triangulo
    {
        public double perimetro;
        public double area;

        public Triangulo(int lado, int Base,int altura)
        {
            perimetro = lado + lado + Base;
            area = (Base * altura) / 2;
        }
        public override string ToString()
        {
            string mensaje = "";
            mensaje += "PERIMETRO: " + perimetro + "\nAREA: " + area;
            return mensaje;
        }

    }
}
