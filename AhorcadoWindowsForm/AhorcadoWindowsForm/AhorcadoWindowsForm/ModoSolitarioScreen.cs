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
            this.modoAleatorioButton.Location = new System.Drawing.Point(210, 200);
            this.modoAleatorioButton.Size = new System.Drawing.Size(128, 44);
            this.modoAleatorioButton.TabIndex = 1;
            this.modoAleatorioButton.Text = "Aleatorio";
            this.modoAleatorioButton.UseVisualStyleBackColor = true;
            mainScreen.Controls.Add(modoAleatorioButton);
            this.modoAleatorioButton.Click += new System.EventHandler(this.ModoAleatorioButton_Click);

            //
            // modoNivelesButton
            //
            this.modoNivelesButton = new Button();
            this.modoNivelesButton.Location = new System.Drawing.Point(510, 200);
            this.modoNivelesButton.Size = new System.Drawing.Size(128, 44);
            this.modoNivelesButton.TabIndex = 1;
            this.modoNivelesButton.Text = "Niveles";
            this.modoNivelesButton.UseVisualStyleBackColor = true;
            mainScreen.Controls.Add(modoNivelesButton);
            this.modoNivelesButton.Click += new System.EventHandler(this.ModoNivelesButton_Click);

        }
        private void ModoAleatorioButton_Click(object sender, EventArgs e)
        {
            ClearView();
            //level = numero aleatorio entre 1 y 20

            //string palabra = PedirPalabra(level)
            //string pista = PedirPista(level)
            //new AhorcadoScreen(palabra, 6, true, false, pista);
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
