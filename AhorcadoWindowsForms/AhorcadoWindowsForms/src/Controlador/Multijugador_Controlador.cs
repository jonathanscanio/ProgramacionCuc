using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoWindowsForms.src.Controlador
{
    class Multijugador_Controlador
    {
        public bool VerificarNombresPalabras(List<Panel> paneles)
        {
            bool datosIngresados = true;

            List<string> nombres = new List<string>();

            foreach (Panel panel in paneles)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control.TabIndex == 2) //tabIndex del control nombreJugador
                    {
                        if (control.Text == "" || control.Text == null)
                        {
                            datosIngresados = false;
                            //Mensaje de error: Todos los jugadores deben tener nombre
                            return datosIngresados;
                        }
                        else
                        {
                            if (nombres.Contains(control.Text))
                            {
                                datosIngresados = false;
                                //Mensaje de error: No se pueden repetir los nombres de los jugadores
                                return datosIngresados;
                            }
                            else
                            {
                                nombres.Add(control.Text);
                            }
                        }
                    }
                    else
                    {
                        if (control.TabIndex == 3) //TabIndex del control palabraJugador
                        {
                            if (control.Text == "" || control.Text == null)
                            {
                                datosIngresados = false;
                                //Mensaje de error: Todos los jugadores deben tener una palabra a adivinar
                                return datosIngresados;
                            }
                        }
                    }
                }
            }
            return datosIngresados;
        }
    }
}
