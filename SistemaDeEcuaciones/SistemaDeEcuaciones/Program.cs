using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeEcuaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaDeEcuaciones Sistema1 = new SistemaDeEcuaciones();
            Ecuacion e1 = new Ecuacion();
            Ecuacion e2 = new Ecuacion();

            //A MODO DE PRUEBA. LUEGO BORRAR CONSTANTES.
            e1.coefX = 3;
            e1.coefY = 2;
            e1.indep = 4;

            e2.coefX = 5;
            e2.coefY = -3;
            e2.indep = -25; //Si todo sale bien, nos tendría que dar (-2 ; 5)



            Sistema1.Ejecutar(e1, e2);
            Console.WriteLine(Sistema1.ToString());


        }
    }
}
