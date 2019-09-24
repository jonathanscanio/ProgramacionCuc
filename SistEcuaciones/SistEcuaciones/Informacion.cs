using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistEcuaciones
{
    class Informacion
    {
        #region Controles
        Panel mainScreen;
        PictureBox picInformacion;
        #endregion

        #region Constructor
        public Informacion(Panel mainScreen)
        {
            this.mainScreen = mainScreen;
            this.picInformacion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picInformacion)).BeginInit();

            mainScreen.Controls.Add(this.picInformacion);
            // 
            // picInformacion
            // 
            this.picInformacion.Image = global::SistEcuaciones.Properties.Resources.Informacion2;
            this.picInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picInformacion.Location = new System.Drawing.Point(0, 0);
            this.picInformacion.Name = "picInformacion";
            this.picInformacion.Size = new System.Drawing.Size(1150, 800);
            this.picInformacion.TabIndex = 12;
            this.picInformacion.TabStop = false;

            ((System.ComponentModel.ISupportInitialize)(this.picInformacion)).EndInit();

        }
        #endregion

        #region Métodos
        public void Borrar()
        {
            mainScreen.Controls.Remove(picInformacion);
        }

        #endregion
    }
}
