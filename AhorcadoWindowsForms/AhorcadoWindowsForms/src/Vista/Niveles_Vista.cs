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
    class Niveles_Vista
    {


        #region Atributos

        Form1 pantallaPrincipal;
        Niveles_Controlador controlador;

        #endregion


        #region Constructor
        public Niveles_Vista(Form1 pantallaPrincipal)
        {
            this.pantallaPrincipal = pantallaPrincipal;

            this.controlador = new Niveles_Controlador();

            //
            // Botones
            //
            int nivel = 1;
            int x = 0;
            int y = 20;
            int numeroDeFilas = 4;
            int numeroDeColumnas = 5;

            for (int i = 0; i < numeroDeFilas ; i++)
            {
                y += 130;
                x = 20;
                for (int j = 0; j < numeroDeColumnas; j++)
                {
                    x += 180;
                    CrearBoton(nivel, x, y);
                    nivel++;
                }
            }
        }

        #endregion


        #region Metodos
        private void CrearBoton(int nivel, int x, int y)
        {
            Button boton = new Button();

            boton.Location = new System.Drawing.Point(x, y);
            boton.Size = new System.Drawing.Size(40, 40);
            boton.UseVisualStyleBackColor = true;
            boton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            boton.Text = nivel.ToString();
            pantallaPrincipal.Controls.Add(boton);
            boton.Click += delegate (object sender, EventArgs e) { Boton_Click(sender, e, nivel); };

        }

        public void Boton_Click(object sender, EventArgs e, int nivel)
        {
            LimpiarVista();

            ParametrosPartidaUnJugador parametrosPartida = new ParametrosPartidaUnJugador();
            parametrosPartida = controlador.ObtenerParametrosPartida(nivel);

            new Juego_Vista(pantallaPrincipal, parametrosPartida);
        }

        private void LimpiarVista()
        {
            pantallaPrincipal.Controls.Clear();
            new PantallaPredefinida(pantallaPrincipal);
        }

        #endregion 


    }
}
