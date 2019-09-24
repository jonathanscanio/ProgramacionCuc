using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoWindowsForms.src.Vista
{
    class Instrucciones_Vista : PantallaPredefinida
    {


        #region Atributos

        Label tituloInstrucciones_Label;
        Label mensajeInstrucciones_Label;

        #endregion


        #region Constructor (Controles)
        public Instrucciones_Vista(Form1 pantallaPrincipal) : base(pantallaPrincipal)
        {
            //
            // tituloInstruccionesLabel
            //
            tituloInstrucciones_Label = new Label();
            tituloInstrucciones_Label.AutoSize = true;
            tituloInstrucciones_Label.Location = new System.Drawing.Point(400, 40);
            tituloInstrucciones_Label.Size = new System.Drawing.Size(35, 13);
            tituloInstrucciones_Label.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloInstrucciones_Label.ForeColor = System.Drawing.Color.White;
            tituloInstrucciones_Label.TabIndex = 0;
            tituloInstrucciones_Label.Text = "INSTRUCCIONES";
            pantallaPrincipal.Controls.Add(tituloInstrucciones_Label);

            //
            // mensajeInstruccionesLabel
            //
            mensajeInstrucciones_Label = new Label();
            mensajeInstrucciones_Label.Location = new System.Drawing.Point(150, 152);
            mensajeInstrucciones_Label.Size = new System.Drawing.Size(639, 272);
            mensajeInstrucciones_Label.TabIndex = 0;
            mensajeInstrucciones_Label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mensajeInstrucciones_Label.ForeColor = System.Drawing.Color.White;
            mensajeInstrucciones_Label.Text = "Escribir Instrucciones";
            pantallaPrincipal.Controls.Add(mensajeInstrucciones_Label);
        }

        #endregion


    }
}
