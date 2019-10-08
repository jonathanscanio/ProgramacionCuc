using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoWindowsForms.src.Modelo
{
    class ParametrosPartidaUnJugador : ParametrosPartidaGenerales
    {
        int vidas;
        string pista;
        bool mostrarIntentos;
        bool mostrarPrimerLetra;
        int nivel;

        #region Controles Publicos (get, set)
        public int Vidas { get => vidas; set => vidas = value; }
        public string Pista { get => pista; set => pista = value; }
        public bool MostrarIntentos { get => mostrarIntentos; set => mostrarIntentos = value; }
        public bool MostrarPrimerLetra { get => mostrarPrimerLetra; set => mostrarPrimerLetra = value; }
        public int Nivel { get => nivel; set => nivel = value; }

        #endregion

    }
}
