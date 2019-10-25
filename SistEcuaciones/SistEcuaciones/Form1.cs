﻿using System;
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
        Size datosSize;

        public Form1()
        {
            InitializeComponent();

            screenSize = Screen.PrimaryScreen.WorkingArea.Size;

            #region Inicializar
            //Inicializo todas las pantallas en un panel oculto, para luego si necesito borrar las pantallas poder hacerlo.
            screenDatos = new PedirDatos(pnIniciador , datosSize);
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
                sistema.ResetearValores(); //Resetea los valores de Sistema
                pnMenuTop.Visible = true; //Muestra el Menú de Arriba
                pnMenu.Visible = false; //Oculta el Menú de la izquierda
                screenDatos = new PedirDatos(pnPrincipal , datosSize); //Muestra la pantalla de pedir datos
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
            ColorBtn(btnResultados); //Resetea los colores a transparente y pone de Color Cyan el seleccionado
            MostrarBotones(); //Muestra los botones Amarillos
            screenResultados = new Resultados(pnPrincipal , principalSize);
            screenResultados.ImprimirResultados(sistema);

        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            BorrarPantallas();
            ColorBtn(btnGrafico);
            MostrarBotones(); //Muestra los botones Amarillos
            screenGrafico = new Grafico(pnPrincipal);
        }

        private void btnProcedimiento_Click(object sender, EventArgs e)
        {
            BorrarPantallas();
            ColorBtn(btnProcedimiento); 
            btnProcedimiento.BackColor = Color.DarkCyan;
            screenProcedimientos = new Procedimiento(pnPrincipal,principalSize);
            screenProcedimientos.Imprimir(sistema);
            MostrarBotones(); //Muestra los botones Amarillos
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            //Borra todas las pantallas
            BorrarPantallas();

            //Pone en transparante todos los botones, excepto el clickeado
            ColorBtn(btnInformacion);

            OcultarBotones();

            screenInformacion = new Informacion(pnPrincipal);
        }

        private void ColorBtn(Button btnSeleccionado)
        {
            //La funcion de este método es poner el Background Color de los botones en transparante
            btnResultados.BackColor = Color.Transparent;
            btnProcedimiento.BackColor = Color.Transparent;
            btnGrafico.BackColor = Color.Transparent;
            btnInformacion.BackColor = Color.Transparent;

            btnSeleccionado.BackColor = Color.DarkCyan;
        }

        private void OcultarBotones()
        {
            btnGuardarFoto.Visible = false;
            btnCopiarSistema.Visible = false;
            btnImprimir.Visible = false;
        }

        private void MostrarBotones()
        {
            btnGuardarFoto.Visible = true;
            btnCopiarSistema.Visible = true;
            btnImprimir.Visible = true;
        }

        private void btnGuardarFoto_Click(object sender, EventArgs e)
        {

            //Captura de pantalla
            Bitmap imgb = new Bitmap(pnPrincipal.Width, pnPrincipal.Height, PixelFormat.Format32bppArgb);
            Graphics grph = Graphics.FromImage(imgb);
                    
            grph.CopyFromScreen(pnMenu.Width,pnPrincipal.Location.Y,0,0,principalSize);

            picCaptura.Image = imgb;
            SaveFileDialog dg = new SaveFileDialog();
            dg.Filter = "Imagen Png| .png";
            dg.FileName = "Sistema Ecuaciones.png";
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
            string resultados = $"{sistema.e1.ecuacion} || {sistema.e2.ecuacion} || {sistema.solucion} || {sistema.tiposistema}";
            
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
            ColorBtn(btnResultados);
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
            screenDatos = new PedirDatos(pnPrincipal , datosSize);
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
            principalSize = new Size((screenSize.Width - pnMenu.Width), screenSize.Height);

            datosSize = new Size(screenSize.Width, (screenSize.Height - pnMenuTop.Height));

            #region Pedir Datos

            int posicionBoton = (btnGuardarEcuacion1.Location.X + btnGuardarEcuacion1.Width);

            if (posicionBoton > datosSize.Width)
            {
                btnGuardarEcuacion1.Location = new Point(((datosSize.Width / 2) - (btnGuardarEcuacion1.Width / 2))  ,(datosSize.Height - btnGuardarEcuacion1.Height - 3));
                btnGuardarEcuacion2.Location = new Point(btnGuardarEcuacion1.Location.X , btnGuardarEcuacion1.Location.Y);
            }

            //Posicionará el boton resolver en el centro de la pantalla, y abajo del label de ecuacion2
            btnResolver.Location = new Point(((datosSize.Width / 2) - (btnResolver.Width / 2)) , (screenDatos.lbEcuacion2.Location.Y + screenDatos.lbEcuacion2.Height + 20) );

            #endregion 



        }

    }
}
