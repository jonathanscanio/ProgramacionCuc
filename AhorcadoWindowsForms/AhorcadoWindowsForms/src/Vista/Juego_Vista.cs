﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AhorcadoWindowsForms.src.Modelo;
using AhorcadoWindowsForms.src.Controlador;

namespace AhorcadoWindowsForms.src.Vista
{
    class Juego_Vista
    {


        #region Atributos

        Form1 pantallaPrincipal;
        Juego_Controlador controlador;
        Partida partida;

        Label vidas_Label;
        Label intentosErroneos_Label;
        Label guiones_Label;
        Label intento_Label;
        TextBox intento_TextBox;
        Button aceptarIntento_Button;
        Button pista_Button;
        Label pista_Label;
        Label resultado_Label;
        Label palabraCorrecta_Label;

        #endregion


        #region Constructor 

        public Juego_Vista(Form1 mainScreen, ParametrosPartida parametrosPartida)
        {
            this.pantallaPrincipal = mainScreen;

            controlador = new Juego_Controlador();

            //Crear Partida
            partida = new Partida();
            partida = controlador.CrearPartida(parametrosPartida);


            #region Controles

            //
            // vidasLabel
            //
            vidas_Label = new Label();
            vidas_Label.Location = new System.Drawing.Point(200, 105);
            vidas_Label.AutoSize = true;
            vidas_Label.TabIndex = 1;
            vidas_Label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vidas_Label.ForeColor = System.Drawing.Color.White;
            vidas_Label.Text = "Vidas restantes: " + partida.Vidas;
            mainScreen.Controls.Add(vidas_Label);

            //
            // intentosErroneosLabel
            //
            if (parametrosPartida.MostrarIntentos == true)
            {
                intentosErroneos_Label = new Label();
                intentosErroneos_Label.Location = new System.Drawing.Point(800, 105);
                intentosErroneos_Label.Size = new System.Drawing.Size(400, 150);
                intentosErroneos_Label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                intentosErroneos_Label.ForeColor = System.Drawing.Color.White;
                intentosErroneos_Label.Text = "Intentos Erróneos: ";
                mainScreen.Controls.Add(intentosErroneos_Label);
            }

            //
            // guionesLabel
            //
            guiones_Label = new Label();
            guiones_Label.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            guiones_Label.ForeColor = System.Drawing.Color.White;
            guiones_Label.Location = new System.Drawing.Point(300, 280);
            guiones_Label.Size = new System.Drawing.Size(600, 59);
            guiones_Label.TabIndex = 3;
            guiones_Label.Text = partida.Guiones.ToString();
            guiones_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            guiones_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            mainScreen.Controls.Add(guiones_Label);

            //
            // intentoLabel
            //
            intento_Label = new Label();
            intento_Label.AutoSize = true;
            intento_Label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            intento_Label.Location = new System.Drawing.Point(230, 500);
            intento_Label.Size = new System.Drawing.Size(86, 24);
            intento_Label.TabIndex = 4;
            intento_Label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            intento_Label.ForeColor = System.Drawing.Color.White;
            intento_Label.Text = "Intento: ";
            mainScreen.Controls.Add(intento_Label);

            //
            // intentoTextBox
            //
            intento_TextBox = new TextBox();
            intento_TextBox.Location = new System.Drawing.Point(330, 500);
            intento_TextBox.MinimumSize = new System.Drawing.Size(4, 30);
            intento_TextBox.Size = new System.Drawing.Size(120, 30);
            intento_TextBox.TabIndex = 5;
            mainScreen.Controls.Add(intento_TextBox);

            //
            // aceptarIntentoButton
            //
            aceptarIntento_Button = new Button();
            aceptarIntento_Button.Location = new System.Drawing.Point(490, 500);
            aceptarIntento_Button.Size = new System.Drawing.Size(150, 35);
            aceptarIntento_Button.TabIndex = 6;
            aceptarIntento_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aceptarIntento_Button.Text = "Ingresar intento";
            aceptarIntento_Button.UseVisualStyleBackColor = true;
            aceptarIntento_Button.Click += new System.EventHandler(AceptarIntento_Button_Click);
            mainScreen.Controls.Add(aceptarIntento_Button);
            mainScreen.AcceptButton = aceptarIntento_Button;

            //
            // pistaButton
            //
            if (partida.Pista != null)
            {
                pista_Button = new Button();
                pista_Button.Location = new System.Drawing.Point(240, 580);
                pista_Button.Size = new System.Drawing.Size(75, 34);
                pista_Button.TabIndex = 7;
                pista_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pista_Button.Text = "Pista";
                pista_Button.UseVisualStyleBackColor = true;
                pista_Button.Click += new System.EventHandler(Pista_Button_Click);
                mainScreen.Controls.Add(pista_Button);
            }

            //
            // pista_Label
            //
            pista_Label = new Label();
            pista_Label.Location = new System.Drawing.Point(330, 580);
            pista_Label.AutoSize = true;
            pista_Label.TabIndex = 1;
            pista_Label.Text = "";
            pista_Label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pista_Label.ForeColor = System.Drawing.Color.White;
            mainScreen.Controls.Add(pista_Label);

            //
            // resultado_Label
            //
            resultado_Label = new Label();
            resultado_Label.Location = new System.Drawing.Point(460, 500);
            resultado_Label.AutoSize = true;
            resultado_Label.TabIndex = 1;
            resultado_Label.Text = "";
            resultado_Label.ForeColor = System.Drawing.Color.White;
            resultado_Label.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mainScreen.Controls.Add(resultado_Label);

            //
            // palabraCorrecta_Label
            //
            palabraCorrecta_Label = new Label();
            palabraCorrecta_Label.Location = new System.Drawing.Point(380, 580);
            palabraCorrecta_Label.AutoSize = true;
            palabraCorrecta_Label.TabIndex = 1;
            palabraCorrecta_Label.Text = "";
            palabraCorrecta_Label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            palabraCorrecta_Label.ForeColor = System.Drawing.Color.White;
            mainScreen.Controls.Add(palabraCorrecta_Label);

            #endregion


        }

        #endregion


        #region Metodos

        private void Pista_Button_Click(object sender, EventArgs e)
        {
            pista_Label.Text = partida.Pista;
        }
        private void AceptarIntento_Button_Click(object sender, EventArgs e)
        {
            partida = controlador.ComprobarIntento(intento_TextBox.Text.ToUpper());
            ActualizarPantalla();
        }
        private void ActualizarPantalla()
        {
            //intentos
            if (intentosErroneos_Label != null)
            {
                if (!vidas_Label.Text.EndsWith(partida.Vidas.ToString()))
                {
                    intentosErroneos_Label.Text += partida.IntentosErroneos + ", ";
                }
            }

            //vidas
            vidas_Label.Text = "Vidas restantes: " + partida.Vidas;

            //guiones
            guiones_Label.Text = partida.Guiones.ToString();

            //intentoTextBox
            intento_TextBox.Text = "";

            //perder
            if (partida.Vidas == 0)
            {
                LimpiarControlesParaMostrarResultado();

                resultado_Label.Text = "PERDISTE :/";

                palabraCorrecta_Label.Text = "La palabra correcta era " + partida.Palabra;
            }

            //ganar
            else if (guiones_Label.Text == partida.Palabra) 
            {
                LimpiarControlesParaMostrarResultado();

                resultado_Label.Text = "GANASTE!!!";
            }
        }
        private void LimpiarControlesParaMostrarResultado()
        {
            pantallaPrincipal.Controls.Remove(intento_Label);
            pantallaPrincipal.Controls.Remove(intento_TextBox);
            pantallaPrincipal.Controls.Remove(aceptarIntento_Button);
            pantallaPrincipal.Controls.Remove(pista_Button);
            pantallaPrincipal.Controls.Remove(pista_Label);
        }

        #endregion


    }
}