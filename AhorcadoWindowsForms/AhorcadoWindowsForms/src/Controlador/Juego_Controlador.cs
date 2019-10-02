using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AhorcadoWindowsForms.src.Modelo;

namespace AhorcadoWindowsForms.src.Controlador
{
    class Juego_Controlador
    {
        PartidaUnJugador partida;

        public PartidaUnJugador CrearPartida(ParametrosPartidaUnJugador parametros)
        {
            partida = new PartidaUnJugador();
        
            partida.Palabra = parametros.Palabra.ToUpper();

            partida.Vidas = parametros.Vidas;

            partida.Pista = parametros.Pista;

            partida.IntentosErroneos = "";

            partida.Nivel = parametros.Nivel;

            partida.Guiones = new StringBuilder(partida.Palabra);
            for (int i = 0; i < partida.Palabra.Length; i++)
            {
                partida.Guiones[i] = '-';
            }

            if (parametros.MostrarPrimerLetra)
            {
                ComprobarIntento(partida.Palabra[0].ToString());
            }
                
            return partida;
        }

        public PartidaUnJugador ComprobarIntento(string intento)
        {
            intento = intento.ToUpper();

            if (intento != "")
            {
                if (intento.Length == 1)
                {
                    if (partida.Palabra.Contains(intento))
                    {
                        for (int i = 0; i < partida.Palabra.Length; i++)
                        {
                            if (intento == partida.Palabra[i].ToString())
                            {
                                partida.Guiones[i] = intento[0];
                            }
                        }
                    }
                    else
                    {
                        partida.Vidas--;
                    }

                }
                else
                {
                    if (intento == partida.Palabra)
                    {
                        partida.Guiones = new StringBuilder(partida.Palabra);
                    }
                    else
                    {
                        partida.Vidas--;
                    }
                }
                partida.IntentosErroneos = intento;
            }

            return partida;
        }
    }
}
