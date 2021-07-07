using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoWindowsForm
{
    class ModoTradicionalScreen
    {
        Form1 mainScreen;
        Label palabraElegidaLabel;
        TextBox palabraElegidaTextBox;
        Label vidasLabel;
        TextBox vidasTextBox;
        CheckBox mostrarIntentosCheckBox;
        CheckBox mostrarPrimerLetraCheckBox;
        Button aceptarButton;


        public ModoTradicionalScreen(Form1 mainScreen)
        {
            this.mainScreen = mainScreen;
            //
            // mainMenuButton
            //
            new MainMenuButton(mainScreen);

            //
            // palabraElegidaLabel
            //
            palabraElegidaLabel = new Label();
            palabraElegidaLabel.Location = new System.Drawing.Point(309, 83);
            palabraElegidaLabel.AutoSize = true;
            palabraElegidaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            palabraElegidaLabel.ForeColor = System.Drawing.Color.White;
            palabraElegidaLabel.Text = "Escriba la palabra a adivinar:";
            mainScreen.Controls.Add(palabraElegidaLabel);

            //
            // palabraElegidaTextBox
            //
            palabraElegidaTextBox = new TextBox();
            palabraElegidaTextBox.Location = new System.Drawing.Point(311, 114);
            palabraElegidaTextBox.Size = new System.Drawing.Size(150, 30);
            palabraElegidaTextBox.TabIndex = 2;
            palabraElegidaTextBox.Text = "";
            palabraElegidaTextBox.PasswordChar = '*';
            palabraElegidaTextBox.TextChanged += new System.EventHandler(PalabraElegidaTextBox_TextChanged);
            mainScreen.Controls.Add(palabraElegidaTextBox);

            //
            // vidasLabel
            //
            vidasLabel = new Label();
            vidasLabel.Location = new System.Drawing.Point(87, 232);
            vidasLabel.AutoSize = true;
            vidasLabel.TabIndex = 1;
            vidasLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vidasLabel.ForeColor = System.Drawing.Color.White;
            vidasLabel.Text = "Cantidad de vidas: ";
            mainScreen.Controls.Add(vidasLabel);

            //
            // vidasTextBox
            //
            vidasTextBox = new TextBox();
            vidasTextBox.Location = new System.Drawing.Point(230, 231);
            vidasTextBox.Size = new System.Drawing.Size(100, 20);
            vidasTextBox.TabIndex = 2;
            vidasTextBox.TextChanged += new System.EventHandler(VidasTextBox_TextChanged);
            mainScreen.Controls.Add(vidasTextBox);

            //
            // mostrarIntentosCheckBox
            //
            mostrarIntentosCheckBox = new CheckBox();
            mostrarIntentosCheckBox.Location = new System.Drawing.Point(80, 270);
            mostrarIntentosCheckBox.AutoSize = true;
            mostrarIntentosCheckBox.RightToLeft = RightToLeft.Yes;
            mostrarIntentosCheckBox.TabIndex = 0;
            mostrarIntentosCheckBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mostrarIntentosCheckBox.ForeColor = System.Drawing.Color.White;
            mostrarIntentosCheckBox.Text = "?Mostrar intentos erróneos¿"; //JAJAJAJAJAJAJAJ WTF, los signos de pregunta se imprimen al reves
            mostrarIntentosCheckBox.UseVisualStyleBackColor = true;
            mainScreen.Controls.Add(mostrarIntentosCheckBox);

            //
            // mostrarPrimerLetraCheckBox
            //
            mostrarPrimerLetraCheckBox = new CheckBox();
            mostrarPrimerLetraCheckBox.Location = new System.Drawing.Point(80, 310);
            mostrarPrimerLetraCheckBox.AutoSize = true;
            mostrarPrimerLetraCheckBox.RightToLeft = RightToLeft.Yes;
            mostrarPrimerLetraCheckBox.TabIndex = 0;
            mostrarPrimerLetraCheckBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mostrarPrimerLetraCheckBox.ForeColor = System.Drawing.Color.White;
            mostrarPrimerLetraCheckBox.Text = "?Mostrar la primera letra¿";
            mostrarPrimerLetraCheckBox.UseVisualStyleBackColor = true;
            mainScreen.Controls.Add(mostrarPrimerLetraCheckBox);

            //
            // aceptarButton
            //
            aceptarButton = new Button();
            aceptarButton.Location = new System.Drawing.Point(540, 230);
            aceptarButton.Size = new System.Drawing.Size(151, 132);
            aceptarButton.TabIndex = 3;
            aceptarButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            mainScreen.Controls.Add(aceptarButton);

        }



        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (vidasTextBox.Text.Length > 0 && palabraElegidaTextBox.Text.Length > 1)
            {
                ClearView();
                AhorcadoGame ahorcadoGame = new AhorcadoGame(palabraElegidaTextBox.Text, int.Parse(vidasTextBox.Text), mostrarIntentosCheckBox.Checked, mostrarPrimerLetraCheckBox.Checked);
                new AhorcadoScreen(mainScreen, ahorcadoGame);
            }
        }
        private void ClearView()
        {
            mainScreen.Controls.Clear();
        }




        private void PalabraElegidaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(palabraElegidaTextBox.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Solo se pueden escribir letras");
                palabraElegidaTextBox.Text = palabraElegidaTextBox.Text.Remove(palabraElegidaTextBox.Text.Length - 1);
            }
            else if (palabraElegidaTextBox.Text.Length > 20)
            {
                MessageBox.Show("La palabra a adivinar no puede tener más de 20 letras");
                palabraElegidaTextBox.Text = palabraElegidaTextBox.Text.Remove(palabraElegidaTextBox.Text.Length - 1);
            }

        }
        private void VidasTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(vidasTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se pueden escribir números.");
                vidasTextBox.Text = vidasTextBox.Text.Remove(vidasTextBox.Text.Length - 1);
            }
            else if (vidasTextBox.Text == "0")
            {
                MessageBox.Show("Tiene que haber al menos 1 vida");
                vidasTextBox.Text = vidasTextBox.Text.Remove(vidasTextBox.Text.Length - 1);
            }
        }
    }
}
