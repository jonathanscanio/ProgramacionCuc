using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoGonzalo
{
    class PartidaAhorcadoMultijugador : PartidaAhorcado
    {
        private string nombreJugador;
        private static int PedirCantidadJugadores()
        {
            int numeroJugadores;
            bool isInt;
            do
            {
                Console.Write("¿Cuántas personas van a jugar?: ");
                isInt = int.TryParse(Console.ReadLine(), out numeroJugadores);
                if (!isInt)
                {
                    Console.WriteLine("La cantidad de jugadores no es válida.");
                }
                else if (numeroJugadores <= 0 || numeroJugadores > 20)
                {
                    Console.WriteLine("La cantidad de jugadores no es válida.");
                    isInt = false;
                }
            }
            while (!isInt);
            Console.Clear();
            return numeroJugadores;
        }
        private void PedirNombreJugador(int ignore)
        {
            do
            {
                Console.Write("Dame el nombre del jugador " + ignore + ": ");
                nombreJugador = Console.ReadLine();
                if (nombreJugador == "")
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
                else break;
            } while (true);
        }
        private void ImprimirGuiones()
        {
            Console.Clear();
            Console.WriteLine("Ahorcado correspondiente a: " + nombreJugador + "\n\n\n\n");
            Console.Write("            ");
            for (int i = 0; i < palabraElegida.Length; i++)
            {
                Console.Write(" " + sbGuiones[i].ToString());
            }
            Console.WriteLine("");
        }
        public static void Ejecutar()
        {
            //Iniciar partida
            PartidaAhorcadoMultijugador[] partida = new PartidaAhorcadoMultijugador[PartidaAhorcadoMultijugador.PedirCantidadJugadores()];

            //Pedir datos
            Queue NombresJugadoresQueue = new Queue();
            for (int i = 0; i < partida.Length; i++)
            {
                partida[i] = new PartidaAhorcadoMultijugador();
                do
                {
                    partida[i].PedirNombreJugador(i + 1); //ignorar el i+1, es para que se vea mejor en la consola
                    if (NombresJugadoresQueue.Contains(partida[i].nombreJugador))
                    {
                        Console.WriteLine("El jugador " + partida[i].nombreJugador + " ya existe.");
                    }
                    else
                    {
                        NombresJugadoresQueue.Enqueue(partida[i].nombreJugador);
                        break;
                    }
                } while (true);
                partida[i].PedirPalabraElegida();
                partida[i].IniciarGuiones();
                Console.Clear();
            }

            //Logica
            Queue ganadores = new Queue();
            bool reemplazo;
            do //ciclo principal del juego, termina cuando hay ganadores
            {
                for (int i = 0; i < partida.Length; i++) //ciclo para que pasen todos los jugadores, termina cuando cada jugador pasa por el ciclo
                {
                    do //ciclo que pide y comprueba intentos, imprime el ahorcado, termina cuando falla o gana
                    {
                        partida[i].ImprimirGuiones();

                        Console.WriteLine("\n"); //ignorar

                        reemplazo = partida[i].LogicaReemplazar(partida[i].PedirIntento());
                        //LogicaReemplazar necesita el intento como parámetro y devuelve si el intento era correcto o no.

                        if (reemplazo)// if para optimizar, ignorar
                        {
                            partida[i].ImprimirGuiones();
                        }

                    } while (reemplazo && !partida[i].ganar);

                    if (!partida[i].ganar)
                    {
                        Console.WriteLine("\n\nIntento fallido.\nPresiona cualquier tecla para pasar al siguiente jugador: ");
                    }
                    else
                    {
                        ganadores.Enqueue(partida[i].nombreJugador);
                        Console.WriteLine("\n\nPalabra completada!!!\nPresiona cualquier tecla para pasar al siguiente jugador: ");
                    }
                    Console.ReadKey(true);
                }
            } while (ganadores.Count == 0);
            Console.Clear();

            //Mostrar Resultado
            if (ganadores.Count == 1)
            {
                Console.WriteLine("El ganador es: \n");
            }
            else Console.WriteLine("Los ganadores son: \n");
            foreach (string i in ganadores)
            {
                Console.WriteLine(i);
            }
        }

    }
}
