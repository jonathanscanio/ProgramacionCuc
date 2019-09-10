using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoWindowsForm
{
    class MainMenuScreen
    {
        Form1 mainScreen;
        Label nombreJuegoLabel;
        Button modoSolitarioButton;
        Button modoTradicionalButton;
        Button modoMultijugadorButton;
        Button instructionsButton;
        Button creditsButton;

        public MainMenuScreen(Form1 mainScreen)
        {
            this.mainScreen = mainScreen;

            //
            // nombreJuegoLabel
            //
            this.nombreJuegoLabel = new Label();
            this.nombreJuegoLabel.AutoSize = true;
            this.nombreJuegoLabel.Location = new System.Drawing.Point(300, 120);
            this.nombreJuegoLabel.Size = new System.Drawing.Size(35, 13);
            this.nombreJuegoLabel.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreJuegoLabel.ForeColor = System.Drawing.Color.White;
            this.nombreJuegoLabel.TabIndex = 0;
            this.nombreJuegoLabel.Text = "AHORCADO";
            mainScreen.Controls.Add(nombreJuegoLabel);

            //
            // modoSolitarioButton
            //
            this.modoSolitarioButton = new Button();
            this.modoSolitarioButton.Location = new System.Drawing.Point(110, 232);
            this.modoSolitarioButton.Size = new System.Drawing.Size(128, 44);
            this.modoSolitarioButton.TabIndex = 1;
            this.modoSolitarioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modoSolitarioButton.Text = "Solitario";
            this.modoSolitarioButton.UseVisualStyleBackColor = true;
            mainScreen.Controls.Add(modoSolitarioButton);
            this.modoSolitarioButton.Click += new System.EventHandler(this.ModoSolitarioButton_Click);

            //
            // modoTradicionalButton
            //
            this.modoTradicionalButton = new Button();
            this.modoTradicionalButton.Location = new System.Drawing.Point(355, 232);
            this.modoTradicionalButton.Size = new System.Drawing.Size(128, 44);
            this.modoTradicionalButton.TabIndex = 1;
            this.modoTradicionalButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modoTradicionalButton.Text = "Tradicional";
            this.modoTradicionalButton.UseVisualStyleBackColor = true;
            mainScreen.Controls.Add(modoTradicionalButton);
            this.modoTradicionalButton.Click += new System.EventHandler(this.ModoTradicionalButton_Click);

            //
            // modoMultijugadorButton
            //
            this.modoMultijugadorButton = new Button();
            this.modoMultijugadorButton.Location = new System.Drawing.Point(604, 232);
            this.modoMultijugadorButton.Size = new System.Drawing.Size(128, 44);
            this.modoMultijugadorButton.TabIndex = 1;
            this.modoMultijugadorButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modoMultijugadorButton.Text = "Multijugador";
            this.modoMultijugadorButton.UseVisualStyleBackColor = true;
            mainScreen.Controls.Add(modoMultijugadorButton);
            this.modoMultijugadorButton.Click += new System.EventHandler(this.ModoMultijugadorButton_Click);

            //
            // instruccionesButton
            //
            this.instructionsButton = new Button();
            this.instructionsButton.Location = new System.Drawing.Point(543, 405); //posicion
            this.instructionsButton.Size = new System.Drawing.Size(120, 30); //tamaño
            this.instructionsButton.TabIndex = 1;
            this.instructionsButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsButton.Text = "Instrucciones"; //texto dentro
            this.instructionsButton.UseVisualStyleBackColor = true;
            mainScreen.Controls.Add(instructionsButton); // agregar a pantalla
            this.instructionsButton.Click += new System.EventHandler(this.InstructionsButton_Click);

            //
            // creditsButton
            //
            this.creditsButton = new Button();
            this.creditsButton.Location = new System.Drawing.Point(681, 405);
            this.creditsButton.Size = new System.Drawing.Size(100, 30);
            this.creditsButton.TabIndex = 1;
            this.creditsButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsButton.Text = "Créditos";
            this.creditsButton.UseVisualStyleBackColor = true;
            mainScreen.Controls.Add(creditsButton);
            this.creditsButton.Click += new System.EventHandler(this.CreditsButton_Click);


        }

        private void ModoSolitarioButton_Click(object sender, EventArgs e)
        {
            ClearView();
            new ModoSolitarioScreen(mainScreen);
        }
        private void ModoTradicionalButton_Click(object sender, EventArgs e)
        {
            ClearView();
            new ModoTradicionalScreen(mainScreen);
        }
        private void ModoMultijugadorButton_Click(object sender, EventArgs e)
        {
            ClearView();
        }
        private void InstructionsButton_Click(object sender, EventArgs e)
        {
            ClearView();
            new InstructionsScreen(mainScreen);
        }
        private void CreditsButton_Click(object sender, EventArgs e)
        {
            ClearView();
            new CreditsScreen(mainScreen);
        }

        private void ClearView()
        {
            mainScreen.Controls.Remove(nombreJuegoLabel);
            mainScreen.Controls.Remove(modoSolitarioButton);
            mainScreen.Controls.Remove(modoTradicionalButton);
            mainScreen.Controls.Remove(modoMultijugadorButton);
            mainScreen.Controls.Remove(instructionsButton);
            mainScreen.Controls.Remove(creditsButton);
        }

    }
}
