using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistEcuaciones
{
    class Grafico
    {
        #region Controles
        Panel mainScreen;
        PictureBox picMantenimiento;
        #endregion

        #region Constructor
        public Grafico(Panel mainScreen)
        {
            this.mainScreen = mainScreen;

            this.picMantenimiento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMantenimiento)).BeginInit();

            // 
            // picMantenimiento
            // 
            this.picMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMantenimiento.Image = global::SistEcuaciones.Properties.Resources.Background_Mantenimiento;
            this.picMantenimiento.Location = new System.Drawing.Point(0, 0);
            this.picMantenimiento.Name = "picMantenimiento";
            this.picMantenimiento.Size = new System.Drawing.Size(1150, 800);
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
