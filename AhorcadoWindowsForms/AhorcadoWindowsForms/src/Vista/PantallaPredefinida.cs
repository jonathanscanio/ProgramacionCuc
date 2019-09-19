using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoWindowsForms.src.Vista
{
    class PantallaPredefinida
    {


        #region Atributos

        private Form1 pantallaPrincipal;
        private Button menuPrincipal_Button;

        #endregion


        #region Constructor

        public PantallaPredefinida(Form1 pantallaPrincipal)
        {
            this.pantallaPrincipal = pantallaPrincipal;

            menuPrincipal_Button = new Button();
            menuPrincipal_Button.Location = new System.Drawing.Point(0, 0);
            menuPrincipal_Button.Size = new System.Drawing.Size(74, 74);
            menuPrincipal_Button.UseVisualStyleBackColor = true;
            menuPrincipal_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            menuPrincipal_Button.Text = "Menú";
            pantallaPrincipal.Controls.Add(menuPrincipal_Button);
            menuPrincipal_Button.Click += new System.EventHandler(this.MenuPrincipal_Button_Click);
        }

        #endregion


        #region Metodos

        public void MenuPrincipal_Button_Click(object sender, EventArgs e)
        {
            pantallaPrincipal.Controls.Clear();
            new MenuPrincipal_Vista(pantallaPrincipal);
        }

        #endregion


    }
}
