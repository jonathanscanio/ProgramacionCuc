using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class ModoSolitario : Juego
    {
        private PartidaSolitario Partida = new PartidaSolitario();
        public void LeerNombreYPalabraDelJugador()
        {
            Partida.LeerNombreDelJugador();
            Partida.LeerPalabraElegida();
            Partida.IniciarGuiones();
            Partida.LeerVidas();
        }
        public void IniciarCicloDeAhorcado()
        {
            bool reemplazo;
            Partida.ImprimirGuiones();
            do
            {
                reemplazo = Partida.LogicaReemplazar(PedirIntento());
                if (!reemplazo) Partida.Vidas--;
                Partida.ImprimirGuiones();
            } while (!Partida.Ganar || Partida.Vidas != 0);
        }
        public void MostrarResultados()
        {
            if (Partida.Ganar) Console.WriteLine("\nFelicidades, ganaste!!!");
            else Console.WriteLine("\nHas perdido, suerte la próxima.");
        }
    }
}
