using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoWindowsForms.src.Modelo
{
    class ParametrosPartidaMultijugador : ParametrosPartidaGenerales
    {
        string nombreJugador;

        #region Controles Publicos (get, set)

        public string NombreJugador { get => nombreJugador; set => nombreJugador = value; }

        #endregion
    }
}
