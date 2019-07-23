using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoFaseFinal
{
    class Program
    {



        static void Main(string[] args)
        {
            Inicio();

        }
        static void Inicio()
        {
            bool seguir = true;
            do
            {

                Console.WriteLine("BIENVENIDO AL AHORCADO");
                Console.WriteLine("Elige el modo que quieres");
                Console.WriteLine("1.MODO SOLITARIO");
                Console.WriteLine("2.MODO 1 VS 1");
                Console.WriteLine("3.MODO POR NIVELES");
                Console.WriteLine("\nCREDITOS - Para ver los creditos del proyecto");
                Console.WriteLine("SALIR - Para salir del programa\n");
                Console.Write("Ingrese la opción: ");
                string leer = Console.ReadLine();
                leer = leer.ToLower();

                if (leer == "creditos" || leer == "salir")
                {
                    if (leer == "creditos")
                    {
                        Console.Clear();
                        Console.WriteLine("Proyecto realizado por: Carlos Moreno\nCurso de programación\nColegio Universitario Central - 2019\nPodes leer más en: ");
                        
                        Console.Read();
                    }
                    if (leer == "salir") Environment.Exit(0);
                }

                switch (leer)
                {
                    case "1": ModoSolitario(); break;
                    case "2": Modo1v1(); break;
                    case "3": ModoNiveles(); break;
                    default: seguir = true; Console.Clear(); Console.WriteLine("ERROR INTENTE NUEVAMENTE"); break;
                }
            }
            while (seguir);

        }


        static void ModoNiveles()
        {
            int niveles = 0;
            string[] palabras = new string[15];
            palabras[0] = "Clima";
            palabras[1] = "Llegar";
            palabras[2] = "Helice";
            palabras[3] = "Sotana";
            palabras[4] = "Iceberg";
            palabras[5] = "Fundamento";
            palabras[6] = "Herviboro";
            palabras[7] = "Labios";
            palabras[8] = "Farol";
            palabras[9] = "Cartuchera";
            palabras[10] = "Pizarra";
            palabras[11] = "Estufa";
            palabras[12] = "Bufanda";
            palabras[13] = "Frazada";
            palabras[14] = "Oliva";

            string[] pistas = new string[15];
            pistas[0] = "Conjunto de características atmosféricas.";
            pistas[1] = "Sinónimo de Arrivar.";
            pistas[2] = "Lo que le permite volar a un helicóptero.";
            pistas[3] = "Vestimenta de un sacerdote.";
            pistas[4] = "Masa de hielo flotante";
            pistas[5] = "Sinónimo de Argumento, motivo, razón.";
            pistas[6] = "Que se alimenta de vegetales.";
            pistas[7] = "Son los pliegues que forman el inicio de la boca, en el conjunto de la cabeza y como inicio del aparato digestivo.";
            pistas[8] = "Es un objeto en forma de caja o cilindro con paredes de vidrio, en cuyo interior se coloca una luz.";
            pistas[9] = "Donde se guardan útiles escolares.";
            pistas[10] = "Se usa para escribir o dibujar cuando es necesario que lo vea un conjunto de personas.";
            pistas[11] = "Aparato que produce calor para calentar ambientes.";
            pistas[12] = "Prenda de vestir que consiste en una tira larga y ancha de lana, seda o piel que se lleva alrededor del cuello.";
            pistas[13] = "Manta de cama gruesa y peluda que proporciona mucho calor.";
            pistas[14] = "También conocida como Aceituna.";

            while (niveles < palabras.Length)
            {
                int vidas = 10;
                string cadena = palabras[niveles].ToUpper();
                string pistasniv = pistas[niveles];
                bool ganar = Ahorcado(cadena, vidas, niveles, pistasniv);
                if (!ganar)
                {
                    Console.WriteLine("LO SIENTO HAS PERDIDO, DEBES VOLVER A EMPEZAR");
                    niveles = palabras.Length + 1;
                }

                else
                {
                    Console.WriteLine("HAS TERMINADO EL MODO NIVELES. MUCHAS GRACIAS POR JUGAR");
                    Console.Read();
                }

                niveles++;

            }


            Console.Read();

        }

        static void ModoSolitario()
        {
            string[] palabras = { "argentina", "Chile", "Uruguay", "Bolivia", "Peru", "Colombia", "Ecuador" };
            string cadena = RandomPalabra(palabras).ToUpper();
            int vidas = 5;
            Ahorcado(cadena, vidas);
        }
        static void Modo1v1()
        {
            Console.Clear();

            string cadena = PedirPalabra();
            int vidasINT;
            bool isInt;
            do
            {
                Console.Write("Ingrese la cantidad de VIDAS que quiere que tenga su compañero: ");
                string leer = Console.ReadLine();
                isInt = int.TryParse(leer, out vidasINT);
                if (!isInt)
                {
                    Console.WriteLine("El número ingresado no es entero");
                }
            }
            while (!isInt);

            Ahorcado(cadena, vidasINT);

        }
        static string RandomPalabra(string[] palabras)
        {
            //BUSCO UNA PALABRA RANDOM DENTRO DEL ARREGLO QUE CONTIENE MIS PALABRAS.
            Random rnd = new Random();
            int random = rnd.Next(0, palabras.Length); //RANDOM VA A SER UN NÚMERO ENTRE 0 Y LA CANTIDAD DE PALABRAS QUE TENGA EL ARREGLO.
            string cadena = palabras[random];
            return cadena;
        }

        static string[] ArregloPalabra(string cadena)
        {
            //CREA UN ARREGLO, CON CADA LETRA DE LA CADENA.
            string[] arreglo = new string[cadena.Length];

            for (int i = 0; i < cadena.Length; i++)
            {
                arreglo[i] = cadena[i].ToString();

            }
            return arreglo;

        }

        static string[] ArregloGuiones(string cadena)
        {
            string[] guiones = new string[cadena.Length];

            for (int i = 0; i < cadena.Length; i++)
            {
                guiones[i] = "_ ";
            }
            return guiones;

        }

        static string[] BuscarLetraRepetida(string letra, string[] guiones, string cadena)
        {

            int[] repetidas = new int[cadena.Length];

            for (int i = 0; i < cadena.Length; i++)
            {
                repetidas[i] = cadena.IndexOf(letra, i);
            }

            for (int i = 0; i < repetidas.Length; i++)
            {
                if (repetidas[i] >= 0)
                    guiones[repetidas[i]] = letra;
                else i = repetidas.Length;
            }
            return guiones;
        }

        static void EscribirGuiones(string[] guiones, string cadena)
        {
            for (int i = 0; i < cadena.Length; i++)
            {
                Console.Write(guiones[i]);
            }
        }

        static string PedirLetra()
        {
            Console.Write("INGRESE LETRA: ");
            string leer = Console.ReadLine();
            leer = leer.ToUpper();
            return leer;

        }

        static void Ganaste(string cadena)
        {
            Console.WriteLine("Has adivinado, la palabra era: " + cadena.ToUpper());
            Console.WriteLine("");
            Console.WriteLine("FELICITACIONES GANASTE!!");
        }

        static void Perdiste(string cadena)
        {
            Console.Clear();
            Console.WriteLine("LO SIENTO HAS PERDIDO");
            Console.WriteLine("La palabra era: " + cadena);
        }

        static string[] BuscarLetraRandom(string cadena, string[] guiones)
        {

            Random rnd = new Random();
            int random = rnd.Next(0, cadena.Length);
            string letrarandom = cadena[random].ToString();
            guiones = BuscarLetraRepetida(letrarandom, guiones, cadena);
            return guiones;
        }

        static bool Ahorcado(string palabra, int contador, int niveles = -1, string pista = "En este modo no hay pistas.")
        {
            string cadena = palabra.ToUpper();
            string[] arreglo = ArregloPalabra(cadena);
            string[] guiones = ArregloGuiones(cadena);
            Queue<string> LetrasIngresadas = new Queue<string>();
            BuscarLetraRandom(cadena, guiones);
            bool ganar = true;

            while (contador > 0)
            {
                bool igual = guiones.SequenceEqual(arreglo);
                if (igual == false)
                {
                    if (niveles < 0)
                    {
                        Console.Clear();
                        EscribirGuiones(guiones, cadena);
                        Console.WriteLine("");
                        Console.WriteLine("\tVIDAS: " + contador);
                        Console.Write("LETRAS INGRESADAS: ");
                        foreach (string i in LetrasIngresadas)
                        {
                            Console.Write(i + "; ");

                        }
                        Console.WriteLine("");
                    }
                    if (niveles >= 0)
                    {
                        Console.Clear();
                        EscribirGuiones(guiones, cadena);
                        Console.WriteLine("");
                        Console.WriteLine("NIVEL: " + niveles);
                        Console.WriteLine("\tVIDAS: " + contador);
                        Console.Write("LETRAS INGRESADAS: ");
                        foreach (string i in LetrasIngresadas)
                        {
                            Console.Write(i + "; ");

                        }
                        Console.WriteLine("");
                    }

                    string letra = PedirLetra();

                    if (letra != "PISTA" && letra != cadena && letra != "SALIR")
                    {

                        bool Ingresada = LetrasIngresadas.Contains(letra);
                        if (!Ingresada)
                        {
                            LetrasIngresadas.Enqueue(letra);
                            if (cadena.Contains(letra))
                            {
                                guiones = BuscarLetraRepetida(letra, guiones, cadena);
                                EscribirGuiones(guiones, cadena);
                            }
                            else contador--;
                        }



                    }
                    else //INGRESA LA PISTA
                    {
                        if (letra == "PISTA")
                        {
                            Console.WriteLine(pista);
                            Console.Write("Ingrese una letra para continuar");
                            string leer = Console.ReadLine();
                            
                        }
                        if (letra == cadena)
                        {
                            guiones = arreglo;
                        }
                        if (letra == "SALIR")
                        {
                            Environment.Exit(0);

                        }
                    }
                }
                else contador = -1;

            }
            if (guiones.SequenceEqual(arreglo))
            {
                Console.Clear();
                Ganaste(cadena);
                Console.Read();
                return ganar;
            }
            else Console.Clear(); Perdiste(cadena); Console.Read(); return !ganar;




        }


        static string PedirPalabra()
        {
            bool correcta = true;
            string cadena;
            do
            {
                Console.WriteLine("TEN CUIDADO DE NO EQUIVOCARTE");
                Console.Write("Ingrese la palabra que quiere que su compañero adivine: ");

                /* cadena = "";

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
                } while (true); */
                cadena = Console.ReadLine();
                cadena = cadena.ToLower();
                correcta = true;
                StringBuilder cadena1 = new StringBuilder(cadena);
                for (int i = 0; i < cadena.Length; i++)
                {
                    string letra = cadena[i].ToString();
                    switch (letra)
                    {
                        case "a":
                        case "b":
                        case "c":
                        case "d":
                        case "e":
                        case "f":
                        case "g":
                        case "h":
                        case "i":
                        case "j":
                        case "k":
                        case "l":
                        case "m":
                        case "n":
                        case "ñ":
                        case "o":
                        case "p":
                        case "q":
                        case "r":
                        case "s":
                        case "t":
                        case "u":
                        case "v":
                        case "w":
                        case "x":
                        case "y":
                        case "z": break;
                        //Ignorar tildes
                        case "á":
                            cadena1[i] = 'a';
                            break;
                        case "é":
                            cadena1[i] = 'e';
                            break;
                        case "í":
                            cadena1[i] = 'i';
                            break;
                        case "ó":
                            cadena1[i] = 'o';
                            break;
                        case "ú":
                            cadena1[i] = 'u';
                            break;

                        default:
                            correcta = false;
                            Console.Clear();
                            Console.WriteLine("La cadena ingresada no cumple con las condiciones, por favor intente otra vez.");
                            i = cadena.Length;
                            break;
                    }
                }
                cadena = cadena1.ToString();
            } while (!correcta);
            return cadena;
        }

        

    }
    
}
