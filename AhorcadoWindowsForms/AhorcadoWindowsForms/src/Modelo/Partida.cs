using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoWindowsForms.src.Modelo
{
    class Partida : PartidaSuperClase
    {

        StringBuilder guiones;
        string intentosErrones;

        #region Controles Publicos (get, set)

        public StringBuilder Guiones { get => guiones; set => guiones = value; }
        public string IntentosErroneos { get => intentosErrones; set => intentosErrones = value; }
        

        #endregion

    }
}
