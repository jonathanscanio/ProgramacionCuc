using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SistEcuaciones
{
    class Grafico
    {
        #region Controles
        Panel mainScreen;
        PictureBox picMantenimiento;
        #endregion

        #region Constructor
        public Grafico(Panel mainScreen , Size principalSize)
        {
            this.mainScreen = mainScreen;

            this.picMantenimiento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMantenimiento)).BeginInit();

            // 
            // picMantenimiento
            // 
            this.picMantenimiento.Image = global::SistEcuaciones.Properties.Resources.Background_Mantenimiento;
            this.picMantenimiento.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picMantenimiento.Location = new System.Drawing.Point(0, 0);
            this.picMantenimiento.Name = "picMantenimiento";
            this.picMantenimiento.Size = principalSize;
            this.picMantenimiento.TabIndex = 14;
            this.picMantenimiento.TabStop = false;

            ((System.ComponentModel.ISupportInitialize)(this.picMantenimiento)).EndInit();


            mainScreen.Controls.Add(this.picMantenimiento);
        }
        #endregion

        #region Métodos
        public void Borrar()
        {
            mainScreen.Controls.Remove(picMantenimiento);
        }
        #endregion
    }
}
