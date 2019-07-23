using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado_solitario
{
    class Program
    {
        static void Main(string[] args)
        {
            //INTRODUCCION

            //PEDIR PALABRA Y CONFIRMAR PALABRA
            string palabra;
            bool repetirPalabra = false;
            string preguntaConfirmarPalabra = "¿DESEA VOLVER A ESCRIBIR LA PALABRA?";
            do
            {
                palabra = PedirPalabra();
                repetirPalabra = SiNoFuncion(preguntaConfirmarPalabra);
            } while (repetirPalabra);

            //LIMPIAR CONSOLA
            LimpiarConsola();

            //PEDIR SI CAMBAIR DIFICULTAD
            string preguntaCambiarDificultad = "¿DESEA CONFIGURAR LA DIFICULTAD?\nRECUERDE QUE POR DEFECTO SE MUESTRAN LOS INTENTOS ERRÓNEOS, LA PRIMER LETRA DE LA PALABRA.\nLAS CANTIDAD DE VIDAS O INTENTOS ES: 6";
            bool cambiarDificultad = SiNoFuncion(preguntaCambiarDificultad);

            //VARIABLES DE LA DIFICULTAD 
            int vidas;
            bool mostrarPrimerLetra, guardarIntentos;
            string preguntaMostrarPrimerLetra, preguntaGuardarIntentos;

            if (!cambiarDificultad)
            {
                vidas = 6;
                mostrarPrimerLetra = true;
                guardarIntentos = true;
            }
            else
            {
                //PEDIR VIDAS
                LimpiarConsola();
                vidas = PedirVidas();

                //PEDIR SI MOSTRAR LA PRIMERA LETRA
                LimpiarConsola();
                preguntaMostrarPrimerLetra = "¿DESEA QUE SE MUESTRE LA PRIMER LETRA DE LA PALABRA A MODO DE AYUDA?";
                mostrarPrimerLetra = SiNoFuncion(preguntaMostrarPrimerLetra);

                //PEDIR SI LOS INTENTOS SE GUARDAN
                LimpiarConsola();
                preguntaGuardarIntentos = "¿DESEA QUE LAS LETRAS O INTENTOS ERRÓNEOS SE MUESTREN EN PANTALLA?";
                guardarIntentos = SiNoFuncion(preguntaGuardarIntentos);
            }

            //ARREGLO DE PALABRA
            string[] palabraArreglo = PalabraEnArreglo(palabra);

            //ARREGLO DE GUIONES
            string[] guionesArreglo = new string[palabra.Length];
            for (int i = 0; i < palabra.Length; i++)
            {
                guionesArreglo[i] = "_";
            }

            //MOSTRAR PRIMERA LETRA
            if (mostrarPrimerLetra)
            {
                for (int i = 0; i < palabraArreglo.Length; i++)
                {
                    if (palabraArreglo[0] == palabraArreglo[i])
                    {
                        guionesArreglo[i] = palabraArreglo[0];
                    }
                }
            }

            //LIMPIAR CONSOLA
            LimpiarConsola();

            //MOSTRAR GUIONES Y VIDAS
            ImprimirGuionesVidas(guionesArreglo, vidas);

            //COMANDO SUELTO
            Console.WriteLine("");

            //VARIABLES NECESARIAS PARA LA LÓGICA
            int guiones = 0;
            bool ganar = false;
            bool reemplazo = false;
            string intento = "";
            Queue intentosQueue = new Queue();

            //DO
            do
            {
                //PEDIR INTENTO
                Console.WriteLine("");
                Console.Write("INGRESA LA LETRA QUE QUIERAS PROBAR: ");
                intento = Console.ReadLine().ToUpper();
                intento = IgnorarTildes(intento);

                //DECLARACION DE VARIABLES SUELTAS
                reemplazo = false;
                guiones = 0;

                if (intento.Length <= 2)
                {
                    if (intento.Length != 0)
                    {
                        //LOGICA DE REEMPLAZAR INTENTO POR GUION
                        for (int i = 0; i < palabraArreglo.Length; i++)
                        {
                            if (intento == palabraArreglo[i])
                            {
                                guionesArreglo[i] = intento;
                                reemplazo = true;
                            }
                        }
                        if (!reemplazo)
                        {
                            vidas--;
                            intentosQueue.Enqueue(intento);
                        }
                        guiones = Array.IndexOf(guionesArreglo, "_");
                        if (guiones < 0)
                        {
                            ganar = true;
                        }
                    }
                }
                else
                {
                    string preguntaComprobarIntentoEsPalabra = "¿ESTÁ SEGURO QUE DESEA ARRIESGAR A ADIVINAR LA PALABRA?\nSI NO ACIERTA, PERDERÁ Y TERMINARÁ EL JUEGO.";
                    bool comprobarIntentoEsPalabra = SiNoFuncion(preguntaComprobarIntentoEsPalabra);
                    if (comprobarIntentoEsPalabra)
                    {
                        if (intento == palabra)
                        {
                            guionesArreglo = PalabraEnArreglo(intento);
                            ganar = true;
                            guiones = -1;
                        }
                        else
                        {
                            vidas = 0;
                            intentosQueue.Enqueue(intento);
                        }
                    }
                }

                //IMPRIMIR GUIONES Y VIDAS RESTANTES
                LimpiarConsola();
                ImprimirGuionesVidas(guionesArreglo, vidas);

                //IMPRIMIR INTENTOS
                if (guardarIntentos)
                {
                    Console.Write("    INTENTOS ERRÓNEOS: ");
                    foreach (string i in intentosQueue)
                    {
                        Console.Write(i + ", ");
                    }
                }
                Console.WriteLine("");

            } while (vidas != 0 && guiones >= 0);

            //MOSTRAR SI GANO O PERDIO
            Console.WriteLine("");
            Console.WriteLine("");
            if (ganar)
            {
                Console.WriteLine("        GANASTE!!!");
            }
            else
            {
                Console.WriteLine("        PERDISTE :(");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("LA RESPUESTA CORRECTA ERA: " + palabra);
            }

            //CREDITOS
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                     Program made by Gonzalo");
        }
        static string PedirPalabra()
        {
            bool esPalabra = true;
            string cadena;
            do
            {
                Console.Write("INGRESE LA PALABRA QUE QUIERE QUE SU COMPAÑERO ADIVINE: ");
                cadena = "";
                //ALGORITMO PARA QUE LA PALABRA INGRESADA, EN PANTALLA SE VEA COMO UNA CONTRASEÑA

                do //Algoritmo de internet (https://stackoverflow.com/questions/3404421/password-masking-console-application)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    // Backspace Should Not Work
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        cadena += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && cadena.Length > 0)
                        {
                            cadena = cadena.Substring(0, (cadena.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                } while (true);
                Console.WriteLine("");
                cadena = cadena.ToUpper();
                string caracter = "\0";
                StringBuilder cadena1 = new StringBuilder(cadena);
                if (cadena.Contains("Á") || cadena.Contains("É") || cadena.Contains("Í") || cadena.Contains("Ó") || cadena.Contains("Ú"))
                {
                    if (cadena.Contains(caracter))
                    {
                        int posicion = cadena.IndexOf(caracter);
                        cadena1.Remove(posicion, 1);
                        cadena = cadena1.ToString();
                    }
                }

                esPalabra = true;
                StringBuilder cadena2 = new StringBuilder(cadena);
                for (int i = 0; i < cadena.Length; i++)
                {
                    string letra = cadena[i].ToString();
                    switch (letra)
                    {
                        case "A":
                        case "B":
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "G":
                        case "H":
                        case "I":
                        case "J":
                        case "K":
                        case "L":
                        case "M":
                        case "N":
                        case "Ñ":
                        case "O":
                        case "P":
                        case "Q":
                        case "R":
                        case "S":
                        case "T":
                        case "U":
                        case "V":
                        case "W":
                        case "X":
                        case "Y":
                        case "Z":
                            break;
                        case "Á":
                            cadena2[i] = 'A';
                            break;
                        case "É":
                            cadena2[i] = 'E';
                            break;
                        case "Í":
                            cadena2[i] = 'I';
                            break;
                        case "Ó":
                            cadena2[i] = 'O';
                            break;
                        case "Ú":
                            cadena2[i] = 'U';
                            break;
                        default:
                            esPalabra = false;
                            i = cadena.Length;
                            Console.Clear();
                            Console.WriteLine("LA PALABRA INGRESADA NO CUMPLE CON LAS CONDICIONES, POR FAVOR INTENTE OTRA VEZ.");
                            break;
                    }
                }
                cadena = cadena2.ToString();
                if (cadena.Length == 0 || cadena.Length == 1)
                {
                    esPalabra = false;
                    Console.Clear();
                    Console.WriteLine("LA PALABRA INGRESADA NO CUMPLE CON LAS CONDICIONES, POR FAVOR INTENTE OTRA VEZ.");
                }
            } while (!esPalabra);
            return cadena;
        }
        static int PedirVidas()
        {
            int numero;
            bool esInt;
            do
            {
                do
                {
                    Console.Write("INGRESA LA CANTIDAD DE VIDAS: ");
                    string entrada = Console.ReadLine();
                    esInt = int.TryParse(entrada, out numero);
                    if (!esInt)
                    {
                        LimpiarConsola();
                        Console.WriteLine("LA CANTIDAD DE VIDAS INGRESADAS NO SON VÁLIDAS, POR FAVOR INTENTE OTRA VEZ.");
                    }
                    else
                    {
                        if (numero < 1 || numero > 27)
                        {
                            LimpiarConsola();
                            Console.WriteLine("LA CANTIDAD DE VIDAS INGRESADAS NO SON VÁLIDAS, POR FAVOR INTENTE OTRA VEZ.");
                        }
                    }
                } while (numero < 1 || numero > 27);

            } while (!esInt); // Este codigo no fue copiado de lo que hizo el profesor, guiño guiño
            return numero;
        }
        static void ImprimirGuionesVidas(string[] guionesArreglo, int vidas)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("        ");
            for (int i = 0; i < guionesArreglo.Length; i++)
            {
                Console.Write(" " + guionesArreglo[i]);
            }
            Console.Write("    VIDAS RESTANTES: " + vidas);
        }
        static void LimpiarConsola()
        {
            Console.Clear();
        }
        static bool SiNoFuncion(string pregunta)
        {
            bool booleano = false;
            string decision;
            do
            {
                Console.Write(pregunta + " (SI/NO): ");
                decision = Console.ReadLine().ToLower();
                if (decision != "si" && decision != "sí" && decision != "no")
                {
                    LimpiarConsola();
                    Console.WriteLine("OPCIÓN ELEGIDA NO VÁLIDA");
                }
                else
                {
                    if (decision == "sí" || decision == "si")
                    {
                        booleano = true;
                    }
                }
            } while (decision != "si" && decision != "sí" && decision != "no");
            return booleano;
        }
        static string IgnorarTildes(string cadena)
        {

            cadena = cadena.ToUpper();
            cadena = cadena.Replace("Á", "A");
            cadena = cadena.Replace("É", "E");
            cadena = cadena.Replace("Í", "I");
            cadena = cadena.Replace("Ó", "O");
            cadena = cadena.Replace("Ú", "U");
            return cadena;
        }
        static string[] PalabraEnArreglo(string cadena)
        {
            string[] arreglo = new string[cadena.Length];
            for (int i = 0; i < cadena.Length; i++)
            {
                arreglo[i] = cadena[i].ToString();
            }
            return arreglo;
        }
    }
}
