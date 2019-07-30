using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Juego
    {
        public int NumeroDeJugadores;
        
        public void LeerCantidadDeJugadores()
        {
            bool isInt;
            do
            {
                Console.Write("¿Cuántas personas van a jugar?: ");
                isInt = int.TryParse(Console.ReadLine(), out NumeroDeJugadores);
                if (!isInt)
                {
                    Console.WriteLine("La cantidad de jugadores no es válida.");
                }
                else if (NumeroDeJugadores <= 0 || NumeroDeJugadores > 20)
                {
                    Console.WriteLine("La cantidad de jugadores no es válida.");
                    isInt = false;
                }
            }
            while (!isInt);
            Console.Clear();
        }
        protected string PedirIntento()
        {
            string intento;
            do
            {
                Console.Write("Dame el intento: ");
                intento = Console.ReadLine().ToUpper();
                if (intento == "") //if para ignorar si el jugador no ingresa nada
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
                else
                {
                    intento = intento.Replace("Á", "A");
                    intento = intento.Replace("É", "E");
                    intento = intento.Replace("Í", "I");
                    intento = intento.Replace("Ó", "O");
                    intento = intento.Replace("Ú", "U");
                    break;
                }
            } while (true);
            return intento;
        }
    }
}
