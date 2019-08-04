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

            /*
            e1.PedirDatos();
            e2.PedirDatos();
            */
            //A MODO DE PRUEBA. LUEGO BORRAR CONSTANTES. 
            //Edit (gonza): Ya está termiando el método PedirDatos(), cuando quieras saca el bloque de comentarios.
            //Edit2 (gonza): NO puse un Console.Clear(); al final de la funcion PedirDatos(), si queres que se borre la consola escribilo en la misma funcion PedirDatos().
            //Edit3 (gonza): Charly hiciste mal la logica creo, el punto Y siempre da el opuesto, revisa eso.

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
