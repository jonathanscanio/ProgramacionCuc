using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoWindowsForm
{
    class AhorcadoGame
    {
        public string palabraElegida;
        public StringBuilder sbGuiones;
        public int vidas;
        public string intentosErroneos;
        public string pista;

        public AhorcadoGame(string palabraF, int vidasF, bool mostrarIntentosF, bool mostrarPrimerLetraF) //Tradicional(sin pista)
        {
            //palabra
            palabraElegida = palabraF;

            //vidas
            vidas = vidasF;

            //sbGuiones
            sbGuiones = new StringBuilder(palabraElegida);
            for (int i = 0; i < palabraElegida.Length; i++)
            {
                sbGuiones[i] = '_';
            }

            //mostrarPrimerLetra
            if (mostrarPrimerLetraF)
            {
                ComprobarIntento(palabraElegida[0].ToString());
            }

            //mostrarIntentos
            if (mostrarIntentosF)
            {
                intentosErroneos = "";
            }

        }

        public AhorcadoGame(string palabraF, string pistaF) //Solitario solo varia la pista y la palabra
        {
            //palabra
            palabraElegida = palabraF;

            //vidas
            vidas = 6;

            //pista
            pista = pistaF;

            //sbGuiones
            sbGuiones = new StringBuilder(palabraElegida);
            for (int i = 0; i < palabraElegida.Length; i++)
            {
                sbGuiones[i] = '_';
            }

            //mostrarIntentos
            intentosErroneos = "";
        }

        public void ComprobarIntento(string intento)
        {
            if (intento.Length == 1)
            {
                if (palabraElegida.Contains(intento))
                {
                    for (int i = 0; i < palabraElegida.Length; i++)
                    {
                        if (intento == palabraElegida[i].ToString())
                        {
                            sbGuiones[i] = intento[0];
                        }
                    }
                }
                else vidas--;
            }
            else
            {
                if (intento == palabraElegida)
                {
                    sbGuiones = new StringBuilder(palabraElegida);
                }
                else vidas--;
            }
        }










        //private void IniciarGuiones()
        //{
        //    sbGuiones = new StringBuilder(palabraElegida);
        //    for (int i = 0; i < palabraElegida.Length; i++)
        //    {
        //        sbGuiones[i] = '_';
        //    }
        //}

    }
}
