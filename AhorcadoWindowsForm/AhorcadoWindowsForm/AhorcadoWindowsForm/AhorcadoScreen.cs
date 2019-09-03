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
            vidasLabel.Location = new System.Drawing.Point(34, 127);
            vidasLabel.AutoSize = true;
            vidasLabel.TabIndex = 1;
            vidasLabel.Text = "Vidas restantes: " + ahorcadoGame.vidas;
            mainScreen.Controls.Add(vidasLabel);


            //
            // intentosErroneosLabel
            //
            if (ahorcadoGame.intentosErroneos != null)
            {
                intentosErroneosLabel = new Label();
                intentosErroneosLabel.AutoSize = true;
                intentosErroneosLabel.Location = new System.Drawing.Point(644, 141);
                intentosErroneosLabel.Size = new System.Drawing.Size(116, 13);
                intentosErroneosLabel.TabIndex = 2;
                intentosErroneosLabel.Text = "Intentos Erroneos: ";
                mainScreen.Controls.Add(intentosErroneosLabel);
            }


            //
            // guionesLabel
            //
            guionesLabel = new Label();
            guionesLabel.AutoSize = true;
            guionesLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            guionesLabel.Location = new System.Drawing.Point(188, 187);
            guionesLabel.Size = new System.Drawing.Size(371, 56);
            guionesLabel.TabIndex = 3;
            guionesLabel.Text = ahorcadoGame.sbGuiones.ToString(); //SepararGuiones(ahorcadoGame.sbGuiones.ToString())
            mainScreen.Controls.Add(guionesLabel);

            //
            // intentoLabel
            //
            intentoLabel = new Label();
            intentoLabel.AutoSize = true;
            intentoLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            intentoLabel.Location = new System.Drawing.Point(194, 316);
            intentoLabel.Size = new System.Drawing.Size(86, 24);
            intentoLabel.TabIndex = 4;
            intentoLabel.Text = "Intento: ";
            mainScreen.Controls.Add(intentoLabel);


            //
            // intentoTextBox
            //
            intentoTextBox = new TextBox();
            intentoTextBox.Location = new System.Drawing.Point(293, 310);
            intentoTextBox.MinimumSize = new System.Drawing.Size(4, 30);
            intentoTextBox.Size = new System.Drawing.Size(120, 30);
            intentoTextBox.TabIndex = 5;
            mainScreen.Controls.Add(intentoTextBox);

            //
            // aceptarIntentoButton
            //
            aceptarIntentoButton = new Button();
            aceptarIntentoButton.Location = new System.Drawing.Point(455, 308);
            aceptarIntentoButton.Size = new System.Drawing.Size(104, 32);
            aceptarIntentoButton.TabIndex = 6;
            aceptarIntentoButton.Text = "Ingresar intento";
            aceptarIntentoButton.UseVisualStyleBackColor = true;
            aceptarIntentoButton.Click += new System.EventHandler(this.AceptarIntentoButton_Click);
            mainScreen.Controls.Add(aceptarIntentoButton);


            //
            // pistaButton
            //
            if (ahorcadoGame.pista != null)
            {
                pistaButton = new Button();
                pistaButton.Location = new System.Drawing.Point(205, 372);
                pistaButton.Size = new System.Drawing.Size(75, 34);
                pistaButton.TabIndex = 7;
                pistaButton.Text = "Pista";
                pistaButton.UseVisualStyleBackColor = true;
                pistaButton.Click += new System.EventHandler(this.PistaButton_Click);
                mainScreen.Controls.Add(pistaButton);
            }

        }

        private void AceptarIntentoButton_Click(object sender, EventArgs e)
        {
            ahorcadoGame.ComprobarIntento(intentoTextBox.Text);
        }
        private void PistaButton_Click(object sender, EventArgs e)
        {
            
        }

        private void RefreshView()
        {

        }

    }
}
