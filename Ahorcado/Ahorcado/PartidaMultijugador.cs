using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class PartidaMultijugador : Partida
    {
        public void LeerNombreDelJugador(int ignore)
        {
            do
            {
                Console.Write("Dame el nombre del jugador " + ignore + ": ");
                NombreDelJugador = Console.ReadLine();
                if (NombreDelJugador == "")
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
                else break;
            } while (true);
        }
        public void ImprimirGuiones()
        {
            Console.Clear();
            Console.WriteLine("Ahorcado correspondiente a: " + NombreDelJugador + "\n\n\n\n");
            Console.Write("            ");
            for (int i = 0; i < PalabraElegida.Length; i++)
            {
                Console.Write(" " + SbGuiones[i].ToString());
            }
            Console.WriteLine("");
        }
        
    }
}
