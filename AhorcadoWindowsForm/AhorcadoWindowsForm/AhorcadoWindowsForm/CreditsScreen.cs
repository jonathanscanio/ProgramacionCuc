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
        BackButton backbutton;
        Label tituloCreditosLabel;
        Label mensajeCreditosLabel;

        public CreditsScreen(Form1 mainScreen)
        {
            //
            // backButton
            //
            backbutton = new BackButton(mainScreen);

            //
            // tituloCreditosLabel
            //
            tituloCreditosLabel = new Label();
            this.tituloCreditosLabel.AutoSize = true;
            this.tituloCreditosLabel.Location = new System.Drawing.Point(250, 40);
            this.tituloCreditosLabel.Size = new System.Drawing.Size(35, 13);
            this.tituloCreditosLabel.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloCreditosLabel.TabIndex = 0;
            this.tituloCreditosLabel.Text = "CRÉDITOS";
            mainScreen.Controls.Add(tituloCreditosLabel);

            //
            // mensajeCreditosLabel
            //
            this.mensajeCreditosLabel = new Label();
            this.mensajeCreditosLabel.Location = new System.Drawing.Point(82, 152);
            this.mensajeCreditosLabel.Size = new System.Drawing.Size(639, 272);
            this.mensajeCreditosLabel.TabIndex = 0;
            this.mensajeCreditosLabel.Text = "Program made by ogonzalo";
            mainScreen.Controls.Add(mensajeCreditosLabel);
        }
    }
}
