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
            this.button.Size = new System.Drawing.Size(30, 30);
            this.button.UseVisualStyleBackColor = true;
            this.button.Text = text;
            mainScreen.Controls.Add(button);
            this.button.Click += new System.EventHandler(this.Button_Click);
        }
        public void Button_Click(object sender, EventArgs e)
        {
            ClearView();
            //string palabra = PedirPalabra(convert.tostring(boton.text))
            //string pista = PedirPista(convert.tostring(boton.text))
            //new AhorcadoScreen(palabra, 6, true, false, pista);
        }
        private void ClearView()
        {
            mainScreen.Controls.Clear();
        }
    }
}
