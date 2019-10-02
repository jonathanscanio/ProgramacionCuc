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

            partida.Palabra = parametros.Palabra;

            partida.Guiones = new StringBuilder(partida.Palabra);
            for (int i = 0; i < partida.Palabra.Length; i++)
            {
                partida.Guiones[i] = '-';
            }

            return partida;
        }
    }
}
