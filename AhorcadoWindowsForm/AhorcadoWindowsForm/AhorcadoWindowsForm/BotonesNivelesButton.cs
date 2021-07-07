using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoWindowsForm
{
    class BotonesNivelesButton
    {
        Button button;
        Form1 mainScreen;
        int nivel;

        public BotonesNivelesButton(Form1 mainScreen, string text, int x, int y)
        {
            this.mainScreen = mainScreen;
            this.nivel = int.Parse(text);

            button = new Button();

            this.button.Location = new System.Drawing.Point(x, y);
            this.button.Size = new System.Drawing.Size(40, 40);
            this.button.UseVisualStyleBackColor = true;
            this.button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Text = text;
            mainScreen.Controls.Add(button);
            this.button.Click += new System.EventHandler(this.Button_Click);
        }
        public void Button_Click(object sender, EventArgs e)
        {
            ClearView();

            string palabra = PalabrasPredefinidas.PedirPalabra(Convert.ToInt32(button.Text) - 1);
            string pista = PalabrasPredefinidas.PedirPista(Convert.ToInt32(button.Text) - 1);

            AhorcadoGame ahorcadoGame = new AhorcadoGame(palabra, pista);
            new AhorcadoScreen(mainScreen, ahorcadoGame);
        }
        private void ClearView()
        {
            mainScreen.Controls.Clear();
        }
    }
}
