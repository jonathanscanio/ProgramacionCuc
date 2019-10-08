using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoWindowsForms.src.Modelo
{
    class PartidaMultijugador : PartidaGeneral
    {
        string nombreJugador;

        public string NombreJugador { get => nombreJugador; set => nombreJugador = value; }
    }
}
