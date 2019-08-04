using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeEcuaciones
{
    class SistemaDeEcuaciones
    {
        //LOGICA A DESARROLLAR POR CARLOS MORENO. Posiblemente tenga errores, Continúo Luego desarrollandola.

        float puntoX; //Punto de encuentro de ambas ecuaciones en X
        float puntoY; //Punto de encuentro de ambas ecuaciones en Y

        public void Ejecutar(Ecuacion e1, Ecuacion e2)
        {

            /* Creemos que el método de resolución programable más sencillo es por DETERMINANTE.
               
            Para ello necesitaremos sacar el: 
           
               • Delta Sistema: Armamos el determinante solo con los valores que estan multiplicando a la X y la Y. Luego multiplicamos cruzados, 
               y restamos los múltiplos. 
               
               • Delta X: Armamos el determinante con los Términos Independientes y los Valores de la Y. Luego multiplicamos cruzados y restamos los múltiplos.
            
               • Delta Y: Armamos el determinante con los Términos Independientes y los Valores de la X. Luego multiplicamos cruzados y restamos los múltiplos.

            Luego para encontrar el Punto de Encuentro.

            x = DeltaX / DeltaSistema
            y = DeltaY / DeltaSistema

            Finalmente nos quedará: "Solucion: (x ; y)""

             */

      
            float deltasistema = SacarDeltaSistema(e1.coefX, e2.coefX, e1.coefY, e2.coefY);
            float deltaX = SacarDeltaX(e1.indep, e2.indep, e1.coefY, e2.coefY);
            float deltaY = SacarDeltaY(e1.indep, e2.indep, e1.coefX, e2.coefX);

            puntoX = deltaX / deltasistema;
            puntoY = deltaY / deltasistema;

        }

        private float SacarDeltaSistema(float x1, float x2, float y1, float y2)
        {
            float deltaS;

            deltaS = (x1 * y2) - (x2 * y1);


            return deltaS;
        }

        private float SacarDeltaX(float indep1, float indep2, float y1, float y2)
        {
            float deltaX;

            deltaX = (indep1 * y2) - (indep2 * y1);

            return deltaX;

        }

        private float SacarDeltaY(float indep1, float indep2, float x1, float x2)
        {
            float deltaY;

            deltaY = (indep1 * x2) - (indep2 * x1) ;

            return deltaY;

        }

        public override string ToString() //Como te gusta sobrescribir el ToString Carlitos
        {
            string mensaje = "";

            mensaje += "Solución: (" + puntoX + " ; " + puntoY + ")";  

            return mensaje;
        }
    }
}
