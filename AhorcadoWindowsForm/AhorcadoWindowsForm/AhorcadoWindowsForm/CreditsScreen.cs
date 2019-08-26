using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoWindowsForm
{
    class CreditsScreen
    {
        Label tituloCreditosLabel;
        Label mensajeCreditosLabel;

        public CreditsScreen(Form1 mainScreen)
        {
            //
            // mainMenuButton
            //
            new MainMenuButton(mainScreen);

            //
            // tituloCreditosLabel
            //
            tituloCreditosLabel = new Label();
            tituloCreditosLabel.AutoSize = true;
            tituloCreditosLabel.Location = new System.Drawing.Point(250, 40);
            tituloCreditosLabel.Size = new System.Drawing.Size(35, 13);
            tituloCreditosLabel.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloCreditosLabel.TabIndex = 0;
            tituloCreditosLabel.Text = "CRÉDITOS";
            mainScreen.Controls.Add(tituloCreditosLabel);

            //
            // mensajeCreditosLabel
            //
            mensajeCreditosLabel = new Label();
            mensajeCreditosLabel.Location = new System.Drawing.Point(82, 152);
            mensajeCreditosLabel.Size = new System.Drawing.Size(639, 272);
            mensajeCreditosLabel.TabIndex = 0;
            mensajeCreditosLabel.Text = "Program made by ogonzalo";
            mainScreen.Controls.Add(mensajeCreditosLabel);
        }
    }
}
