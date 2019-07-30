using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class PartidaSolitario : Partida
    {
        public int Vidas;
        public void LeerVidas()
        {
            bool isInt;
            do
            {
                Console.Write("Cuántas vidas tendrá " + NombreDelJugador + ":");
                isInt = int.TryParse(Console.ReadLine(), out Vidas);
                if (!isInt)
                {
                    Console.WriteLine("Las cantidad de vidas tiene que ser un número entero.");
                }
                else if (Vidas <= 0 || Vidas > PalabraElegida.Length)
                {
                    Console.WriteLine("La cantidad de vidas no es válida.");
                    isInt = false;
                }
            }
            while (!isInt);
            Console.Clear();
        }
        public void LeerNombreDelJugador()
        {
            do
            {
                Console.Write("Dame el nombre del jugador: ");
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
            Console.WriteLine("\n\n\n\n");
            Console.Write("            ");
            for (int i = 0; i < PalabraElegida.Length; i++)
            {
                Console.Write(" " + SbGuiones[i].ToString());
            }
            Console.WriteLine("   Vidas restantes: " + Vidas + "\n");
        }
    }
}
