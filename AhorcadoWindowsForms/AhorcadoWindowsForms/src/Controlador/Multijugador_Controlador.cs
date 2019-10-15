using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AhorcadoWindowsForms.src.Modelo;

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
                // Validacion del nombre del jugador

                TextBox nombreJugador_TextBox = panel.Controls.Find("nombreJugador_TextBox", true).FirstOrDefault() as TextBox;
                if (nombreJugador_TextBox.Text == "" || nombreJugador_TextBox.Text == null)
                {
                    datosIngresados = false;
                    //Mensaje de error: Todos los jugadores deben tener nombre
                    MessageBox.Show("Todos los jugadores deben tener nombre");
                    return datosIngresados;
                }
                else
                {
                    if (nombres.Contains(nombreJugador_TextBox.Text))
                    {
                        datosIngresados = false;
                        //Mensaje de error: No se pueden repetir los nombres de los jugadores
                        MessageBox.Show("No se pueden repetir los nombres de los jugadores");
                        return datosIngresados;
                    }
                    else
                    {
                        nombres.Add(nombreJugador_TextBox.Text);
                    }
                }


                //Validacion de la palabra a adivinar por el jugador

                TextBox palabraElegida_TextBox = panel.Controls.Find("palabraElegida_TextBox", true).FirstOrDefault() as TextBox;
                if (palabraElegida_TextBox.Text == "" || palabraElegida_TextBox.Text == null)
                {
                    datosIngresados = false;
                    //Mensaje de error: Todos los jugadores deben tener una palabra a adivinar
                    MessageBox.Show("Todos los jugadores deben tener una palabra a adivinar");
                    return datosIngresados;
                }
                else
                {
                    if (palabraElegida_TextBox.Text.Length <= 1)
                    {
                        datosIngresados = false;
                        //Mensaje de error: Las palabras a adivinar deben tener 2 letras como mínimo
                        MessageBox.Show("Las palabras a adivinar deben tener 2 letras como mínimo");
                        return datosIngresados;
                    }
                }
            }

            return datosIngresados;
        }


        public List<ParametrosPartidaMultijugador> SetearParametroPartidaMultijugador(List<Panel> paneles)
        {
            List<ParametrosPartidaMultijugador> parametrosPartidaMultijugador = new List<ParametrosPartidaMultijugador>();

            foreach (Panel panel in paneles)
            {
                ParametrosPartidaMultijugador parametros = new ParametrosPartidaMultijugador();

                TextBox nombreJugador_TextBox = panel.Controls.Find("nombreJugador_TextBox", true).FirstOrDefault() as TextBox;
                parametros.NombreJugador = nombreJugador_TextBox.Text;

                TextBox palabraElegida_TextBox = panel.Controls.Find("palabraElegida_TextBox", true).FirstOrDefault() as TextBox;
                parametros.Palabra = palabraElegida_TextBox.Text;

                parametrosPartidaMultijugador.Add(parametros);
            }     

            return parametrosPartidaMultijugador;
        }
    }
}
