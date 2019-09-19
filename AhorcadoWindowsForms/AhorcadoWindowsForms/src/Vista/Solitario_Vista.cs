using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AhorcadoWindowsForms.src.Controlador;
using AhorcadoWindowsForms.src.Modelo;

namespace AhorcadoWindowsForms.src.Vista
{
    class Solitario_Vista : PantallaPredefinida
    {
        

        #region Atributos

        Button aleatorio_Button;
        Button niveles_Button;
        Solitario_Controlador controlador;

        #endregion


        #region Controles

        public Solitario_Vista(Form1 pantallaPrincipal) : base(pantallaPrincipal)
        {
            controlador = new Solitario_Controlador();

            //
            // modoAleatorioButton
            //
            aleatorio_Button = new Button();
            aleatorio_Button.Location = new System.Drawing.Point(350, 300);
            aleatorio_Button.Size = new System.Drawing.Size(128, 44);
            aleatorio_Button.TabIndex = 1;
            aleatorio_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aleatorio_Button.Text = "Aleatorio";
            aleatorio_Button.UseVisualStyleBackColor = true;
            pantallaPrincipal.Controls.Add(aleatorio_Button);
            aleatorio_Button.Click += new System.EventHandler(this.Aleatorio_Button_Click);

            //
            // modoNivelesButton
            //
            niveles_Button = new Button();
            niveles_Button.Location = new System.Drawing.Point(730, 300);
            niveles_Button.Size = new System.Drawing.Size(128, 44);
            niveles_Button.TabIndex = 1;
            niveles_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            niveles_Button.Text = "Niveles";
            niveles_Button.UseVisualStyleBackColor = true;
            pantallaPrincipal.Controls.Add(niveles_Button);
            niveles_Button.Click += new System.EventHandler(this.Niveles_Button_Click);

        }

        #endregion


        #region Metodos

        private void Aleatorio_Button_Click(object sender, EventArgs e)
        {
            LimpiarVista();

            ParametrosPartida parametrosPartida = new ParametrosPartida();
            parametrosPartida = controlador.ObtenerParametrosPartidaRandom();

            //new Juego_Vista(pantallaPrincipal, parametrosPartida);
        }
        private void Niveles_Button_Click(object sender, EventArgs e)
        {
            LimpiarVista();

            //new Niveles_Vista(pantallaPrincipal);
        }
        private void LimpiarVista()
        {
            pantallaPrincipal.Controls.Remove(niveles_Button);
            pantallaPrincipal.Controls.Remove(aleatorio_Button);
        }

        #endregion


    }
}
