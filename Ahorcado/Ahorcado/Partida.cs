using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Partida
    {
        public string NombreDelJugador;
        public string PalabraElegida;
        public StringBuilder SbGuiones; 
        public bool Ganar = false;


        public void LeerPalabraElegida()
        {
            bool esPalabra;
            do
            {
                Console.Write("Escriba la palabra para el jugador " + NombreDelJugador + ": ");
                PalabraElegida = "";

                do //algoritmo de internet, escribe la palabra como contraseña, no tocar.
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    // Backspace Should Not Work
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        PalabraElegida += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && PalabraElegida.Length > 0)
                        {
                            PalabraElegida = PalabraElegida.Substring(0, (PalabraElegida.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                } while (true);
                Console.WriteLine("");

                if (PalabraElegida.Length > 1)
                {
                    PalabraElegida = PalabraElegida.ToUpper();
                    if (PalabraElegida.Contains("\0")) //manejo de tildes, no tocar, se complementa con el algoritmo anterior.
                    {
                        PalabraElegida = PalabraElegida.Remove(PalabraElegida.IndexOf("\0"), 1);
                        PalabraElegida = PalabraElegida.Replace("Á", "A");
                        PalabraElegida = PalabraElegida.Replace("É", "E");
                        PalabraElegida = PalabraElegida.Replace("Í", "I");
                        PalabraElegida = PalabraElegida.Replace("Ó", "O");
                        PalabraElegida = PalabraElegida.Replace("Ú", "U");
                    }
                    esPalabra = Regex.IsMatch(PalabraElegida, @"^[A-Z]+$");
                }
                else esPalabra = false;

                if (!esPalabra)
                {
                    Console.WriteLine("La palabra elegida no es válida.");
                }
            } while (!esPalabra);
            Console.Clear();
        }
        public void IniciarGuiones()
        {
            SbGuiones = new StringBuilder(PalabraElegida);
            for (int i = 0; i < PalabraElegida.Length; i++)
            {
                SbGuiones[i] = '_';
            }
        }
        public bool LogicaReemplazar(string intento)
        {
            bool reemplazo = false;
            if (intento.Length == 1)
            {
                if (PalabraElegida.Contains(intento))
                {
                    for (int i = 0; i < PalabraElegida.Length; i++)
                    {
                        if (intento == PalabraElegida[i].ToString())
                        {
                            SbGuiones[i] = intento[0]; //No se que hace el [0] pero funciona, no tocar.
                            reemplazo = true;
                        }
                    }
                }
            }
            else
            {
                if (intento == PalabraElegida)
                {
                    SbGuiones = new StringBuilder(PalabraElegida);
                    reemplazo = true;
                }
            }
            if (!SbGuiones.ToString().Contains("_"))
            {
                Ganar = true;
            }
            return reemplazo;
        }
        
    }
}
