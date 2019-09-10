using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoWindowsForm
{
    class PalabrasPredefinidas
    {
        private static string[] palabras = { "palabra1", "palabra2", "palabra3", "palabra4", "palabra5", "palabra6", "palabra7", "palabra8", "palabra9", "palabra10", "palabra11", "palabra12", "palabra13", "palabra14", "palabra15", "palabra16", "palabra17", "palabra18", "palabra19", "palabra20" };
        private static string[] pistas = { "pista1", "pista2", "pista3", "pista4", "pista5", "pista6", "pista7", "pista8", "pista9", "pista10", "pista11", "pista12", "pista13", "pista14", "pista15", "pista16", "pista17", "pista18", "pista19", "pista20" };

        public static string PedirPalabra(int i)
        {
            string palabra = palabras[i];
            return palabra;
        }
        public static string PedirPista(int i)
        {
            string pista = pistas[i];
            return pista;
        }
    }
}
