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

            //Edit (gonza): Ya está termiando el método PedirDatos(), cuando quieras saca el bloque de comentarios.
            //Edit2 (gonza): NO puse un Console.Clear(); al final de la funcion PedirDatos(), si queres que se borre la consola escribilo en la misma funcion PedirDatos().
            //Edit3 (gonza): Charly hiciste mal la logica creo, el punto Y siempre da el opuesto, revisa eso. (ARREGLADO)


            SistemaDeEcuaciones Sistema1 = new SistemaDeEcuaciones();
            Ecuacion e1 = new Ecuacion();
            Ecuacion e2 = new Ecuacion();

            e1.PedirDatos();
            e2.PedirDatos();


            //Profe, acá quería ver si habia forma de crear una "variable" que solo me pueda devolver 3 valores distintos, porque sino es un desperdicio de memoria. Creo que existía una forma pero no puedo acordar.

            string TipoDeSistema = Sistema1.TipoDeSistema(e1,e2); //Evalua que tipo de Sistema es.

           switch (TipoDeSistema)
            {
                case "Sistema Compatible Determinado":
                    Sistema1.Ejecutar(e1, e2);
                    Console.Clear();
                    Console.WriteLine(e1.ecuacion + "\n" + e2.ecuacion + "\n" + TipoDeSistema + "\n" + Sistema1.ToString());
                    break;
                case "Sistema Compatible Indeterminado":
                    Console.Clear();
                    Console.WriteLine(e1.ecuacion + "\n" + e2.ecuacion + "\nSus ecuaciones forman un: Sistema Compatible Indeterminado\nPor lo tanto sus rectas son iguales, y tiene infinitas soluciones.");
                    break;
                case "Sistema Incompatible":
                    Console.Clear();
                    Console.WriteLine(e1.ecuacion + "\n" + e2.ecuacion + "\nSus ecuaciones forman un: Sistema Incompatible\nPor lo tanto sus rectas son paralelas, y no tienen ninguna solución");
                    break;
            }

            Console.ReadKey();

        }
    }
}
