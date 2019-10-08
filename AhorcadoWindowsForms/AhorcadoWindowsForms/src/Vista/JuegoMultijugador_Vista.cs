using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AhorcadoWindowsForms.src.Modelo;
using AhorcadoWindowsForms.src.Controlador;

namespace AhorcadoWindowsForms.src.Vista
{
    class JuegoMultijugador_Vista
    {
        #region Atributos

        Form1 pantallaPrincipal;
        JuegoMultijugador_Controlador controlador;
        IndiceMultijugador indice;

        List<PartidaMultijugador> partidasMultijugador;
        List<Panel> paneles;
        

        #endregion

        #region Constructor

        public JuegoMultijugador_Vista(Form1 pantallaPrincipal, List<ParametrosPartidaMultijugador> parametrosPartidaMultijugador)
        {
            this.pantallaPrincipal = pantallaPrincipal;
            controlador = new JuegoMultijugador_Controlador();
            indice = new IndiceMultijugador(parametrosPartidaMultijugador.Count);
            indice.Indice = 1;

            partidasMultijugador = new List<PartidaMultijugador>();
            paneles = new List<Panel>();

            foreach (ParametrosPartidaMultijugador parametros in parametrosPartidaMultijugador)
            {
                PartidaMultijugador partida = new PartidaMultijugador();
                partida = controlador.CrearPartidaMultijugador(parametros);
                partidasMultijugador.Add(partida);

                Panel panel = new Panel();
                panel = CrearPanel(partida);
                paneles.Add(panel);
            }

            BloquearPanelesIniciales();


        }

        #endregion

        #region Metodos
        private Panel CrearPanel(PartidaMultijugador partida)
        {
            //
            // Panel
            //
            Panel panel = new Panel();

            switch (partidasMultijugador.Count)
            {
                case 1:
                    panel.Location = new System.Drawing.Point(12, 111);
                    break;
                case 2:
                    panel.Location = new System.Drawing.Point(610, 111);
                    break;
                case 3:
                    panel.Location = new System.Drawing.Point(12, 389);
                    break;
                case 4:
                    panel.Location = new System.Drawing.Point(610, 389);
                    break;
            }
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Size = new System.Drawing.Size(578, 261);

            #region Controles

            //
            // nombre del jugador
            // 
            Label nombreJugador_Label = new Label();

            nombreJugador_Label.Location = new System.Drawing.Point(17, 14);
            nombreJugador_Label.Size = new System.Drawing.Size(116, 46);
            nombreJugador_Label.BackColor = System.Drawing.Color.White;
            nombreJugador_Label.Text = partida.NombreJugador.ToString();
            nombreJugador_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            nombreJugador_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            nombreJugador_Label.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreJugador_Label.TabIndex = 0;

            //
            // guiones
            //
            Label guiones_Label = new Label();

            guiones_Label.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            guiones_Label.ForeColor = System.Drawing.Color.White;
            guiones_Label.Location = new System.Drawing.Point(0, 105);
            guiones_Label.Size = new System.Drawing.Size(578, 50);
            guiones_Label.Text = partida.Guiones.ToString();
            guiones_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            guiones_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            guiones_Label.TabIndex = 2;

            //
            // intento (label)
            //
            Label intento_Label = new Label();

            intento_Label.Location = new System.Drawing.Point(119, 197);
            intento_Label.AutoSize = true;
            intento_Label.Text = "Intento: ";
            intento_Label.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            intento_Label.ForeColor = System.Drawing.Color.White;
            intento_Label.TabIndex = 1;

            //
            // intento (textbox)
            //
            TextBox intento_TextBox = new TextBox();

            intento_TextBox.Location = new System.Drawing.Point(195, 194);
            intento_TextBox.Size = new System.Drawing.Size(128, 26);
            intento_TextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            intento_TextBox.TabIndex = 3;
            intento_TextBox.Focus();

            //
            // aceptar intento (button)
            //
            Button aceptarIntento_Button = new Button();
            
            aceptarIntento_Button.Location = new System.Drawing.Point(356, 193);
            aceptarIntento_Button.Size = new System.Drawing.Size(126, 28);
            aceptarIntento_Button.Text = "Ingresar Intento";
            aceptarIntento_Button.UseVisualStyleBackColor = true;
            aceptarIntento_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aceptarIntento_Button.TabIndex = 4;
            pantallaPrincipal.AcceptButton = aceptarIntento_Button;
            aceptarIntento_Button.Click += new System.EventHandler(AceptarIntento_Button_Click);

            //
            // imagen activar/desactivar pantalla
            //
            PictureBox estadoPanel_Imagen = new PictureBox();

            estadoPanel_Imagen.Location = new System.Drawing.Point(486, 8);
            estadoPanel_Imagen.Size = new System.Drawing.Size(73, 73);
            estadoPanel_Imagen.TabStop = false;
            estadoPanel_Imagen.BackgroundImage = Properties.Resources.activarPantalla;
            estadoPanel_Imagen.TabIndex = 7;
            estadoPanel_Imagen.BackgroundImageChanged += delegate (object sender, EventArgs e) { EstadoPanel_Imagen_BackgroundImageChanged(sender, e, panel); }; ;


            #endregion


            // Añadir controles al panel

            panel.Controls.Add(nombreJugador_Label);
            panel.Controls.Add(guiones_Label);
            panel.Controls.Add(intento_Label);
            panel.Controls.Add(intento_TextBox);
            panel.Controls.Add(aceptarIntento_Button);
            panel.Controls.Add(estadoPanel_Imagen);

            pantallaPrincipal.Controls.Add(panel);

            return panel;
        }
        private void EstadoPanel_Imagen_BackgroundImageChanged(object sender, EventArgs e, Panel panel)
        {
            foreach (Control imagen in paneles[indice.Indice].Controls)
            {
                if (imagen.TabIndex > 5)
                {
                    if (imagen.TabIndex == 7)
                    {
                        foreach (Control control in paneles[indice.Indice].Controls)
                        {  
                            if (control.TabIndex == 3)
                            {
                                control.Enabled = true;                               
                            }
                            else
                            {
                                if (control.TabIndex == 4)
                                {
                                    control.Enabled = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (Control control in paneles[indice.Indice].Controls)
                        {
                            if (control.TabIndex == 3)
                            {
                                control.Enabled = false;
                            }
                            else
                            {
                                if (control.TabIndex == 4)
                                {
                                    control.Enabled = false;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void AceptarIntento_Button_Click(object sender, EventArgs e)
        {
            // Mandar intento a comprobar
            string intento = "";
            foreach (Control textBox in paneles[indice.Indice].Controls)
            {
                if (textBox.TabIndex == 3)
                {
                    intento = textBox.Text;
                    textBox.Text = "";
                    textBox.Focus();
                }
            }
            bool reemplazo;

            var tuple = controlador.ComprobarIntento(partidasMultijugador[indice.Indice], intento);
            partidasMultijugador[indice.Indice] = tuple.Item1;
            reemplazo = tuple.Item2;

            //(partidasMultijugador[indice.Indice], reemplazo) = controlador.ComprobarIntento(partidasMultijugador[indice.Indice], intento);

            // actualizar pantalla
            bool gano = false;
            if (reemplazo)
            {
                
                foreach (Control control in paneles[indice.Indice].Controls)
                {
                    if (control.TabIndex == 2)
                    {
                        control.Text = partidasMultijugador[indice.Indice].Guiones.ToString();
                        if (control.Text == partidasMultijugador[indice.Indice].Palabra)
                        {
                            gano = true;
                        }
                    }
                    else if (control.TabIndex == 4)
                    {
                        pantallaPrincipal.AcceptButton = (Button) control;
                    }
                }
                if (gano)
                {
                    foreach (Control control1 in paneles[indice.Indice].Controls)
                    {
                        if (control1.TabIndex == 1)
                        {
                            paneles[indice.Indice].Controls.Remove(control1);
                        }
                    }
                    foreach (Control control1 in paneles[indice.Indice].Controls)
                    {
                        if (control1.TabIndex == 3)
                        {
                            paneles[indice.Indice].Controls.Remove(control1);
                        }
                    }
                    foreach (Control control1 in paneles[indice.Indice].Controls)
                    {
                        if (control1.TabIndex == 4)
                        {
                            paneles[indice.Indice].Controls.Remove(control1);
                        }
                    }
                    foreach (Control control1 in paneles[indice.Indice].Controls)
                    {
                        if (control1.TabIndex == 7)
                        {
                            paneles[indice.Indice].Controls.Remove(control1);
                        }
                    }

                    Label resultado_Label = new Label();
                    resultado_Label.Location = new System.Drawing.Point(198, 189);
                    resultado_Label.AutoSize = true;
                    resultado_Label.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    resultado_Label.ForeColor = System.Drawing.Color.White;
                    resultado_Label.Text = "GANASTE!!!";
                    resultado_Label.TabIndex = 0;
                    paneles[indice.Indice].Controls.Add(resultado_Label);

                    int contador = 0;
                    do
                    {
                        contador++;
                        indice.Indice++;
                    } while (paneles[indice.Indice].Controls.Count < 4 && contador < 10);

                    foreach (Control image in paneles[indice.Indice].Controls)
                    {
                        if (image.TabIndex == 8)
                        {
                            image.TabIndex = 7;
                            image.BackgroundImage = Properties.Resources.activarPantalla;
                        }
                    }
                }
            }
            else
            {
                foreach (Control image in paneles[indice.Indice].Controls)
                {
                    if (image.TabIndex == 7)
                    {
                        image.TabIndex = 8;
                        image.BackgroundImage = Properties.Resources.desactivarPantalla;
                    }
                }
                do
                {
                    indice.Indice++;
                } while (paneles[indice.Indice].Controls.Count < 4);
                foreach (Control image in paneles[indice.Indice].Controls)
                {
                    if (image.TabIndex == 8)
                    {
                        image.TabIndex = 7;
                        image.BackgroundImage = Properties.Resources.activarPantalla;
                    }
                }
            }
        }
        private void BloquearPanelesIniciales()
        {
            do
            {
                foreach (Control control in paneles[indice.Indice].Controls)
                {
                    if (control.TabIndex == 7)
                    {
                        control.TabIndex = 8;
                        control.BackgroundImage = Properties.Resources.desactivarPantalla;
                    }
                }
                indice.Indice++;
            } while (indice.Indice < paneles.Count && indice.Indice != 0);
        }
        #endregion
    }
}
