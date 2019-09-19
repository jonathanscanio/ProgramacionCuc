using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoWindowsForms.src.Modelo
{
    class Partida
    {
        string palabra;
        int vidas;
        StringBuilder guiones;
        string intentosErrones;
        string pista;

        #region Controles Publicos (get, set)

        public string Palabra { get => palabra; set => palabra = value; }
        public int Vidas { get => vidas; set => vidas = value; }
        public StringBuilder Guiones { get => guiones; set => guiones = value; }
        public string IntentosErroneos { get => intentosErrones; set => intentosErrones = value; }
        public string Pista { get => pista; set => pista = value; }

        #endregion

    }
}
