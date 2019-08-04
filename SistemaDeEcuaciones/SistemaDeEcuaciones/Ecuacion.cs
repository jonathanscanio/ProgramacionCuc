using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeEcuaciones
{
    class Ecuacion
    {
        //LOGICA A DESARROLLAR POR GONZALO ORTIZ
        public string ecuacion;
        public float coefX;
        public float coefY;
        public float indep;

        public void PedirDatos()
        {
            /*
            Logica terminada. Basicamente pide por consola la ecuacion y asigna estos valores a los atributos de la instancia.
            Esta hecha de manera que el usuario no pueda ingresar datos erroneos.
            O sea, deberia en todos los casos setear bien los coeficientes. 
            El modelo de ecuacion que se debe seguir es: 3x + 4y = 3, por ejemplo.
            No se permiten escribir espacios, no hay chance de cambiar esto.
            No es necesario entender esta logica, con saber que hace es suficiente.
            Es más, no les recomiendo tratar de entenderla, es un desastre.
            Si no me hacen caso y se ponen a verla y ven alguna optimizacion para hacerle, mandenme un mensaje antes de tocar algo.
            Si encuentran un error, mandenme un mensaje antes de tocar algo.
            Si quieren cambiar el mensaje que se le envia al usario estan en todo su derecho.

            */

            Console.Write("Ingresa la ecuación. Basate en este modelo: -3x + 4y = 6\nNo se pueden escribir fracciones, hay que anotarlas como numeros decimales.\nEcuacion:");

            ecuacion = "";
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    switch (key.KeyChar)
                    {
                        case '-':
                            if (ecuacion.Length == 0 || ecuacion.EndsWith("x") || ecuacion.EndsWith("="))
                            {
                                ecuacion += "-";
                                Console.Write("-");
                            }
                            break;
                        case '+':
                            if (ecuacion.EndsWith("x"))
                            {
                                ecuacion += "+";
                                Console.Write("+");
                            }
                            break;
                        case '0':
                            if (!ecuacion.EndsWith("x") && !ecuacion.EndsWith("y"))
                            {
                                ecuacion += key.KeyChar;
                                Console.Write(key.KeyChar);
                            }
                            break;
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                            if (!ecuacion.EndsWith("x") && !ecuacion.EndsWith("y"))
                            {
                                ecuacion += key.KeyChar;
                                Console.Write(key.KeyChar);
                            }
                            break;
                        case ',':
                            if (ecuacion.Contains(","))
                            {
                                if (ecuacion.Contains("x"))
                                {
                                    if (!ecuacion.Contains("y"))
                                    {
                                        if (ecuacion.LastIndexOf(",") < ecuacion.LastIndexOf("x"))
                                        {
                                            if (!ecuacion.EndsWith("-") && !ecuacion.EndsWith("+") && !ecuacion.EndsWith("x"))
                                            {
                                                ecuacion += ",";
                                                Console.Write(",");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (ecuacion.LastIndexOf(",") < ecuacion.LastIndexOf("y"))
                                        {
                                            if (!ecuacion.EndsWith("-") && !ecuacion.EndsWith("y") && !ecuacion.EndsWith("="))
                                            {
                                                ecuacion += ",";
                                                Console.Write(",");
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (!ecuacion.EndsWith("-") && !ecuacion.EndsWith("+") && !ecuacion.EndsWith("x") && !ecuacion.EndsWith("y") && !ecuacion.EndsWith("=") && ecuacion.Length > 0)
                                {
                                    ecuacion += ",";
                                    Console.Write(",");
                                }
                            }
                            break;
                        case 'x':
                        case 'X':
                            if (!ecuacion.Contains("y") && !ecuacion.Contains("x"))
                            {
                                if (!ecuacion.EndsWith("-") && ecuacion.Length != 0)
                                {
                                    if (float.Parse(ecuacion) != 0)
                                    {
                                        ecuacion += key.KeyChar;
                                        Console.Write(key.Key);
                                    }
                                }
                                else
                                {
                                    ecuacion += key.KeyChar;
                                    Console.Write(key.Key);
                                }
                            }
                            break;
                        case 'y':
                        case 'Y':
                            if (ecuacion.Contains("x") && !ecuacion.Contains("y") && !ecuacion.EndsWith("x"))
                            {
                                if (!ecuacion.EndsWith("-") && !ecuacion.EndsWith("+"))
                                {
                                    if (float.Parse(ecuacion.Remove(0, ecuacion.LastIndexOf("x") + 2)) != 0)
                                    {
                                        ecuacion += key.KeyChar;
                                        Console.Write(key.Key);
                                    }
                                }
                                else
                                {
                                    ecuacion += key.KeyChar;
                                    Console.Write(key.Key);
                                }
                            }
                            break;
                        case '=':
                            if (ecuacion.EndsWith("y"))
                            {
                                ecuacion += "=";
                                Console.Write("=");
                            }
                            break;
                        default: break;
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && ecuacion.Length > 0)
                    {
                        ecuacion = ecuacion.Substring(0, (ecuacion.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        if (ecuacion.Contains("=") && !ecuacion.EndsWith("=") && !ecuacion.EndsWith(","))
                        {
                            break;
                        }
                    }
                }
                ecuacion = ecuacion.ToLower();
            } while (true);
            Console.WriteLine();


            //Logica para setear el coeficiente de x
            if (!float.TryParse(ecuacion.Remove(ecuacion.LastIndexOf("x"), ecuacion.Length - ecuacion.LastIndexOf("x")), out coefX))
            {
                if (ecuacion.StartsWith("-")) coefX = -1;
                else coefX = 1;
            }

            //Logica para setear el coeficiente de y
            string ecuacionAlterada = ecuacion.Remove(0, ecuacion.LastIndexOf("x") + 1);
            ecuacionAlterada = ecuacionAlterada.Remove(ecuacionAlterada.LastIndexOf("y"), ecuacionAlterada.Length - ecuacionAlterada.LastIndexOf("y"));
            if (!float.TryParse(ecuacionAlterada, out coefY))
            {
                if (ecuacionAlterada.StartsWith("-")) coefY = -1;
                else coefY = 1;
            }

            //Logica para setear el termino independiente
            indep = float.Parse(ecuacion.Remove(0, ecuacion.LastIndexOf("=") + 1));
        }

        
    }
}
