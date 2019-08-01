using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoGonzalo
{
    class Juego
    {
        //Esta clase se encarga de preguntar y ejecutar el juego que el usuario selecciona
        public void ElegirYEjecutarJuego()
        {
            bool juegoExiste;
            do
            {
                juegoExiste = true;
                Console.WriteLine("JUEGOS:\n");
                Console.WriteLine("1. Ahorcado\n");
                Console.Write("¿Qué juego deseas jugar?: ");
                string opcion = Console.ReadLine();
                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        Ahorcado.Ejecutar(); //Aca ejecutamos el juego ahorcado.
                        break;
                    default:
                        Console.WriteLine("El juego seleccionado no existe.\n");
                        juegoExiste = false;
                        break;
                }
            } while (!juegoExiste);
        }
    }
}
