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
        public string playerName;
        public string palabraElegida;
        public StringBuilder sbGuiones; 
        public bool win = false; 

        public void GetPlayerName(int ignore) 
        {
            do
            {
                Console.Write("Dame el nombre del jugador " + ignore + ": ");
                playerName = Console.ReadLine();
                if (playerName == "")
                {
                    Console.WriteLine("El jugador debe tener nombre.");
                }
                else break;
            } while (true);
        }
        public void GetPalabraElegida() 
        {
            bool esPalabra;
            do
            {
                Console.Write("Escriba la palabra para el jugador " + playerName + ": ");
                palabraElegida = "";

                do //algoritmo de internet, escribe la palabra como contraseña, no tocar.
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    // Backspace Should Not Work
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        palabraElegida += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && palabraElegida.Length > 0)
                        {
                            palabraElegida = palabraElegida.Substring(0, (palabraElegida.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                } while (true);
                Console.WriteLine("");

                if (palabraElegida.Length > 1)
                {
                    palabraElegida = palabraElegida.ToUpper();
                    if (palabraElegida.Contains("\0")) //manejo de tildes, no tocar, se complementa con el algoritmo anterior.
                    {
                        palabraElegida = palabraElegida.Remove(palabraElegida.IndexOf("\0"), 1);
                        palabraElegida = palabraElegida.Replace("Á", "A");
                        palabraElegida = palabraElegida.Replace("É", "E");
                        palabraElegida = palabraElegida.Replace("Í", "I");
                        palabraElegida = palabraElegida.Replace("Ó", "O");
                        palabraElegida = palabraElegida.Replace("Ú", "U");
                    }
                    esPalabra = Regex.IsMatch(palabraElegida, @"^[A-Z]+$");
                }
                else esPalabra = false;
                
                if (!esPalabra)
                {
                    Console.WriteLine("La palabra elegida no es válida.");
                }
            } while (!esPalabra);
        }
        public void IniciarGuiones()
        {
            sbGuiones = new StringBuilder(palabraElegida);
            for (int i = 0; i < palabraElegida.Length; i++)
            {
                sbGuiones[i] = '_';
            }
        }
        public void ImprimirGuiones()
        {
            Console.Clear();
            Console.WriteLine("Ahorcado correspondiente a: " + playerName + "\n\n\n\n");
            Console.Write("            ");
            for (int i = 0; i < palabraElegida.Length; i++)
            {
                Console.Write(" " + sbGuiones[i].ToString());
            }
            Console.WriteLine("");
        }
        public bool LogicaReemplazar(string intento)
        {
            bool reemplazo = false;
            if (intento.Length == 1)
            {
                if (palabraElegida.Contains(intento))
                {
                    for (int i = 0; i < palabraElegida.Length; i++)
                    {
                        if (intento == palabraElegida[i].ToString())
                        {
                            sbGuiones[i] = intento[0]; //No se que hace el [0] pero funciona, no tocar.
                            reemplazo = true;
                        }
                    }
                }
            }
            else
            {
                if (intento == palabraElegida)
                {
                    sbGuiones = new StringBuilder(palabraElegida);
                    reemplazo = true;
                }
            }
            if (!sbGuiones.ToString().Contains("_"))
            {
                win = true;
            }
            return reemplazo;
        }
    }
}
