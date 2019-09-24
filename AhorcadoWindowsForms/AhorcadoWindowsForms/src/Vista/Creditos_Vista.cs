using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoWindowsForms.src.Vista
{
    class Creditos_Vista : PantallaPredefinida
    {


        #region Atributos

        Label tituloCreditos_Label;
        Label mensajeCreditos_Label;

        #endregion


        #region Constructor (Controles)

        public Creditos_Vista(Form1 pantallaPrincipal) : base(pantallaPrincipal)
        {
            //
            // tituloCreditosLabel
            //
            tituloCreditos_Label = new Label();
            tituloCreditos_Label.AutoSize = true;
            tituloCreditos_Label.Location = new System.Drawing.Point(400, 40);
            tituloCreditos_Label.Size = new System.Drawing.Size(35, 13);
            tituloCreditos_Label.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloCreditos_Label.ForeColor = System.Drawing.Color.White;
            tituloCreditos_Label.TabIndex = 0;
            tituloCreditos_Label.Text = "CRÉDITOS";
            pantallaPrincipal.Controls.Add(tituloCreditos_Label);

            //
            // mensajeCreditosLabel
            //
            mensajeCreditos_Label = new Label();
            mensajeCreditos_Label.Location = new System.Drawing.Point(150, 152);
            mensajeCreditos_Label.AutoSize = true;
            mensajeCreditos_Label.TabIndex = 0;
            mensajeCreditos_Label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mensajeCreditos_Label.ForeColor = System.Drawing.Color.White;
            mensajeCreditos_Label.Text = "Program made by ogonzalo";
            pantallaPrincipal.Controls.Add(mensajeCreditos_Label);
        }

        #endregion


    }
}
