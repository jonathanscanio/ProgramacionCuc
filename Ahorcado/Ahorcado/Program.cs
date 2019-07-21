using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Programa ahorcado, observaciones:
            El programa funciona, creo que realize todas las comprobaciones necesarias para que no se pueda trabar.
            Me base en un modo de juego multijugador donde no hay vidas y gana el primero que adivine la palabra.
            Por lo tanto si juega una sola persona (cosa que es posible), no tendria sentido porque nunca perderia.
            Se podria programar para que si juega una sola persona se active el sistema de vidas pero no lo hice.
            Edit: Si el jugador acierta el intento, continua jugando, se pasa al siguiente jugador cuando falla el intento
            Pueden ganar varias personas a la vez, o sea si la persona que comenzo jugando gana, los demas todavia tienen una
            ultima chance de completar la palabra debido a que empezaron despues. Todos tienen la misma cantidad de intentos
            
            Respecto a las comprobaciones:
                -Cantidad de jugadores:
                        .Desde 1 hasta 20.
                -El nombre del jugador: 
                        .Tiene que tener al menos un caracter
                        .Puede ser infinitos caracteres siempre y cuando no esten repetidos con un jugador previo.
                -La palabra elegida:
                        .Desde 2 letras, no hay limite, puede ser infinitas
                        .No puede tener espacios
                        .Puede ser solamente letras, en caso de que escriba una palabra con tilde en una vocal el programa automaticamente 
                        lo elimina y toma la palabra como valida. Si hay dos tildes en vocales distintas la palabra no sera valida.
                -El intento:
                        .Si el jugador en presiona enter para ingresar el intento, se va a tomar como que no apreto nada.
                        .Se reemplazan las vocales con tilde por vocales normales, si es que tiene.
                        .Si es una palabra (mas de dos caracteres) en vez de un solo caracter, se toma como que arriesgo adivinar la palabra,
                        al no haber vidas, si arriegas y no acertas, se cuenta como un intento fallido.

            Las palabras y los intentos se pasan a mayusculas

            Posibles cambios:
            -Permitir que las palabra elegidas puedan ser frases
            -Configurar modo 1 jugador, con vidas
            -Mostrar los intentos fallidos que lleva cada jugador
            -Mostrar la palabra correcta a los que perdieron

            Comunicacion con los usuarios:
            Puse mensajes muy breves y no se explican las reglas o como funciona el programa,
            Se puede mejorar bastante este aspecto, sobre todo al mostrar los ganadores.

            Dejo mensajes para que sea mas facil comprender la logica
            */


            Console.WriteLine("Juego ahorcado\n");

            // PEDIR CANTIDAD DE JUGADORES

            //variables necesarias 
            int players;
            bool isInt;

            do
            {
                Console.Write("¿Cuántas personas van a jugar?: ");
                isInt = int.TryParse(Console.ReadLine(), out players);
                if (!isInt)
                {
                    Console.WriteLine("La cantidad de jugadores no es válida.");
                }
                else if (players <= 0 || players > 20)
                {
                    Console.WriteLine("La cantidad de jugadores no es válida.");
                    isInt = false;
                }
            }
            while (!isInt);

            Console.Clear();

            // PEDIR NOMBRE DE CADA JUGADOR Y SU PALABRA. (TAMBIEN APROVECHO EL CICLO PARA INICIAR EL SB GUIONES)

            //variables necesarias 
            Partida[] partida = new Partida[players];
            Queue playersQueue = new Queue();

            for (int i = 0; i < players; i++)
            {
                partida[i] = new Partida();
                do
                {
                    partida[i].GetPlayerName(i + 1); //ignorar el i+1, es para que se vea mejor en la consola
                    if (playersQueue.Contains(partida[i].playerName))
                    {
                        Console.WriteLine("El jugador " + partida[i].playerName + " ya existe.");
                    }
                    else
                    {
                        playersQueue.Enqueue(partida[i].playerName);
                        break;
                    }
                } while (true);
                partida[i].GetPalabraElegida();
                partida[i].IniciarGuiones();
                Console.Clear();
            }

            // LOGICA PRINCIPAL DEL PROGRAMA

            //variables necesarias 
            Queue winners = new Queue();
            string intento;
            bool reemplazo;

            do //ciclo principal del juego, termina cuando hay ganadores
            {
                for (int i = 0; i < players; i++) //ciclo para que pasen todos los jugadores, termina cuando cada jugador pasa por el ciclo
                {
                    do //ciclo que pide y comprueba intentos, imprime el ahorcado, termina cuando falla o gana
                    {
                        partida[i].ImprimirGuiones();

                        Console.WriteLine("\n"); //ignorar

                        do //ciclo que pide intentos
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

                        reemplazo = partida[i].LogicaReemplazar(intento);

                        if (reemplazo)// if para optimizar, ignorar
                        {
                            partida[i].ImprimirGuiones();
                        }

                    } while (reemplazo && !partida[i].win);

                    if (!partida[i].win)
                    {
                        Console.WriteLine("\n\nIntento fallido.\nPresiona cualquier tecla para pasar al siguiente jugador: ");
                    }
                    else
                    {
                        winners.Enqueue(partida[i].playerName);
                        Console.WriteLine("\n\nPalabra completada!!!\nPresiona cualquier tecla para pasar al siguiente jugador: ");
                    }
                    Console.ReadKey(true);
                }

            } while (winners.Count == 0);

            Console.Clear();


            // MOSTRAR GANADORES

            if (winners.Count == 1)
            {
                Console.WriteLine("El ganador es: \n");
            }
            else Console.WriteLine("Los ganadores son: \n");

            foreach (string i in winners)
            {
                Console.WriteLine(i);
            }
        }
    }
}
