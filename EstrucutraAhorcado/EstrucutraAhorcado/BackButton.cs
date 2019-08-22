using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstrucutraAhorcado
{
    class BackButton
    {
        Button backButton;
        Form1 mainScreen;

        public BackButton(Form1 mainScreen)
        {
            this.mainScreen = mainScreen;
            backButton = new Button();
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Size = new System.Drawing.Size(74, 74);
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Text = "Volver";
            mainScreen.Controls.Add(backButton);
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
        }
        public void BackButton_Click(object sender, EventArgs e)
        {
            mainScreen.Controls.Clear();
            new MainMenuScreen(mainScreen);
        }
    }
}
