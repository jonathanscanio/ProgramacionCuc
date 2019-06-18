using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Triangulo
    {
        public double lado;
        public double basee;
        public double altura;
        public double area;
        public double perimetro;

        public void CalcularPerimetro()
        {
            perimetro = (lado*2) + basee;
        }
        public void CalcularArea()
        {
            area = (basee * altura) / 2;

        }
        public void SacarAltura()
        {
            
            double intermedio = Math.Pow(lado, 2) - Math.Pow(basee, 2);
            altura = Math.Sqrt(intermedio);


            
        }
    }
}
