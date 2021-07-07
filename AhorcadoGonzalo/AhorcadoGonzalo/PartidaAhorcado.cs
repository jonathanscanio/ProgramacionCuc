using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoGonzalo
{
    class PartidaAhorcado 
    {
        //Esta clase no se comunica directamente con el camino principal del programa (nunca se crea una instancia de esta clase). 
        //Solo estan los atributos y metodos que comparten los modos de juego, hecha para ahorrar codigo.
        //Cada subclase tiene sus metodos y atributos agregados que necesitan para su logica
        //Cada subclase tiene un metodo ejecutar que se encarga de todo. Solamente con llamar a ese metodo el modo de juego se ejecuta solo. 
        protected string palabraElegida;
        protected StringBuilder sbGuiones;
        protected bool ganar = false;
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
        protected void IniciarGuiones()
        {
            sbGuiones = new StringBuilder(palabraElegida);
            for (int i = 0; i < palabraElegida.Length; i++)
            {
                sbGuiones[i] = '_';
            }
        }
        protected bool LogicaReemplazar(string intento)
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
                ganar = true;
            }
            return reemplazo;
        }
        protected void PedirPalabraElegida()
        {
            bool esPalabra;
            do
            {
                Console.Write("Escriba la palabra a adivinar: ");
                do
                {
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
                    if (palabraElegida == "")
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                    }
                    else break;
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
    }
}
