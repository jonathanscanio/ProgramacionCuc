using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AhorcadoWindowsForms.src.Controlador;
using AhorcadoWindowsForms.src.Modelo;

namespace AhorcadoWindowsForms.src.Vista
{
    class Multijugador_Vista : PantallaPredefinida
    {


        #region Atributos

        Multijugador_Controlador controlador;


        Label cantidadJugadores_Label;
        ComboBox cantidadJugadores_ComboBox;
        Button aceptar_Button;

        Panel jugador1_Panel;
        Panel jugador2_Panel;
        Panel jugador3_Panel;
        Panel jugador4_Panel;

        #endregion

        public Multijugador_Vista(Form1 pantallaPrincipal) : base(pantallaPrincipal)
        {
            this.pantallaPrincipal = pantallaPrincipal;

            controlador = new Multijugador_Controlador();

            //
            // cantidadJugadores_Label
            //
            cantidadJugadores_Label = new Label();
            cantidadJugadores_Label.Location = new System.Drawing.Point(280, 50);
            cantidadJugadores_Label.AutoSize = true;
            cantidadJugadores_Label.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadJugadores_Label.ForeColor = System.Drawing.Color.White;
            cantidadJugadores_Label.Text = "Cantidad de Jugadores: ";
            pantallaPrincipal.Controls.Add(cantidadJugadores_Label);

            //
            // cantidadJugadores_ComboBox
            //
            cantidadJugadores_ComboBox = new ComboBox();
            cantidadJugadores_ComboBox.Items.AddRange(new object[] {"2",
                        "3",
                        "4"});
            cantidadJugadores_ComboBox.Location = new System.Drawing.Point(563, 47);
            cantidadJugadores_ComboBox.Size = new System.Drawing.Size(71, 50);
            cantidadJugadores_ComboBox.SelectedIndex = 0;
            cantidadJugadores_ComboBox.DropDownWidth = 50;
            cantidadJugadores_ComboBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadJugadores_ComboBox.SelectedIndexChanged += new System.EventHandler(this.CantidadJugadores_ComboBox_SelectedIndexChanged);
            pantallaPrincipal.Controls.Add(cantidadJugadores_ComboBox);

            //
            // aceptar_Button
            //
            aceptar_Button = new Button();
            aceptar_Button.Location = new System.Drawing.Point(700, 47);
            aceptar_Button.Size = new System.Drawing.Size(110, 30);
            aceptar_Button.TabIndex = 3;
            aceptar_Button.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aceptar_Button.Text = "Aceptar";
            aceptar_Button.UseVisualStyleBackColor = true;
            aceptar_Button.Click += new System.EventHandler(this.Aceptar_Button_Click);
            pantallaPrincipal.Controls.Add(aceptar_Button);

            //
            // jugador1_Panel
            //
            jugador1_Panel = new Panel();
            jugador1_Panel = CrearPanel(12, 111, 1);
            pantallaPrincipal.Controls.Add(jugador1_Panel);

            //
            // jugador2_Panel
            //
            jugador2_Panel = new Panel();
            jugador2_Panel = CrearPanel(610, 111, 2);
            pantallaPrincipal.Controls.Add(jugador2_Panel);

            //
            // jugador3_Panel
            //
            jugador3_Panel = new Panel();
            jugador3_Panel = CrearPanel(12, 389, 3);

            //
            // jugador4_Panel
            //
            jugador4_Panel = new Panel();
            jugador4_Panel = CrearPanel(610, 389, 4);
        }
        private void CantidadJugadores_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cantidadJugadores_ComboBox.SelectedIndex)
            {
                case 0: // 2 jugadores
                    pantallaPrincipal.Controls.Add(jugador1_Panel);
                    pantallaPrincipal.Controls.Add(jugador2_Panel);
                    pantallaPrincipal.Controls.Remove(jugador3_Panel);
                    pantallaPrincipal.Controls.Remove(jugador4_Panel);
                    break;

                case 1: // 3 jugadores
                    pantallaPrincipal.Controls.Add(jugador1_Panel);
                    pantallaPrincipal.Controls.Add(jugador2_Panel);
                    pantallaPrincipal.Controls.Add(jugador3_Panel);
                    pantallaPrincipal.Controls.Remove(jugador4_Panel);
                    break;
                     
                case 2: // 4 Jugadores
                    pantallaPrincipal.Controls.Add(jugador1_Panel);
                    pantallaPrincipal.Controls.Add(jugador2_Panel);
                    pantallaPrincipal.Controls.Add(jugador3_Panel);
                    pantallaPrincipal.Controls.Add(jugador4_Panel);
                    break;
            }
        }
        private void Aceptar_Button_Click(object sender, EventArgs e)
        {
            List<Panel> paneles = new List<Panel>();

            paneles.Add(jugador1_Panel);
            paneles.Add(jugador2_Panel);
            if (pantallaPrincipal.Contains(jugador3_Panel))
            {
                paneles.Add(jugador3_Panel);
            }
            if (pantallaPrincipal.Contains(jugador4_Panel))
            {
                paneles.Add(jugador4_Panel);
            }

            bool datosIngresadosCorrectos = controlador.VerificarNombresPalabras(paneles);
            if (datosIngresadosCorrectos)
            {
                List<ParametrosPartidaMultijugador> parametrosPartidaMultijugador= new List<ParametrosPartidaMultijugador>();
                parametrosPartidaMultijugador = controlador.SetearParametroPartidaMultijugador(paneles);

                LimpiarVista();

                new JuegoMultijugador_Vista(pantallaPrincipal, parametrosPartidaMultijugador);
            }
        }


        private Panel CrearPanel(int x, int y, int numeroJugador)
        {


            #region Controles del panel

            //
            // numero del jugador
            // 
            Label numeroJugador_Label = new Label();

            numeroJugador_Label.Location = new System.Drawing.Point(17, 14);
            numeroJugador_Label.Size = new System.Drawing.Size(116, 46);
            numeroJugador_Label.Text = "Jugador " + numeroJugador.ToString();
            numeroJugador_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            numeroJugador_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            numeroJugador_Label.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroJugador_Label.ForeColor = System.Drawing.Color.White;
            numeroJugador_Label.TabIndex = 1;

            //
            // nombre del jugador label
            //
            Label nombreJugador_Label = new Label();

            nombreJugador_Label.Location = new System.Drawing.Point(62, 90);
            nombreJugador_Label.AutoSize = true;
            nombreJugador_Label.Text = "Nombre del Jugador: ";
            nombreJugador_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreJugador_Label.ForeColor = System.Drawing.Color.White;
            nombreJugador_Label.TabIndex = 1;

            //
            // palabra a adivinar label
            //
            Label palabraElegida_Label = new Label();

            palabraElegida_Label.Location = new System.Drawing.Point(62, 158);
            palabraElegida_Label.AutoSize = true;
            palabraElegida_Label.Text = "Palabra a Adivinar:";
            palabraElegida_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            palabraElegida_Label.ForeColor = System.Drawing.Color.White;
            palabraElegida_Label.TabIndex = 1;

            //
            // nombre del jugador textbox
            //
            TextBox nombreJugador_TextBox = new TextBox();

            nombreJugador_TextBox.Location = new System.Drawing.Point(258, 87);
            nombreJugador_TextBox.Size = new System.Drawing.Size(173, 26);
            nombreJugador_TextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreJugador_TextBox.TabIndex = 2;

            //
            // palabra a adivinar Textbox
            //
            TextBox palabraElegida_TextBox = new TextBox();

            palabraElegida_TextBox.Location = new System.Drawing.Point(258, 155);
            palabraElegida_TextBox.Size = new System.Drawing.Size(173, 26);
            palabraElegida_TextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            palabraElegida_TextBox.Text = "";
            palabraElegida_TextBox.PasswordChar = '*';
            palabraElegida_TextBox.TabIndex = 3;

            #endregion


            //
            // panel
            //
            Panel panel = new Panel();

            panel.Location = new System.Drawing.Point(x, y);
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Size = new System.Drawing.Size(578, 261);
            panel.Controls.Add(numeroJugador_Label);
            panel.Controls.Add(nombreJugador_Label);
            panel.Controls.Add(palabraElegida_Label);
            panel.Controls.Add(nombreJugador_TextBox);
            panel.Controls.Add(palabraElegida_TextBox);



            return panel;
        }

        private void PalabraElegidaTextBox_TextChanged(object sender, EventArgs e, string textoIngresadoPorUsario)
        {
            if (Regex.IsMatch(textoIngresadoPorUsario, "[^a-zA-Z]"))
            {
                MessageBox.Show("Solo se pueden escribir letras");
                textoIngresadoPorUsario = textoIngresadoPorUsario.Remove(textoIngresadoPorUsario.Length - 1);
            }
            else if (textoIngresadoPorUsario.Length > 20)
            {
                MessageBox.Show("La palabra a adivinar no puede tener más de 20 letras");
                textoIngresadoPorUsario = textoIngresadoPorUsario.Remove(textoIngresadoPorUsario.Length - 1);
            }
        }

        private void LimpiarVista()
        {
            pantallaPrincipal.Controls.Remove(cantidadJugadores_Label);
            pantallaPrincipal.Controls.Remove(cantidadJugadores_ComboBox);
            pantallaPrincipal.Controls.Remove(aceptar_Button);
            pantallaPrincipal.Controls.Remove(jugador1_Panel);
            pantallaPrincipal.Controls.Remove(jugador2_Panel);
            pantallaPrincipal.Controls.Remove(jugador3_Panel);
            pantallaPrincipal.Controls.Remove(jugador4_Panel);
        }
    }
}
