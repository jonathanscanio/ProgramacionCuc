using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoWindowsForms.src.Modelo
{
    class PartidaUnJugador : PartidaGeneral
    {
        int vidas;
        string pista;
        string intentosErrones;
        int nivel;

        #region Controles Publicos (get, set)
        public string IntentosErroneos { get => intentosErrones; set => intentosErrones = value; }
        public int Vidas { get => vidas; set => vidas = value; }
        public string Pista { get => pista; set => pista = value; }
        public int Nivel { get => nivel; set => nivel = value; }

        #endregion

    }
}
