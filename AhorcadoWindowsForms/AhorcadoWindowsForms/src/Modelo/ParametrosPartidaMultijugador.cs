using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoWindowsForms.src.Modelo
{
    class ParametrosPartidaMultijugador
    {
        string palabra;
        string nombreJugador;

        #region Controles Publicos (get, set)

        public string Palabra { get => palabra; set => palabra = value; }
        public string NombreJugador { get => nombreJugador; set => nombreJugador = value; }

        #endregion
    }
}
