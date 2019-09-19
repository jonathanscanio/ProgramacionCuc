using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoWindowsForms.src.Modelo
{
    class ParametrosPartida : PartidaSuperClase
    {

        bool mostrarIntentos;
        bool mostrarPrimerLetra;

        #region Controles Publicos (get, set)

        public bool MostrarIntentos { get => mostrarIntentos; set => mostrarIntentos = value; }
        public bool MostrarPrimerLetra { get => mostrarPrimerLetra; set => mostrarPrimerLetra = value; }

        #endregion

    }
}
