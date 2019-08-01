using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoGonzalo
{
    class Ahorcado //Esta clase seria la principal del juego ahorcado, pregunta y ejecuta modo de juego
    {
        public static void Ejecutar()
        {
            Ahorcado esteAhorcado = new Ahorcado();
            esteAhorcado.ElegirYEjecutarModoJuego();
        }
        private void ElegirYEjecutarModoJuego()
        {
            bool modoJuegoExiste;
            do
            {
                modoJuegoExiste = true;
                Console.WriteLine("Modos de juego:\n");
                Console.WriteLine("1. Ahorcado Tradicional");
                Console.WriteLine("2. Ahorcado Niveles");
                Console.WriteLine("3. Ahorcado Multijugador\n");
                Console.Write("¿Qué modo de juego deseas jugar?: ");
                string opcion = Console.ReadLine();
                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        PartidaAhorcadoTradicional.Ejecutar();
                        break;
                    case "2":
                        PartidaAhorcadoNiveles.Ejecutar();
                        break;
                    case "3":
                        PartidaAhorcadoMultijugador.Ejecutar();
                        break;
                    default:
                        Console.WriteLine("El juego seleccionado no existe.\n");
                        modoJuegoExiste = false;
                        break;
                }
            } while (!modoJuegoExiste);

        }

    }
}
