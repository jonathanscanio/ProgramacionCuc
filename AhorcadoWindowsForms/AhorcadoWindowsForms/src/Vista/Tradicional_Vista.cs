using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AhorcadoWindowsForms.src.Modelo;

namespace AhorcadoWindowsForms.src.Vista
{
    class Tradicional_Vista : PantallaPredefinida
    {


        #region Atributos

        Label palabraElegida_Label;
        TextBox palabraElegida_TextBox;
        Label vidas_Label;
        TextBox vidas_TextBox;
        CheckBox mostrarIntentos_CheckBox;
        CheckBox mostrarPrimerLetra_CheckBox;
        Button aceptar_Button;

        #endregion


        #region Constructor (Controles)
        public Tradicional_Vista(Form1 pantallaPrincipal) : base(pantallaPrincipal)
        {
            this.pantallaPrincipal = pantallaPrincipal;
            
            //
            // palabraElegida_Label
            //
            palabraElegida_Label = new Label();
            palabraElegida_Label.Location = new System.Drawing.Point(430, 93);
            palabraElegida_Label.AutoSize = true;
            palabraElegida_Label.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            palabraElegida_Label.ForeColor = System.Drawing.Color.White;
            palabraElegida_Label.Text = "Escriba la palabra a adivinar:";
            pantallaPrincipal.Controls.Add(palabraElegida_Label);

            //
            // palabraElegida_TextBox
            //
            palabraElegida_TextBox = new TextBox();
            palabraElegida_TextBox.Location = new System.Drawing.Point(504, 145);
            palabraElegida_TextBox.Size = new System.Drawing.Size(150, 30);
            palabraElegida_TextBox.TabIndex = 2;
            palabraElegida_TextBox.Text = "";
            palabraElegida_TextBox.PasswordChar = '*';
            palabraElegida_TextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            palabraElegida_TextBox.MaxLength = 14;
            palabraElegida_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetrasValidador);
            pantallaPrincipal.Controls.Add(palabraElegida_TextBox);

            //
            // vidas_Label
            //
            vidas_Label = new Label();
            vidas_Label.Location = new System.Drawing.Point(157, 300);
            vidas_Label.AutoSize = true;
            vidas_Label.TabIndex = 1;
            vidas_Label.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vidas_Label.ForeColor = System.Drawing.Color.White;
            vidas_Label.Text = "Cantidad de vidas: ";
            pantallaPrincipal.Controls.Add(vidas_Label);

            //
            // vidas_TextBox
            //
            vidas_TextBox = new TextBox();
            vidas_TextBox.Location = new System.Drawing.Point(335, 300);
            vidas_TextBox.Size = new System.Drawing.Size(100, 20);
            vidas_TextBox.TabIndex = 2;
            vidas_TextBox.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vidas_TextBox.MaxLength = 2;
            vidas_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosValidador);
            pantallaPrincipal.Controls.Add(vidas_TextBox);

            //
            // mostrarIntentos_CheckBox
            //
            mostrarIntentos_CheckBox = new CheckBox();
            mostrarIntentos_CheckBox.Location = new System.Drawing.Point(150, 400);
            mostrarIntentos_CheckBox.AutoSize = true;
            mostrarIntentos_CheckBox.RightToLeft = RightToLeft.Yes;
            mostrarIntentos_CheckBox.TabIndex = 0;
            mostrarIntentos_CheckBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mostrarIntentos_CheckBox.ForeColor = System.Drawing.Color.White;
            mostrarIntentos_CheckBox.Text = "?Mostrar intentos erróneos¿"; //los signos de pregunta se imprimen al reves
            mostrarIntentos_CheckBox.UseVisualStyleBackColor = true;
            pantallaPrincipal.Controls.Add(mostrarIntentos_CheckBox);

            //
            // mostrarPrimerLetra_CheckBox
            //
            mostrarPrimerLetra_CheckBox = new CheckBox();
            mostrarPrimerLetra_CheckBox.Location = new System.Drawing.Point(150, 500);
            mostrarPrimerLetra_CheckBox.AutoSize = true;
            mostrarPrimerLetra_CheckBox.RightToLeft = RightToLeft.Yes;
            mostrarPrimerLetra_CheckBox.TabIndex = 0;
            mostrarPrimerLetra_CheckBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mostrarPrimerLetra_CheckBox.ForeColor = System.Drawing.Color.White;
            mostrarPrimerLetra_CheckBox.Text = "?Mostrar la primera letra¿";
            mostrarPrimerLetra_CheckBox.UseVisualStyleBackColor = true;
            pantallaPrincipal.Controls.Add(mostrarPrimerLetra_CheckBox);

            //
            // aceptar_Button
            //
            aceptar_Button = new Button();
            aceptar_Button.Location = new System.Drawing.Point(900, 420);
            aceptar_Button.Size = new System.Drawing.Size(151, 132);
            aceptar_Button.TabIndex = 3;
            aceptar_Button.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aceptar_Button.Text = "Aceptar";
            aceptar_Button.UseVisualStyleBackColor = true;
            aceptar_Button.Click += new System.EventHandler(this.Aceptar_Button_Click);
            pantallaPrincipal.Controls.Add(aceptar_Button);
        }

        #endregion


        #region Metodos

        private void Aceptar_Button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(vidas_TextBox.Text, out int vidas))
            {
                if (vidas > 0 && palabraElegida_TextBox.Text.Length > 1)
                {
                    LimpiarVista();

                    ParametrosPartidaUnJugador parametrosPartida = new ParametrosPartidaUnJugador();

                    parametrosPartida.Palabra = palabraElegida_TextBox.Text;
                    parametrosPartida.Vidas = int.Parse(vidas_TextBox.Text);
                    parametrosPartida.MostrarIntentos = mostrarIntentos_CheckBox.Checked;
                    parametrosPartida.MostrarPrimerLetra = mostrarPrimerLetra_CheckBox.Checked;

                    new Juego_Vista(pantallaPrincipal, parametrosPartida);
                }
            }
            else
            {
                MessageBox.Show("Tiene que haber al menos una vida");
            }
        }

        private void LimpiarVista()
        {
            pantallaPrincipal.Controls.Remove(palabraElegida_Label);
            pantallaPrincipal.Controls.Remove(palabraElegida_TextBox);
            pantallaPrincipal.Controls.Remove(vidas_Label);
            pantallaPrincipal.Controls.Remove(vidas_TextBox);
            pantallaPrincipal.Controls.Remove(mostrarIntentos_CheckBox);
            pantallaPrincipal.Controls.Remove(mostrarPrimerLetra_CheckBox);
            pantallaPrincipal.Controls.Remove(aceptar_Button);
        }


        #region Validaciones
        private void SoloLetrasValidador(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
        private void SoloNumerosValidador(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void VidasTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(vidas_TextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se pueden escribir números.");
                vidas_TextBox.Text = vidas_TextBox.Text.Remove(vidas_TextBox.Text.Length - 1);
            }
            else if (vidas_TextBox.Text == "0")
            {
                MessageBox.Show("Tiene que haber al menos 1 vida");
                vidas_TextBox.Text = vidas_TextBox.Text.Remove(vidas_TextBox.Text.Length - 1);
            }
        }

        #endregion


        #endregion


    }
}
