using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoWindowsForms.src.Modelo
{
    class IndiceMultijugador
    {
        int indice;
        int valorMaximo;

        public IndiceMultijugador(int valorMaximo)
        {
            this.valorMaximo = valorMaximo - 1;
        }

        public int Indice
        {
            get
            {
                return indice;
            }
            set
            {
                if (value > valorMaximo)
                {
                    indice = 0;
                }
                else
                {
                    indice = value;
                }
            }
        }



    }
}
