using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistEcuaciones
{
    class Resultados
    {
        #region Controles
        Panel mainScreen;
        Label lbEcuacion1;
        Label lbSistema;
        Label lbSolucion;
        Label lbEcuacion2;
        #endregion

        #region Constructor
        public Resultados(Panel mainScreen)
        {
            this.mainScreen = mainScreen;

            this.lbEcuacion1 = new System.Windows.Forms.Label();
            this.lbEcuacion2 = new System.Windows.Forms.Label();
            this.lbSolucion = new System.Windows.Forms.Label();
            this.lbSistema = new System.Windows.Forms.Label();

            mainScreen.Controls.Add(this.lbSistema);
            mainScreen.Controls.Add(this.lbSolucion);
            mainScreen.Controls.Add(this.lbEcuacion2);
            mainScreen.Controls.Add(this.lbEcuacion1);


            // 
            // lbEcuacion1
            // 
            this.lbEcuacion1.AutoSize = true;
            this.lbEcuacion1.Font = new System.Drawing.Font("Bahnschrift Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEcuacion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(47)))), ((int)(((byte)(157)))));
            this.lbEcuacion1.Location = new System.Drawing.Point(42, 38);
            this.lbEcuacion1.Name = "lbEcuacion1";
            this.lbEcuacion1.Size = new System.Drawing.Size(351, 115);
            this.lbEcuacion1.TabIndex = 12;
            this.lbEcuacion1.Text = "ax + by = c";
            // 
            // lbEcuacion2
            // 
            this.lbEcuacion2.AutoSize = true;
            this.lbEcuacion2.Font = new System.Drawing.Font("Bahnschrift Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEcuacion2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(47)))), ((int)(((byte)(157)))));
            this.lbEcuacion2.Location = new System.Drawing.Point(42, 250);
            this.lbEcuacion2.Name = "lbEcuacion2";
            this.lbEcuacion2.Size = new System.Drawing.Size(351, 115);
            this.lbEcuacion2.TabIndex = 13;
            this.lbEcuacion2.Text = "ax + by = c";
            // 
            // lbSolucion
            // 
            this.lbSolucion.AutoSize = true;
            this.lbSolucion.Font = new System.Drawing.Font("Bahnschrift Condensed", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(121)))), ((int)(((byte)(152)))));
            this.lbSolucion.Location = new System.Drawing.Point(42, 462);
            this.lbSolucion.Name = "lbSolucion";
            this.lbSolucion.Size = new System.Drawing.Size(416, 161);
            this.lbSolucion.TabIndex = 14;
            this.lbSolucion.Text = "S= (0 ; 0)";
            // 
            // lbSistema
            // 
            this.lbSistema.AutoSize = true;
            this.lbSistema.Font = new System.Drawing.Font("Bahnschrift Condensed", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(121)))), ((int)(((byte)(152)))));
            this.lbSistema.Location = new System.Drawing.Point(42, 720);
            this.lbSistema.Name = "lbSistema";
            this.lbSistema.Size = new System.Drawing.Size(1096, 115);
            this.lbSistema.TabIndex = 15;
            this.lbSistema.Text = "Sistema Compatible Determinado";
        }

        #endregion

        #region Métodos
        public void ImprimirResultados(SistemaDeEcuaciones sistema)
        {
            lbEcuacion1.Text = sistema.e1.ecuacion;
            lbEcuacion2.Text = sistema.e2.ecuacion;
            lbSistema.Text = sistema.tiposistema;
            lbSolucion.Text = sistema.solucion;
        }

        public void Borrar()
        {
            mainScreen.Controls.Remove(lbEcuacion1);
            mainScreen.Controls.Remove(lbEcuacion2);
            mainScreen.Controls.Remove(lbSistema);
            mainScreen.Controls.Remove(lbSolucion);
        }
        #endregion
       
    }
}
