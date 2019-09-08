using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEcuaciones
{
    class Ecuacion
    {
        #region Atributos
        public string ecuacion;
        public double coefx; //Coeficiente de X
        public double coefy; //Coeficiente de Y
        public double coefindep; //Término Independiente
        #endregion

        //Estos métodos quedaron para ser implementados luego.

        #region Métodos
        /*
         FORMA 1: ax + by = c
         FORMA 2: by = c - ax
         FORMA 3: ax = c - by      
         */

        public void FormaDos()
        {
            //Pasaje de Forma 2 a Forma 1
            coefx = -coefx;
            ecuacion = $"{coefx}x + {coefy}y = {coefindep}";

        }
        public void FormaTres()
        {
            //Pasaje de Forma 3 a Forma 1
            coefy = -coefy;
            ecuacion = $"{coefx}x + {coefy}y = {coefindep}";
        }
        #endregion

    }


}

