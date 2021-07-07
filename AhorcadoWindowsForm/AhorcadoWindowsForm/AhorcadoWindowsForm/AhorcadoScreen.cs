using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoWindowsForm
{
    class AhorcadoScreen
    {
        AhorcadoGame ahorcadoGame;

        Form1 mainScreen;

        //Controls
        Label vidasLabel;
        Label intentosErroneosLabel;
        Label guionesLabel;
        Label intentoLabel;
        TextBox intentoTextBox;
        Button aceptarIntentoButton;
        Button pistaButton;

        

        public AhorcadoScreen(Form1 mainScreen, AhorcadoGame ahorcadoGame)
        {
            this.mainScreen = mainScreen;
            this.ahorcadoGame = ahorcadoGame;

            //
            // mainMenuButton
            //
            new MainMenuButton(mainScreen);

            //
            // vidasLabel
            //
            vidasLabel = new Label();
            vidasLabel.Location = new System.Drawing.Point(200, 105);
            vidasLabel.AutoSize = true;
            vidasLabel.TabIndex = 1;
            vidasLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vidasLabel.ForeColor = System.Drawing.Color.White;
            vidasLabel.Text = "Vidas restantes: " + ahorcadoGame.vidas;
            mainScreen.Controls.Add(vidasLabel);


            //
            // intentosErroneosLabel
            //
            if (ahorcadoGame.intentosErroneos != null)
            {
                intentosErroneosLabel = new Label();
                intentosErroneosLabel.Location = new System.Drawing.Point(800, 105);
                intentosErroneosLabel.Size = new System.Drawing.Size(400, 150);
                intentosErroneosLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                intentosErroneosLabel.ForeColor = System.Drawing.Color.White;
                intentosErroneosLabel.Text = "Intentos Erróneos: ";
                mainScreen.Controls.Add(intentosErroneosLabel);
            }


            //
            // guionesLabel
            //
            guionesLabel = new Label();
            guionesLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            guionesLabel.ForeColor = System.Drawing.Color.White;
            guionesLabel.Location = new System.Drawing.Point(300, 280);
            guionesLabel.Size = new System.Drawing.Size(600, 59);
            guionesLabel.TabIndex = 3;
            guionesLabel.Text = ahorcadoGame.sbGuiones.ToString();
            guionesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            guionesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            mainScreen.Controls.Add(guionesLabel);

            //
            // intentoLabel
            //
            intentoLabel = new Label();
            intentoLabel.AutoSize = true;
            intentoLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            intentoLabel.Location = new System.Drawing.Point(230, 500);
            intentoLabel.Size = new System.Drawing.Size(86, 24);
            intentoLabel.TabIndex = 4;
            intentoLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            intentoLabel.ForeColor = System.Drawing.Color.White;
            intentoLabel.Text = "Intento: ";
            mainScreen.Controls.Add(intentoLabel);


            //
            // intentoTextBox
            //
            intentoTextBox = new TextBox();
            intentoTextBox.Location = new System.Drawing.Point(330, 500);
            intentoTextBox.MinimumSize = new System.Drawing.Size(4, 30);
            intentoTextBox.Size = new System.Drawing.Size(120, 30);
            intentoTextBox.TabIndex = 5;
            mainScreen.Controls.Add(intentoTextBox);

            //
            // aceptarIntentoButton
            //
            aceptarIntentoButton = new Button();
            aceptarIntentoButton.Location = new System.Drawing.Point(490, 500);
            aceptarIntentoButton.Size = new System.Drawing.Size(150, 35);
            aceptarIntentoButton.TabIndex = 6;
            aceptarIntentoButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aceptarIntentoButton.Text = "Ingresar intento";
            aceptarIntentoButton.UseVisualStyleBackColor = true;
            aceptarIntentoButton.Click += new System.EventHandler(AceptarIntentoButton_Click);
            mainScreen.Controls.Add(aceptarIntentoButton);


            //
            // pistaButton
            //
            if (ahorcadoGame.pista != null)
            {
                pistaButton = new Button();
                pistaButton.Location = new System.Drawing.Point(240, 580);
                pistaButton.Size = new System.Drawing.Size(75, 34);
                pistaButton.TabIndex = 7;
                pistaButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pistaButton.Text = "Pista";
                pistaButton.UseVisualStyleBackColor = true;
                pistaButton.Click += new System.EventHandler(PistaButton_Click);
                mainScreen.Controls.Add(pistaButton);
            }

            mainScreen.AcceptButton = aceptarIntentoButton;

        }

        private void AceptarIntentoButton_Click(object sender, EventArgs e)
        {
            ahorcadoGame.ComprobarIntento(intentoTextBox.Text.ToUpper());
            RefreshView();
        }
        private void PistaButton_Click(object sender, EventArgs e)
        {
            Label pistaLabel = new Label();
            pistaLabel.Location = new System.Drawing.Point(330, 580);
            pistaLabel.AutoSize = true;
            pistaLabel.TabIndex = 1;
            pistaLabel.Text = ahorcadoGame.pista;
            pistaLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pistaLabel.ForeColor = System.Drawing.Color.White;
            mainScreen.Controls.Add(pistaLabel);
        }

        private void RefreshView()
        {
            //vidas
            vidasLabel.Text = "Vidas restantes: " + ahorcadoGame.vidas;

            //intentos
            if (intentosErroneosLabel != null)
            {
                if (guionesLabel.Text == ahorcadoGame.sbGuiones.ToString())
                {
                    intentosErroneosLabel.Text += intentoTextBox.Text.ToUpper() + ", ";
                }
                
            }

            //guiones
            guionesLabel.Text = ahorcadoGame.sbGuiones.ToString();

            //intentoTextBox
            intentoTextBox.Text = "";

            //perder
            if (ahorcadoGame.vidas == 0)
            {
                mainScreen.Controls.Clear();
            }

            //ganar
            if (guionesLabel.Text == ahorcadoGame.palabraElegida)
            {
                mainScreen.Controls.Clear();
            }
        }

    }
}
