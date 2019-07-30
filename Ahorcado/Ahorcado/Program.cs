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

            Juego juego = new Juego();

            juego.LeerCantidadDeJugadores();

            if (juego.NumeroDeJugadores > 1)
            {
                ModoMultijugador modoMultijugador = new ModoMultijugador();
                modoMultijugador.NumeroDeJugadores = juego.NumeroDeJugadores;
                modoMultijugador.LeerNombreYPalabraDeJugadores();
                modoMultijugador.IniciarCicloDeAhorcado();
                modoMultijugador.MostrarResultados();
            }
            else
            {
                ModoSolitario modoSolitario = new ModoSolitario();
                modoSolitario.LeerNombreYPalabraDelJugador();
                modoSolitario.IniciarCicloDeAhorcado();
                modoSolitario.MostrarResultados();
            }
        }
    }
}
