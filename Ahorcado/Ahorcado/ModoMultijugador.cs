using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class ModoMultijugador : Juego
    {
        private PartidaMultijugador[] Partida;
        private Queue Ganadores = new Queue();
        public void LeerNombreYPalabraDeJugadores()
        {
            Partida = new PartidaMultijugador[NumeroDeJugadores];
            Queue playersQueue = new Queue();
            for (int i = 0; i < NumeroDeJugadores; i++)
            {
                Partida[i] = new PartidaMultijugador();
                do
                {
                    Partida[i].LeerNombreDelJugador(i + 1); //ignorar el i+1, es para que se vea mejor en la consola
                    if (playersQueue.Contains(Partida[i].NombreDelJugador))
                    {
                        Console.WriteLine("El jugador " + Partida[i].NombreDelJugador + " ya existe.");
                    }
                    else
                    {
                        playersQueue.Enqueue(Partida[i].NombreDelJugador);
                        break;
                    }
                } while (true);
                Partida[i].LeerPalabraElegida();
                Partida[i].IniciarGuiones();
            }
        }
        public void IniciarCicloDeAhorcado()
        {
            bool reemplazo;

            do //ciclo principal del juego, termina cuando hay ganadores
            {
                for (int i = 0; i < NumeroDeJugadores; i++) //ciclo para que pasen todos los jugadores, termina cuando cada jugador pasa por el ciclo
                {
                    do //ciclo que pide y comprueba intentos, imprime el ahorcado, termina cuando falla o gana
                    {
                        Partida[i].ImprimirGuiones();

                        Console.WriteLine("\n"); //ignorar

                        reemplazo = Partida[i].LogicaReemplazar(PedirIntento());
                        //LogicaReemplazar necesita el intento como parámetro y devuelve si el intento era correcto o no.

                        if (reemplazo)// if para optimizar, ignorar
                        {
                            Partida[i].ImprimirGuiones();
                        }

                    } while (reemplazo && !Partida[i].Ganar);

                    if (!Partida[i].Ganar)
                    {
                        Console.WriteLine("\n\nIntento fallido.\nPresiona cualquier tecla para pasar al siguiente jugador: ");
                    }
                    else
                    {
                        Ganadores.Enqueue(Partida[i].NombreDelJugador);
                        Console.WriteLine("\n\nPalabra completada!!!\nPresiona cualquier tecla para pasar al siguiente jugador: ");
                    }
                    Console.ReadKey(true);
                }

            } while (Ganadores.Count == 0);

            Console.Clear();
        }
        public void MostrarResultados()
        {
            if (Ganadores.Count == 1)
            {
                Console.WriteLine("El ganador es: \n");
            }
            else Console.WriteLine("Los ganadores son: \n");
            foreach (string i in Ganadores)
            {
                Console.WriteLine(i);
            }
        }
    }
}
