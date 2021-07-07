using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoWindowsForm
{
    class MainMenuButton
    {
        Button mainMenuButton;
        Form1 mainScreen;

        public MainMenuButton(Form1 mainScreen)
        {
            this.mainScreen = mainScreen;

            mainMenuButton = new Button();
            this.mainMenuButton.Location = new System.Drawing.Point(0, 0);
            this.mainMenuButton.Size = new System.Drawing.Size(74, 74);
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Text = "Menú";
            mainScreen.Controls.Add(mainMenuButton);
            this.mainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
        }
        public void MainMenuButton_Click(object sender, EventArgs e)
        {
            mainScreen.Controls.Clear();
            new MainMenuScreen(mainScreen);
        }
    }
}
