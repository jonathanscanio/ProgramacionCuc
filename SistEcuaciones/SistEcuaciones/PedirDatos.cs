using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SistEcuaciones
{
    class PedirDatos
    {
        #region Controles
        Panel mainScreen;
        public Label lbEcuacion1;
        public Label lbEcuacion2;
        Label lbIndep;
        Label lbCoefY;
        Label lbCoefX;
        TextBox txtCoefX;
        TextBox txtIndep;
        TextBox txtCoefY;
        Size panelSize;
        public int posicionBtn;
        #endregion

        #region Constructor
        public PedirDatos(Panel mainScreen , Size principalSize)
        {
            this.mainScreen = mainScreen;
            panelSize = principalSize;

            this.txtIndep = new System.Windows.Forms.TextBox();
            this.txtCoefY = new System.Windows.Forms.TextBox();
            this.txtCoefX = new System.Windows.Forms.TextBox();
            this.lbIndep = new System.Windows.Forms.Label();
            this.lbCoefY = new System.Windows.Forms.Label();
            this.lbCoefX = new System.Windows.Forms.Label();
            this.lbEcuacion2 = new System.Windows.Forms.Label();
            this.lbEcuacion1 = new System.Windows.Forms.Label();

            // 
            // txtIndep
            // 
            this.txtIndep.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndep.Location = new System.Drawing.Point(534, 450);
            this.txtIndep.Name = "txtIndep";
            this.txtIndep.Size = new System.Drawing.Size(241, 50);
            this.txtIndep.TabIndex = 7;
            this.txtIndep.MaxLength = 4;
            this.txtIndep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtCoefY
            // 
            this.txtCoefY.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoefY.Location = new System.Drawing.Point(444, 364);
            this.txtCoefY.Name = "txtCoefY";
            this.txtCoefY.Size = new System.Drawing.Size(241, 50);
            this.txtCoefY.TabIndex = 6;
            this.txtCoefY.MaxLength = 4;
            this.txtCoefY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtCoefX
            // 
            this.txtCoefX.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoefX.Location = new System.Drawing.Point(444, 281);
            this.txtCoefX.Name = "txtCoefX";
            this.txtCoefX.Size = new System.Drawing.Size(241, 50);
            this.txtCoefX.TabIndex = 5;
            this.txtCoefX.MaxLength = 4;
            this.txtCoefX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lbIndep
            // 
            this.lbIndep.AutoSize = true;
            this.lbIndep.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndep.Location = new System.Drawing.Point(200, 450);
            this.lbIndep.Name = "lbIndep";
            this.lbIndep.Size = new System.Drawing.Size(328, 42);
            this.lbIndep.TabIndex = 4;
            this.lbIndep.Text = "Término Independiente:";

            // 
            // lbCoefY
            // 
            this.lbCoefY.AutoSize = true;
            this.lbCoefY.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoefY.Location = new System.Drawing.Point(200, 367);
            this.lbCoefY.Name = "lbCoefY";
            this.lbCoefY.Size = new System.Drawing.Size(233, 42);
            this.lbCoefY.TabIndex = 3;
            this.lbCoefY.Text = "Coeficiente de Y:";
            // 
            // lbCoefX
            // 
            this.lbCoefX.AutoSize = true;
            this.lbCoefX.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoefX.Location = new System.Drawing.Point(200, 284);
            this.lbCoefX.Name = "lbCoefX";
            this.lbCoefX.Size = new System.Drawing.Size(238, 42);
            this.lbCoefX.TabIndex = 2;
            this.lbCoefX.Text = "Coeficiente de X:";
            // 
            // lbEcuacion2
            // 
            this.lbEcuacion2.AutoSize = true;
            this.lbEcuacion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 62F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEcuacion2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(47)))), ((int)(((byte)(157)))));
            this.lbEcuacion2.Location = new System.Drawing.Point(740, 51);
            this.lbEcuacion2.Name = "lbEcuacion2";
            this.lbEcuacion2.Size = new System.Drawing.Size(351, 115);
            this.lbEcuacion2.TabIndex = 1;
            this.lbEcuacion2.Text = "ax + by = c";
            // 
            // lbEcuacion1
            // 
            this.lbEcuacion1.AutoSize = true;
            this.lbEcuacion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 62F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEcuacion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(47)))), ((int)(((byte)(157)))));
            this.lbEcuacion1.Location = new System.Drawing.Point(50, 51);
            this.lbEcuacion1.Name = "lbEcuacion1";
            this.lbEcuacion1.Size = new System.Drawing.Size(351, 115);
            this.lbEcuacion1.TabIndex = 0;
            this.lbEcuacion1.Text = "ax + by = c";

            mainScreen.Controls.Add(this.txtIndep);
            mainScreen.Controls.Add(this.txtCoefY);
            mainScreen.Controls.Add(this.txtCoefX);
            mainScreen.Controls.Add(this.lbIndep);
            mainScreen.Controls.Add(this.lbCoefY);
            mainScreen.Controls.Add(this.lbCoefX);
            mainScreen.Controls.Add(this.lbEcuacion2);
            mainScreen.Controls.Add(this.lbEcuacion1);

            ProporcionControles();
        }
        #endregion

        #region Validaciones y Guardado de Datos
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifico que los datos ingresados sean Numeros, también que solo se pueda agregar un Menos y una Coma.
            //Me falta por ver que el menos sea solo al principio y que nunca pueda empezar con coma.

            char coma = ',';
            char menos = '-';

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != coma && e.KeyChar != menos)
            {
                e.Handled = true;
            }

            if (e.KeyChar == coma && (sender as TextBox).Text.IndexOf(coma) > -1)
            {
                e.Handled = true;
            }
            if (e.KeyChar == menos && (sender as TextBox).Text.Contains(menos))
            {
                e.Handled = true;
            }
        }
        public Ecuacion GuardarValores()
        {
            Ecuacion ecuacion = new Ecuacion();
            ecuacion.coefx = double.Parse(txtCoefX.Text);
            ecuacion.coefy = double.Parse(txtCoefY.Text);
            ecuacion.coefindep = double.Parse(txtIndep.Text);
            ecuacion.ecuacion = $"{ecuacion.coefx}x + {ecuacion.coefy}y = {ecuacion.coefindep}";
            BorrarTextBox();
            return ecuacion;
        }

        public bool ValidarDatos()
        {
            double valor;
            bool validar = false;

            if (double.TryParse(txtCoefX.Text , out valor))
            {
                if (double.TryParse(txtCoefY.Text, out valor))
                {
                    if (double.TryParse(txtIndep.Text, out valor))
                    {
                        return validar = true;
                    }
                    else
                    {
                        return validar = false;
                    }
                }
                else
                {
                    return validar = false;
                }
            }
            else
            {
                return validar = false;
            }

        }
        #endregion

        #region Borrar
        public void BorrarTextBox()
        {
            this.txtCoefX.Text = "";
            this.txtCoefY.Text = "";
            this.txtIndep.Text = "";
            this.txtCoefX.Focus();
        }

        public void Borrar()
        {
            mainScreen.Controls.Remove(lbCoefX);
            mainScreen.Controls.Remove(lbCoefY);
            mainScreen.Controls.Remove(lbIndep);
            mainScreen.Controls.Remove(txtCoefX);
            mainScreen.Controls.Remove(txtCoefY);
            mainScreen.Controls.Remove(txtIndep);
        }
        public void BorrarTodo()
        {
            mainScreen.Controls.Remove(lbEcuacion1);
            mainScreen.Controls.Remove(lbEcuacion2);
            mainScreen.Controls.Remove(lbCoefX);
            mainScreen.Controls.Remove(lbCoefY);
            mainScreen.Controls.Remove(lbIndep);
            mainScreen.Controls.Remove(txtCoefX);
            mainScreen.Controls.Remove(txtCoefY);
            mainScreen.Controls.Remove(txtIndep);
        }
        #endregion

        public void ProporcionControles()
        {

            //Labels ecuacion 
            //Si la resolucion es de 800x600 o inferior, saco el espacio superior.

            if (panelSize.Height < 600)
            {
                lbEcuacion1.Location = new Point(((panelSize.Width / 2) - (lbEcuacion1.Width / 2)), 0);
                lbEcuacion2.Location = new Point(((panelSize.Width / 2) - (lbEcuacion2.Width / 2)), (lbEcuacion1.Location.Y + lbEcuacion1.Height));
            }

            else
            {
                lbEcuacion1.Location = new Point(((panelSize.Width / 2) - (lbEcuacion1.Width / 2)), lbEcuacion1.Location.Y);
                lbEcuacion2.Location = new Point(((panelSize.Width / 2) - (lbEcuacion2.Width / 2)), (lbEcuacion1.Location.Y + lbEcuacion1.Height));

            }

            int espacio = panelSize.Height / 25;


            //Correr labels
            lbCoefX.Location = new Point(((panelSize.Width / 2) - lbCoefX.Width), lbEcuacion2.Location.Y + lbEcuacion2.Height + espacio);
            lbCoefY.Location = new Point(lbCoefX.Location.X, lbCoefX.Location.Y + lbCoefX.Height + espacio);
            lbIndep.Location = new Point(lbCoefX.Location.X, lbCoefY.Location.Y + lbCoefY.Height + espacio);


            //Correr posicion textbox
            txtCoefX.Location = new Point(lbCoefX.Location.X + lbCoefX.Width , lbCoefX.Location.Y);
            txtCoefY.Location = new Point(lbCoefY.Location.X + lbCoefY.Width, lbCoefY.Location.Y);
            txtIndep.Location = new Point(lbIndep.Location.X + lbIndep.Width, lbIndep.Location.Y);

            posicionBtn = (lbIndep.Location.Y + (lbIndep.Height ));
        }

    }
}
