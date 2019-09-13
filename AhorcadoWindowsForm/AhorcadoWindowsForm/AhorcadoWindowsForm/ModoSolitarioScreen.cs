using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoWindowsForm
{
    class ModoSolitarioScreen
    {
        Form1 mainScreen;
        Button modoAleatorioButton;
        Button modoNivelesButton;
        public ModoSolitarioScreen(Form1 mainScreen)
        {
            this.mainScreen = mainScreen;
            //
            // mainMenuButton
            //
            new MainMenuButton(mainScreen);

            //
            // modoAleatorioButton
            //
            this.modoAleatorioButton = new Button();
            this.modoAleatorioButton.Location = new System.Drawing.Point(350, 300);
            this.modoAleatorioButton.Size = new System.Drawing.Size(128, 44);
            this.modoAleatorioButton.TabIndex = 1;
            this.modoAleatorioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modoAleatorioButton.Text = "Aleatorio";
            this.modoAleatorioButton.UseVisualStyleBackColor = true;
            mainScreen.Controls.Add(modoAleatorioButton);
            this.modoAleatorioButton.Click += new System.EventHandler(this.ModoAleatorioButton_Click);

            //
            // modoNivelesButton
            //
            this.modoNivelesButton = new Button();
            this.modoNivelesButton.Location = new System.Drawing.Point(730, 300);
            this.modoNivelesButton.Size = new System.Drawing.Size(128, 44);
            this.modoNivelesButton.TabIndex = 1;
            this.modoNivelesButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modoNivelesButton.Text = "Niveles";
            this.modoNivelesButton.UseVisualStyleBackColor = true;
            mainScreen.Controls.Add(modoNivelesButton);
            this.modoNivelesButton.Click += new System.EventHandler(this.ModoNivelesButton_Click);

        }
        private void ModoAleatorioButton_Click(object sender, EventArgs e)
        {
            ClearView();

            Random rnd = new Random();
            int level = rnd.Next(20);

            string palabra = PalabrasPredefinidas.PedirPalabra(level);
            string pista = PalabrasPredefinidas.PedirPista(level);

            AhorcadoGame ahorcadoGame = new AhorcadoGame(palabra, pista);
            new AhorcadoScreen(mainScreen, ahorcadoGame);
        }
        private void ModoNivelesButton_Click(object sender, EventArgs e)
        {
            ClearView();
            new ModoNivelesScreen(mainScreen);
        }
        private void ClearView()
        {
            mainScreen.Controls.Clear();
        }
    }
}
