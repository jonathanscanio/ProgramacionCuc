using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoWindowsForm
{
    class InstructionsScreen
    {
        Label tituloInstruccionesLabel;
        Label mensajeInstruccionesLabel;

        public InstructionsScreen(Form1 mainScreen)
        {
            //
            // mainMenuButton
            //
            new MainMenuButton(mainScreen);

            //
            // tituloInstruccionesLabel
            //
            tituloInstruccionesLabel = new Label();
            tituloInstruccionesLabel.AutoSize = true;
            tituloInstruccionesLabel.Location = new System.Drawing.Point(250, 40);
            tituloInstruccionesLabel.Size = new System.Drawing.Size(35, 13);
            tituloInstruccionesLabel.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloInstruccionesLabel.ForeColor = System.Drawing.Color.White;
            tituloInstruccionesLabel.TabIndex = 0;
            tituloInstruccionesLabel.Text = "INSTRUCCIONES";
            mainScreen.Controls.Add(tituloInstruccionesLabel);

            //
            // mensajeInstruccionesLabel
            //
            mensajeInstruccionesLabel = new Label();
            mensajeInstruccionesLabel.Location = new System.Drawing.Point(82, 152);
            mensajeInstruccionesLabel.Size = new System.Drawing.Size(639, 272);
            mensajeInstruccionesLabel.TabIndex = 0;
            mensajeInstruccionesLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mensajeInstruccionesLabel.ForeColor = System.Drawing.Color.White;
            mensajeInstruccionesLabel.Text = "El Manifiesto Comunista es el documento revolucionario más importante y de ideas históricas más seguras que nunca se haya escrito. Siempre es necesario acudir a él como la fuente más clara de la doctrina para así conocerla incontaminada y evitar el contagio reformista. Y avalorar esta edición con el ensayo de Antonio Labriola es acompañarla del pensamiento de uno de los más hondos y sagaces expositores del marxismo.";
            mainScreen.Controls.Add(mensajeInstruccionesLabel);
        }
    }
}
