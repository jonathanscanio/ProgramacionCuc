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
        BackButton backbutton;
        Label tituloInstruccionesLabel;
        Label mensajeInstruccionesLabel;

        public InstructionsScreen(Form1 mainScreen)
        {
            //
            // backButton
            //
            backbutton = new BackButton(mainScreen);

            //
            // tituloInstruccionesLabel
            //
            this.tituloInstruccionesLabel = new Label();
            this.tituloInstruccionesLabel.AutoSize = true;
            this.tituloInstruccionesLabel.Location = new System.Drawing.Point(250, 40);
            this.tituloInstruccionesLabel.Size = new System.Drawing.Size(35, 13);
            this.tituloInstruccionesLabel.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloInstruccionesLabel.TabIndex = 0;
            this.tituloInstruccionesLabel.Text = "INSTRUCCIONES";
            mainScreen.Controls.Add(tituloInstruccionesLabel);

            //
            // mensajeInstruccionesLabel
            //
            this.mensajeInstruccionesLabel = new Label();
            this.mensajeInstruccionesLabel.Location = new System.Drawing.Point(82, 152);
            this.mensajeInstruccionesLabel.Size = new System.Drawing.Size(639, 272);
            this.mensajeInstruccionesLabel.TabIndex = 0;
            this.mensajeInstruccionesLabel.Text = "El Manifiesto Comunista es el documento revolucionario más importante y de ideas históricas más seguras que nunca se haya escrito. Siempre es necesario acudir a él como la fuente más clara de la doctrina para así conocerla incontaminada y evitar el contagio reformista. Y avalorar esta edición con el ensayo de Antonio Labriola es acompañarla del pensamiento de uno de los más hondos y sagaces expositores del marxismo.";
            mainScreen.Controls.Add(mensajeInstruccionesLabel);
        }
    }
}
