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
using System.Drawing.Printing;


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
        Size screenSize;
        Size principalSize;

        public Form1()
        {
            InitializeComponent();

            screenSize = Screen.PrimaryScreen.WorkingArea.Size;

            #region Inicializar
            //Inicializo todas las pantallas en un panel oculto, para luego si necesito borrar las pantallas poder hacerlo.
            screenDatos = new PedirDatos(pnIniciador , principalSize);
            screenResultados = new Resultados(pnIniciador, principalSize);
            screenInformacion = new Informacion(pnIniciador);
            screenProcedimientos = new Procedimiento(pnIniciador, principalSize);
            screenGrafico = new Grafico(pnIniciador);

            #endregion

            pnMenu.Visible = false;
            pnMenuTop.Visible = false;
            pnPrincipal.Visible = false;
            pnPantallaInicial.Visible = true;

            ProporcionControles();
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
                screenDatos = new PedirDatos(pnPrincipal , principalSize); //Muestra la pantalla de pedir datos
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
            screenResultados = new Resultados(pnPrincipal , principalSize);
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
            screenProcedimientos = new Procedimiento(pnPrincipal,principalSize);
            screenProcedimientos.Imprimir(sistema);
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            //Borra todas las pantallas
            BorrarPantallas();

            //Pone en transparante todos los botones, excepto el clickeado
            ResetColorBtn();
            btnInformacion.BackColor = Color.DarkCyan;
            
            btnGuardarFoto.Visible = false;
            btnCopiarSistema.Visible = false;
            btnImprimir.Visible = false;

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
            this.btnGrafico.Location = new System.Drawing.Point(0, 362);
            this.btnInformacion.Location = new System.Drawing.Point(0, 450);
            this.btnGuardarFoto.Location = new System.Drawing.Point(0, 541);
            this.btnCopiarSistema.Location = new Point(0, 632);
            this.btnImprimir.Location = new Point(0, 723);

        }
        private void AcomodarBotones()
        {
            //Reacomoda los botones hacia arriba y oculta el botón de procedimiento

            btnProcedimiento.Visible = false;
            this.btnGrafico.Location = new System.Drawing.Point(0, 279);
            this.btnInformacion.Location = new System.Drawing.Point(0, 362);
            this.btnGuardarFoto.Location = new System.Drawing.Point(0, 450);
            this.btnCopiarSistema.Location = new Point(0, 541);
            this.btnImprimir.Location = new Point(0, 632);
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Con este botón podremos imprimir nuestros resultados del sistema.
            PrintDocument printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += ImprimirDocumento;
            printDocument1.Print();

        }

        private void btnCopiarSistema_Click(object sender, EventArgs e)
        {
            //Seteamos lo que copiaremos al portapapeles
            string resultados = $"{sistema.e1.ecuacion}\n{sistema.e2.ecuacion}\n{sistema.solucion}\n{sistema.tiposistema}";
            
            //Borramos todo lo que haya en el portapeles
            Clipboard.Clear(); 

            //Le asignamos Resultados al portapapeles
            Clipboard.SetData(DataFormats.Text,(object)resultados);

            MessageBox.Show("Se han copiado los resultados correctamente","",MessageBoxButtons.OK);

        }


        #endregion

        #region Botones Pedir Datos
        private void btnGuardarEcuacion1_Click(object sender, EventArgs e)
        {
            if (screenDatos.ValidarDatos())
            {
                e1 = screenDatos.GuardarValores();
                screenDatos.lbEcuacion1.Text = e1.ecuacion;
                screenDatos.ProporcionControles();
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
                screenDatos.ProporcionControles();
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
            /*if (sistema.tiposistema == "Sistema Compatible Determinado") //Si el sistema es "SCD", mostrará el botón de procedimiento
            {
                ReacomodarBotones();
            }*/
            screenResultados = new Resultados(pnPrincipal , principalSize);
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
            screenDatos = new PedirDatos(pnPrincipal , principalSize);
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

        private void ImprimirDocumento(object sender, PrintPageEventArgs e)
        {
            //Con este método le doy el formato a lo que voy a imprimir.

            Font fontTitles = new Font("Arial", 20, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            Font font = new Font("Arial", 16);
            Font fontSubTitles = new Font("Arial" , 8);

            e.Graphics.DrawString("******************************", font, Brushes.Black, new Rectangle(0, 20, 1000, 30));
            e.Graphics.DrawString("SISTEMA DE ECUACIONES LINEALES", fontTitles, Brushes.Black, new Rectangle(0,55,1000,30));
            e.Graphics.DrawString(sistema.e1.ecuacion, font, Brushes.Black, new Rectangle(0, 90, 1000, 30));
            e.Graphics.DrawString(sistema.e2.ecuacion, font, Brushes.Black, new Rectangle(0, 120, 1000, 30));
            e.Graphics.DrawString(sistema.solucion, font, Brushes.Black, new Rectangle(0, 160, 1000, 30));
            e.Graphics.DrawString(sistema.tiposistema, font, Brushes.Black, new Rectangle(0, 200, 1000, 30));
            e.Graphics.DrawString("******************************", font, Brushes.Black, new Rectangle(0, 230, 1000, 30));
            e.Graphics.DrawString("Muchas Gracias por utilizarlo", fontSubTitles, Brushes.Black, new Rectangle(20, 265, 1000, 30));

        }

        private void ProporcionControles()
        {
            int width;
            int height;

            //El tamaño del programa será igual a la resolución de pantalla de la computadora del usuario
            this.Size = screenSize;
            this.CenterToScreen();

            #region Pantalla Inicial
            //La pantalla inicial ocupará el 100% de la pantalla.
            pnPantallaInicial.Size = screenSize;

            width = (screenSize.Width / 2);
            height = (width / 3);
            picLogoInicial.Size = new Size(width,height);
            picLogoInicial.Location = new Point(((screenSize.Width / 2) - (picLogoInicial.Width / 2)) , ((screenSize.Height / 2) - picLogoInicial.Height));

            btnCerrarPrograma.Location = new Point((screenSize.Width - 70),10);
            
            //El ancho de los botones sera el 20% de la pantalla
            width = screenSize.Width / 5;
            height = width / 2;
            btnComenzar.Size = new Size(width,height);
            btnInstrucciones.Size = new Size(width,height);
            btnComenzar.Location = new Point((screenSize.Width / 2 - btnComenzar.Width - (screenSize.Width / 50)) , (screenSize.Height / 2));
            btnInstrucciones.Location = new Point(((screenSize.Width / 2) + (screenSize.Width / 50)), (screenSize.Height / 2));
            #endregion


            #region Menú Top
            //El menú top ocupará el 10% de la pantalla.

            height = (screenSize.Height / 10);
            pnMenuTop.Size = new Size(screenSize.Width,height);
            //El boton se posicionará en la mitad del panel, y 50px menos de la derecha del programa.
            btnSalirTop.Location = new Point((pnMenuTop.Width - 50),((pnMenuTop.Height / 2) - (btnSalirTop.Height / 2)));
            btnMinimizar.Location = new Point((btnSalirTop.Location.X - 50),btnSalirTop.Location.Y);

            //El logo ocupara el 15% del pnMenuTop
            width = (pnMenuTop.Width / 5);
            pictureBox1.Size = new Size(width,pnMenuTop.Height);
            #endregion


            #region Menú
            //El menú Izq, ocupará el 20% de la pantalla.
            width = (screenSize.Width / 5);

            pnMenu.Size = new Size(width,screenSize.Height);

            Logo.Size = new Size(pnMenu.Width,(pnMenu.Width / 3));
            btnResultados.Size = new Size(pnMenu.Width,btnResultados.Height);
            btnGrafico.Size = new Size(pnMenu.Width, btnResultados.Height);
            btnProcedimiento.Size = new Size(pnMenu.Width, btnResultados.Height);
            btnInformacion.Size = new Size(pnMenu.Width, btnResultados.Height);
            btnGuardarFoto.Size = new Size(pnMenu.Width, btnResultados.Height);
            btnCopiarSistema.Size = new Size(pnMenu.Width, btnResultados.Height);
            btnImprimir.Size = new Size(pnMenu.Width, btnResultados.Height);

            //El espacio entre botones será del 2% del alto de la pantalla
            int espacio = (screenSize.Height / 10);
            btnResultados.Location = new Point(0,(screenSize.Height /5));
            btnProcedimiento.Location = new Point(0, (btnResultados.Location.Y + espacio));
            btnGrafico.Location = new Point(0, (btnProcedimiento.Location.Y + espacio));
            btnInformacion.Location = new Point(0, (btnGrafico.Location.Y + espacio));
            btnGuardarFoto.Location = new Point(0, (btnInformacion.Location.Y + espacio));
            btnCopiarSistema.Location = new Point(0, (btnGuardarFoto.Location.Y + espacio));
            btnImprimir.Location = new Point(0, (btnCopiarSistema.Location.Y + espacio));

            btnSalir.Location = new Point((pnMenu.Width - 40),(screenSize.Height - 40));
            btnBorrar.Location = new Point((btnSalir.Location.X - 60),(btnSalir.Location.Y));
            btnMensaje.Location = new Point((btnBorrar.Location.X - 60),(btnSalir.Location.Y));

            #endregion


            //El pnPrincipal ocupará siempre el máximo permitido de la pantalla.
            principalSize = new Size((screenSize.Width - pnMenu.Width),screenSize.Height);

        }

    }
}
