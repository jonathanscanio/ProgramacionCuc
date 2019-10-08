using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoWindowsForms.src.Modelo
{
    class PartidaGeneral : ParametrosPartidaGenerales
    {
        StringBuilder guiones;

        #region Controles Publicos (get, set)

        public StringBuilder Guiones { get => guiones; set => guiones = value; }

        #endregion

    }
}
