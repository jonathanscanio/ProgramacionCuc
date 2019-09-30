using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoWindowsForms.src.Vista
{
    class MenuPrincipal_Vista
    {


        #region Atributos

        Form1 pantallaPrincipal;
        Label nombreJuego_Label;
        Button solitario_Button;
        Button tradicional_Button;
        Button multijugador_Button;
        Button instrucciones_Button;
        Button creditos_Button;

        #endregion


        #region Constructor (Controles)
        public MenuPrincipal_Vista(Form1 pantallaPrincipal)
        {
            this.pantallaPrincipal = pantallaPrincipal;

            //
            // nombreJuego_Label
            //
            nombreJuego_Label = new Label();
            nombreJuego_Label.AutoSize = true;
            nombreJuego_Label.Location = new System.Drawing.Point(475, 120);
            nombreJuego_Label.Size = new System.Drawing.Size(35, 13);
            nombreJuego_Label.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreJuego_Label.ForeColor = System.Drawing.Color.White;
            nombreJuego_Label.TabIndex = 0;
            nombreJuego_Label.Text = "AHORCADO";
            pantallaPrincipal.Controls.Add(nombreJuego_Label);

            //
            // solitario_Button
            //
            solitario_Button = new Button();
            solitario_Button.Location = new System.Drawing.Point(200, 300);
            solitario_Button.Size = new System.Drawing.Size(128, 44);
            solitario_Button.TabIndex = 1;
            solitario_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            solitario_Button.Text = "Solitario";
            solitario_Button.UseVisualStyleBackColor = true;
            pantallaPrincipal.Controls.Add(solitario_Button);
            solitario_Button.Click += new System.EventHandler(this.Solitario_Button_Click);

            //
            // tradicional_Button
            //
            tradicional_Button = new Button();
            tradicional_Button.Location = new System.Drawing.Point(520, 300);
            tradicional_Button.Size = new System.Drawing.Size(128, 44);
            tradicional_Button.TabIndex = 1;
            tradicional_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tradicional_Button.Text = "Tradicional";
            tradicional_Button.UseVisualStyleBackColor = true;
            pantallaPrincipal.Controls.Add(tradicional_Button);
            tradicional_Button.Click += new System.EventHandler(this.Tradicional_Button_Click);

            //
            // multijugador_Button
            //
            multijugador_Button = new Button();
            multijugador_Button.Location = new System.Drawing.Point(830, 300);
            multijugador_Button.Size = new System.Drawing.Size(128, 44);
            multijugador_Button.TabIndex = 1;
            multijugador_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            multijugador_Button.Text = "Multijugador";
            multijugador_Button.UseVisualStyleBackColor = true;
            pantallaPrincipal.Controls.Add(multijugador_Button);
            multijugador_Button.Click += new System.EventHandler(this.Multijugador_Button_Click);

            //
            // instrucciones_Button
            //
            instrucciones_Button = new Button();
            instrucciones_Button.Location = new System.Drawing.Point(800, 580); //posicion
            instrucciones_Button.Size = new System.Drawing.Size(120, 30); //tamaño
            instrucciones_Button.TabIndex = 1;
            instrucciones_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            instrucciones_Button.Text = "Instrucciones"; //texto dentro
            instrucciones_Button.UseVisualStyleBackColor = true;
            pantallaPrincipal.Controls.Add(instrucciones_Button); // agregar a pantalla
            instrucciones_Button.Click += new System.EventHandler(this.Instrucciones_Button_Click);

            //
            // creditos_Button
            //
            creditos_Button = new Button();
            creditos_Button.Location = new System.Drawing.Point(1000, 580);
            creditos_Button.Size = new System.Drawing.Size(100, 30);
            creditos_Button.TabIndex = 1;
            creditos_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            creditos_Button.Text = "Créditos";
            creditos_Button.UseVisualStyleBackColor = true;
            pantallaPrincipal.Controls.Add(creditos_Button);
            creditos_Button.Click += new System.EventHandler(this.Creditos_Button_Click);

        }

        #endregion


        #region Metodos (Botones)
        private void Solitario_Button_Click(object sender, EventArgs e)
        {
            LimpiarVista();
            new Solitario_Vista(pantallaPrincipal);
        }
        private void Tradicional_Button_Click(object sender, EventArgs e)
        {
            LimpiarVista();
            new Tradicional_Vista(pantallaPrincipal);
        }
        private void Multijugador_Button_Click(object sender, EventArgs e)
        {
            LimpiarVista();
            new Multijugador_Vista(pantallaPrincipal);
        }
        private void Instrucciones_Button_Click(object sender, EventArgs e)
        {
            LimpiarVista();
            new Instrucciones_Vista(pantallaPrincipal);
        }
        private void Creditos_Button_Click(object sender, EventArgs e)
        {
            LimpiarVista();
            new Creditos_Vista(pantallaPrincipal);
        }

        private void LimpiarVista()
        {
            pantallaPrincipal.Controls.Remove(nombreJuego_Label);
            pantallaPrincipal.Controls.Remove(solitario_Button);
            pantallaPrincipal.Controls.Remove(tradicional_Button);
            pantallaPrincipal.Controls.Remove(multijugador_Button);
            pantallaPrincipal.Controls.Remove(instrucciones_Button);
            pantallaPrincipal.Controls.Remove(creditos_Button);
        }

        #endregion


    }
}
