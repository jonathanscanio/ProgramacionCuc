using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;


namespace SistEcuaciones
{
    public partial class Form1 : Form
    {

        PedirDatos screenDatos;
        Resultados screenResultados;
        Informacion screenInformacion;
        Procedimiento screenProcedimientos;
        Grafico screenGrafico;
        Ecuacion e1;
        Ecuacion e2;
        SistemaDeEcuaciones sistema;

        public Form1()
        {
            InitializeComponent();

            #region Inicializar
            //Inicializo todas las pantallas en un panel oculto, para luego si necesito borrar las pantallas poder hacerlo.
            screenDatos = new PedirDatos(pnIniciador);
            screenResultados = new Resultados(pnIniciador);
            screenInformacion = new Informacion(pnIniciador);
            screenProcedimientos = new Procedimiento(pnIniciador);
            screenGrafico = new Grafico(pnIniciador);

            #endregion

            pnMenu.Visible = false;
            pnMenuTop.Visible = false;
            pnPrincipal.Visible = false;
            pnPantallaInicial.Visible = true; 

        }

        #region Botones Menu Top
        private void btnSalirTop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Botones Menu Inferior
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Muestra un Mensaje de Advertencia
            DialogResult opcion = MessageBox.Show("¿Esta seguro que desea crear un Sistema de Ecuaciones nuevo?","ADVERTENCIA!!!", MessageBoxButtons.YesNo);
            //Si la opción es si
            if (opcion == DialogResult.Yes)
            {
                BorrarPantallas(); //Borra todas las pantallas
                AcomodarBotones(); //Acomoda los botones
                sistema.ResetearValores(); //Resetea los valores de Sistema
                pnMenuTop.Visible = true; //Muestra el Menú de Arriba
                pnMenu.Visible = false; //Oculta el Menú de la izquierda
                screenDatos = new PedirDatos(pnPrincipal); //Muestra la pantalla de pedir datos
                btnGuardarEcuacion1.Visible = true; //Muestra el boton de guardar ecuación
            }
            else
            {

            }
            
            
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            //Abre una página en el navegador con el Formulario de Sugerencias
            Process.Start("https://forms.gle/PYXVVASqoz6irp8F9");
        }
        #endregion

        #region Botones Menu
        private void btnResultados_Click(object sender, EventArgs e)
        {
            BorrarPantallas();
            ResetColorBtn();
            btnResultados.BackColor = Color.DarkCyan;
            btnGuardarFoto.Visible = true;
            screenResultados = new Resultados(pnPrincipal);
            screenResultados.ImprimirResultados(sistema);

        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            BorrarPantallas();
            ResetColorBtn();
            btnGuardarFoto.Visible = true;
            btnGrafico.BackColor = Color.DarkCyan;
            screenGrafico = new Grafico(pnPrincipal);
        }

        private void btnProcedimiento_Click(object sender, EventArgs e)
        {
            BorrarPantallas();
            ResetColorBtn();
            btnProcedimiento.BackColor = Color.DarkCyan;
            btnGuardarFoto.Visible = true;
            screenProcedimientos = new Procedimiento(pnPrincipal);
            screenProcedimientos.Imprimir(sistema);
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            BorrarPantallas();
            ResetColorBtn();
            btnGuardarFoto.Visible = false;
            btnInformacion.BackColor = Color.DarkCyan;
            screenInformacion = new Informacion(pnPrincipal);
        }

        private void ResetColorBtn()
        {
            //La funcion de este método es poner el Background Color de los botones en transparante
            btnResultados.BackColor = Color.Transparent;
            btnProcedimiento.BackColor = Color.Transparent;
            btnGrafico.BackColor = Color.Transparent;
            btnInformacion.BackColor = Color.Transparent;
        }

        private void ReacomodarBotones()
        {
            /* Reacomoda los botones un espacio hacia abajo y muestra el botón de Procedimiento. 
            
            Esto esta hecho así porque en caso de que el sistema sea "S.Incompatible" o "S.Compatible Determinado", no tiene sentido mostrar el procedimiento 

             */

            btnProcedimiento.Visible = true;
            this.btnGuardarFoto.Location = new System.Drawing.Point(0, 541);
            this.btnInformacion.Location = new System.Drawing.Point(0, 450);
            this.btnGrafico.Location = new System.Drawing.Point(0, 362);

        }
        private void AcomodarBotones()
        {
            //Reacomoda los botones hacia arriba y oculta el botón de procedimiento

            btnProcedimiento.Visible = false;
            this.btnGuardarFoto.Location = new System.Drawing.Point(0, 450);
            this.btnInformacion.Location = new System.Drawing.Point(0, 362);
            this.btnGrafico.Location = new System.Drawing.Point(0, 279);
        }

        private void btnGuardarFoto_Click(object sender, EventArgs e)
        {

            //Captura de pantalla
            Bitmap imgb = new Bitmap(pnPrincipal.Width, pnPrincipal.Height, PixelFormat.Format32bppArgb);
            Graphics grph = Graphics.FromImage(imgb);
            grph.CopyFromScreen((pnPrincipal.Location.X + 260), (pnPrincipal.Location.Y + 70), 0, 0, pnPrincipal.Size);
            picCaptura.Image = imgb;
            SaveFileDialog dg = new SaveFileDialog();
            dg.Filter = "Imagen Png| .png";
            dg.FileName = "Sistema .png";
            if (dg.ShowDialog() == DialogResult.OK)
            {
                ImageFormat formato = ImageFormat.Png;
                picCaptura.Image.Save(dg.FileName, formato);
            }

        }

        #endregion

        #region Botones Pedir Datos
        private void btnGuardarEcuacion1_Click(object sender, EventArgs e)
        {
            if (screenDatos.ValidarDatos())
            {
                e1 = screenDatos.GuardarValores();
                screenDatos.lbEcuacion1.Text = e1.ecuacion;
                screenDatos.BorrarTextBox();
                btnGuardarEcuacion1.Visible = false;
                btnGuardarEcuacion2.Visible = true;
            }
            else
            {
                MessageBox.Show("Las Ecuaciones se han guardado incorrectamente" , "Error");
                screenDatos.BorrarTextBox();
            }
        }

        private void btnGuardarEcuacion2_Click(object sender, EventArgs e)
        {
            if (screenDatos.ValidarDatos())
            {
                e2 = screenDatos.GuardarValores();
                screenDatos.lbEcuacion2.Text = e2.ecuacion;
                screenDatos.BorrarTextBox();
                btnGuardarEcuacion2.Visible = false;
                screenDatos.Borrar();
                btnResolver.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Error", "Las Ecuaciones se han guardado incorrectamente");
                screenDatos.BorrarTextBox();
            }
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            pnMenuTop.Visible = false;
            pnMenu.Visible = true;
            btnResolver.Visible = false;
            btnGuardarFoto.Visible = true;
            ResetColorBtn();
            btnResultados.BackColor = Color.DarkCyan;
            screenDatos.BorrarTodo();
            sistema = new SistemaDeEcuaciones(e1,e2);
            sistema.EjecutarDeterminante();
            if (sistema.tiposistema == "Sistema Compatible Determinado") //Si el sistema es "SCD", mostrará el botón de procedimiento
            {
                ReacomodarBotones();
            }
            screenResultados = new Resultados(pnPrincipal);
            screenResultados.ImprimirResultados(sistema);
        }

        #endregion

        #region Botones Pantalla Inicial

        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnInstrucciones_Click(object sender, EventArgs e)
        {
            pnInformacion.Visible = true;
            pnPantallaInicial.Visible = false;       
        }
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            pnMenu.Visible = false; //Oculta el Menú de la izquierda
            pnMenuTop.Visible = true; //Muestra el Menú Top
            pnPantallaInicial.Visible = false;
            pnInformacion.Visible = false;
            pnPrincipal.Visible = true;
            screenDatos = new PedirDatos(pnPrincipal);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            pnInformacion.Visible = false;
            pnPantallaInicial.Visible = true;
        }




        #endregion
        private void BorrarPantallas()
        {
            /*Borra todas las pantallas, porque como tengo varios apartados, no se en cual está posicionado el usuario, por lo tanto borro todas y luego
            escribo los controles de nuevo. */

            screenDatos.BorrarTodo();
            screenResultados.Borrar();
            screenInformacion.Borrar();
            screenProcedimientos.Borrar();
            screenGrafico.Borrar();
        }

       
    }
}
