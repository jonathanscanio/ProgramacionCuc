using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AhorcadoWindowsForms.src.Modelo;
using AhorcadoWindowsForms.src.Vista;

namespace AhorcadoWindowsForms.src.Controlador
{
    class JuegoMultijugador_Controlador
    {
        public PartidaMultijugador CrearPartidaMultijugador(ParametrosPartidaMultijugador parametros)
        {
            PartidaMultijugador partida = new PartidaMultijugador();

            partida.NombreJugador = parametros.NombreJugador;

            partida.Palabra = parametros.Palabra.ToUpper();

            partida.Guiones = new StringBuilder(partida.Palabra);
            for (int i = 0; i < partida.Palabra.Length; i++)
            {
                partida.Guiones[i] = '-';
            }

            return partida;
        }
        public (PartidaMultijugador, bool) ComprobarIntento(PartidaMultijugador partida, string intento)
        {
            bool reemplazo = true;

            if (intento != "")
            {
                intento = intento.ToUpper();

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
                        reemplazo = false;
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
                        reemplazo = false;
                    }
                }
            }

            return (partida, reemplazo);
        }
    }
}
