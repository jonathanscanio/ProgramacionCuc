using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEcuaciones
{
    class SistemaDeEcuaciones
    {
        #region Atributos
        public double solucionX;
        public double solucionY;
        public string tiposistema;
        public string solucion;
        public double deltasistema;
        public double deltaX;
        public double deltaY;
        public Ecuacion e1;
        public Ecuacion e2;
        #endregion

        #region Constructor
        public SistemaDeEcuaciones(Ecuacion ecuacion1, Ecuacion ecuacion2)
        {
            e1 = ecuacion1;
            e1.coefx = Math.Round(e1.coefx,2);
            e1.coefy = Math.Round(e1.coefy, 2);
            e1.coefindep = Math.Round(e1.coefindep, 2);

            e2 = ecuacion2;
            e2.coefx = Math.Round(e2.coefx, 2);
            e2.coefy = Math.Round(e2.coefy, 2);
            e2.coefindep = Math.Round(e2.coefindep, 2);
        }
        #endregion

        #region Métodos
        private string DeterminarTipo()
        {

            double x = e1.coefx / e2.coefx;
            double y = e1.coefy / e2.coefy;
            double indep = e1.coefindep / e2.coefindep;

            if (x == y && y == indep)
            {
                tiposistema = "Indeterminado";
            }
            else
            {
                if (x == y && y != indep)
                {
                    tiposistema = "Incompatible";
                }
                if (x != y)
                {
                    tiposistema = "Determinado";
                }

            }

            return tiposistema;


        }

        private double SacarDelta(double x1, double x2, double y1, double y2)
        {
            double delta;

            delta = (x1 * y2) - (x2 * y1);

            delta = Math.Round(delta , 2);

            return delta;
        }

        public void EjecutarDeterminante()
        {

            switch (DeterminarTipo())
            {
                case "Determinado":

                    deltasistema = SacarDelta(e1.coefx, e2.coefx, e1.coefy, e2.coefy);
                    deltaX = SacarDelta(e1.coefindep, e2.coefindep, e1.coefy, e2.coefy);
                    deltaY = SacarDelta(e1.coefx, e2.coefx, e1.coefindep, e2.coefindep);

                    solucionX = deltaX / deltasistema;
                    solucionY = deltaY / deltasistema;

                    //Para truncar el numero a 2 decimales
                    solucionX = Math.Round(solucionX, 2);
                    solucionY = Math.Round(solucionY, 2);

                    tiposistema = "Sistema Compatible Determinado";
                    solucion = $"S= ({solucionX} ; {solucionY})";

                    break;

                case "Indeterminado":

                    tiposistema = "Sistema Compatible Indeterminado";
                    solucion = "S= (-∞ ; ∞)";

                    break;

                case "Incompatible":

                    tiposistema = "Sistema Incompatible";
                    solucion = "S= ø ";

                    break;

                default: break;

            }


        }

        public void ResetearValores()
        {
            solucion = "";
            tiposistema = "";
            solucionX = 0;
            solucionY = 0;
            deltasistema = 0;
            deltaX = 0;
            deltaY = 0;
            e1.coefx = 0;
            e1.coefy = 0;
            e1.coefindep = 0;
            e1.ecuacion = "ax + by = c";
            e2.coefx = 0;
            e2.coefy = 0;
            e2.coefindep = 0;
            e2.ecuacion = "ax + by = c";
        }

        #endregion

    }
}
