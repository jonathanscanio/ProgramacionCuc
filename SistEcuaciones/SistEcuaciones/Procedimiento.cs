using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SistEcuaciones
{
    class Procedimiento
    {
        #region Controles
        Panel mainScreen;
        Panel pnProcedimientos;
        Size panelSize;
        Label lbS5;
        Label lbX5;
        Label lbY5;
        Label lbSolucionY;
        Label lbSolucionX;
        Label lbSoluY2;
        Label lbSoluY1;
        Label lbSoluY;
        Label lbSoluX2;
        Label lbSoluX1;
        Label lbSoluX;
        Label lbY4;
        Label lbY3;
        Label lbY2;
        Label lbY1;
        Label lbX4;
        Label lbX3;
        Label lbX2;
        Label lbX1;
        Label lbS4;
        Label lbS3;
        Label lbS2;
        Label lbS1;
        PictureBox picLineaHorizY;
        PictureBox picLineaHorizX;
        PictureBox picFlechaY;
        PictureBox picFlechaX;
        PictureBox picFlechaS;

        PictureBox picLineaY1;
        PictureBox picLineaX1;
        PictureBox picLineaS1;

        PictureBox picDeltaX;
        PictureBox picDeltaS;
        PictureBox picDeltaY;
        PictureBox picLineaS2;
        PictureBox picLineaY2;
        PictureBox picLineaX2;

        #endregion

        #region Constructor
        public Procedimiento(Panel mainScreen , Size principalSize)
        {
            this.mainScreen = mainScreen;
            panelSize = principalSize;

            this.pnProcedimientos = new System.Windows.Forms.Panel();
            this.lbS1 = new System.Windows.Forms.Label();
            this.lbS2 = new System.Windows.Forms.Label();
            this.lbS3 = new System.Windows.Forms.Label();
            this.lbS4 = new System.Windows.Forms.Label();
            this.lbX4 = new System.Windows.Forms.Label();
            this.lbX3 = new System.Windows.Forms.Label();
            this.lbX2 = new System.Windows.Forms.Label();
            this.lbX1 = new System.Windows.Forms.Label();
            this.lbY4 = new System.Windows.Forms.Label();
            this.lbY3 = new System.Windows.Forms.Label();
            this.lbY2 = new System.Windows.Forms.Label();
            this.lbY1 = new System.Windows.Forms.Label();
            this.lbSoluX1 = new System.Windows.Forms.Label();
            this.lbSoluX2 = new System.Windows.Forms.Label();
            this.lbSoluY1 = new System.Windows.Forms.Label();
            this.lbSoluY2 = new System.Windows.Forms.Label();
            this.lbSoluY = new System.Windows.Forms.Label();
            this.lbSoluX = new System.Windows.Forms.Label();
            this.lbSolucionX = new System.Windows.Forms.Label();
            this.lbSolucionY = new System.Windows.Forms.Label();
            this.lbY5 = new System.Windows.Forms.Label();
            this.lbX5 = new System.Windows.Forms.Label();
            this.lbS5 = new System.Windows.Forms.Label();
            this.picLineaHorizY = new System.Windows.Forms.PictureBox();
            this.picLineaHorizX = new System.Windows.Forms.PictureBox();
            this.picFlechaY = new System.Windows.Forms.PictureBox();
            this.picFlechaX = new System.Windows.Forms.PictureBox();
            this.picFlechaS = new System.Windows.Forms.PictureBox();
            this.picLineaY1 = new System.Windows.Forms.PictureBox();
            this.picLineaX1 = new System.Windows.Forms.PictureBox();
            this.picLineaS1 = new System.Windows.Forms.PictureBox();
            this.picLineaY2 = new System.Windows.Forms.PictureBox();
            this.picLineaX2 = new System.Windows.Forms.PictureBox();
            this.picLineaS2 = new System.Windows.Forms.PictureBox();
            this.picDeltaX = new System.Windows.Forms.PictureBox();
            this.picDeltaS = new System.Windows.Forms.PictureBox();
            this.picDeltaY = new System.Windows.Forms.PictureBox();
            this.pnProcedimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLineaHorizY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineaHorizX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlechaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlechaX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlechaS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineaY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineaX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineaS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineaY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineaX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineaS2)).BeginInit();

            // 
            // pnProcedimientos
            // 
            this.pnProcedimientos.Controls.Add(this.lbS5);
            this.pnProcedimientos.Controls.Add(this.lbX5);
            this.pnProcedimientos.Controls.Add(this.lbY5);
            this.pnProcedimientos.Controls.Add(this.lbSolucionY);
            this.pnProcedimientos.Controls.Add(this.lbSolucionX);
            this.pnProcedimientos.Controls.Add(this.lbSoluY2);
            this.pnProcedimientos.Controls.Add(this.lbSoluY1);
            this.pnProcedimientos.Controls.Add(this.lbSoluX2);
            this.pnProcedimientos.Controls.Add(this.lbSoluX1);
            this.pnProcedimientos.Controls.Add(this.lbSoluX);
            this.pnProcedimientos.Controls.Add(this.lbSoluY);
            this.pnProcedimientos.Controls.Add(this.lbY4);
            this.pnProcedimientos.Controls.Add(this.lbY3);
            this.pnProcedimientos.Controls.Add(this.lbY2);
            this.pnProcedimientos.Controls.Add(this.lbY1);
            this.pnProcedimientos.Controls.Add(this.lbX4);
            this.pnProcedimientos.Controls.Add(this.lbX3);
            this.pnProcedimientos.Controls.Add(this.lbX2);
            this.pnProcedimientos.Controls.Add(this.lbX1);
            this.pnProcedimientos.Controls.Add(this.lbS4);
            this.pnProcedimientos.Controls.Add(this.lbS3);
            this.pnProcedimientos.Controls.Add(this.lbS2);
            this.pnProcedimientos.Controls.Add(this.lbS1);
            this.pnProcedimientos.Controls.Add(this.picLineaHorizY);
            this.pnProcedimientos.Controls.Add(this.picLineaHorizX);
            this.pnProcedimientos.Controls.Add(this.picFlechaY);
            this.pnProcedimientos.Controls.Add(this.picFlechaX);
            this.pnProcedimientos.Controls.Add(this.picFlechaS);
            this.pnProcedimientos.Controls.Add(this.picLineaY1);
            this.pnProcedimientos.Controls.Add(this.picLineaX1);
            this.pnProcedimientos.Controls.Add(this.picLineaS1);
            this.pnProcedimientos.Controls.Add(this.picLineaY2);
            this.pnProcedimientos.Controls.Add(this.picLineaX2);
            this.pnProcedimientos.Controls.Add(this.picLineaS2);
            this.pnProcedimientos.Controls.Add(this.picDeltaX);
            this.pnProcedimientos.Controls.Add(this.picDeltaY);
            this.pnProcedimientos.Controls.Add(this.picDeltaS);
            this.pnProcedimientos.BackColor = System.Drawing.Color.White;
            this.pnProcedimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProcedimientos.Location = new System.Drawing.Point(250, 0);
            this.pnProcedimientos.Name = "pnInfo";
            this.pnProcedimientos.Size = new System.Drawing.Size(1150, 900);
            this.pnProcedimientos.TabIndex = 1;


            #region DELTA S
            // 
            // lbS1
            // 
            this.lbS1.AutoSize = true;
            this.lbS1.BackColor = System.Drawing.Color.Transparent;
            this.lbS1.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS1.Location = new System.Drawing.Point(135, 16);
            this.lbS1.Name = "lbS1";
            this.lbS1.Size = new System.Drawing.Size(64, 43);
            this.lbS1.TabIndex = 9;
            this.lbS1.Text = "10";
            // 
            // lbS2
            // 
            this.lbS2.AutoSize = true;
            this.lbS2.BackColor = System.Drawing.Color.Transparent;
            this.lbS2.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS2.Location = new System.Drawing.Point(135, 106);
            this.lbS2.Name = "lbS2";
            this.lbS2.Size = new System.Drawing.Size(64, 43);
            this.lbS2.TabIndex = 10;
            this.lbS2.Text = "10";
            // 
            // picFlechaS
            // 
            this.picFlechaS.BackColor = System.Drawing.Color.Transparent;
            this.picFlechaS.Image = global::SistEcuaciones.Properties.Resources.Flechas_Cruzadas;
            this.picFlechaS.Location = new System.Drawing.Point(200, 54);
            this.picFlechaS.Name = "picFlechaS";
            this.picFlechaS.Size = new System.Drawing.Size(68, 48);
            this.picFlechaS.TabIndex = 3;
            this.picFlechaS.TabStop = false;
            // 
            // lbS3
            // 
            this.lbS3.AutoSize = true;
            this.lbS3.BackColor = System.Drawing.Color.Transparent;
            this.lbS3.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS3.Location = new System.Drawing.Point(270, 16);
            this.lbS3.Name = "lbS3";
            this.lbS3.Size = new System.Drawing.Size(64, 43);
            this.lbS3.TabIndex = 11;
            this.lbS3.Text = "100";
            // 
            // lbS4
            // 
            this.lbS4.AutoSize = true;
            this.lbS4.BackColor = System.Drawing.Color.Transparent;
            this.lbS4.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS4.Location = new System.Drawing.Point(270, 106);
            this.lbS4.Name = "lbS4";
            this.lbS4.Size = new System.Drawing.Size(64, 43);
            this.lbS4.TabIndex = 12;
            this.lbS4.Text = "100";
            // 
            // picLineaS
            // 
            this.picLineaS1.Image = global::SistEcuaciones.Properties.Resources.Linea_Vertical;
            this.picLineaS1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLineaS1.Location = new System.Drawing.Point(340, 6);
            this.picLineaS1.Name = "picLineaS";
            this.picLineaS1.Size = new System.Drawing.Size(9, 143);
            this.picLineaS1.TabIndex = 0;
            this.picLineaS1.TabStop = false;
            // 
            // lbS5
            // 
            this.lbS5.AutoSize = true;
            this.lbS5.BackColor = System.Drawing.Color.Transparent;
            this.lbS5.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS5.Location = new System.Drawing.Point(340, 54);
            this.lbS5.Name = "lbS5";
            this.lbS5.Size = new System.Drawing.Size(280, 43);
            this.lbS5.TabIndex = 21;
            this.lbS5.Text = "= (6 * 10) - (2 * 5) = 50";
            #endregion

            #region DELTA X
            // 
            // lbX1
            // 
            this.lbX1.AutoSize = true;
            this.lbX1.BackColor = System.Drawing.Color.Transparent;
            this.lbX1.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX1.Location = new System.Drawing.Point(135, 219);
            this.lbX1.Name = "lbX1";
            this.lbX1.Size = new System.Drawing.Size(64, 43);
            this.lbX1.TabIndex = 13;
            this.lbX1.Text = "1";
            // 
            // lbX2
            // 
            this.lbX2.AutoSize = true;
            this.lbX2.BackColor = System.Drawing.Color.Transparent;
            this.lbX2.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX2.Location = new System.Drawing.Point(135, 309);
            this.lbX2.Name = "lbX2";
            this.lbX2.Size = new System.Drawing.Size(64, 43);
            this.lbX2.TabIndex = 14;
            this.lbX2.Text = "1";
            // 
            // picFlechaX
            // 
            this.picFlechaX.BackColor = System.Drawing.Color.Transparent;
            this.picFlechaX.Image = global::SistEcuaciones.Properties.Resources.Flechas_Cruzadas; ;
            this.picFlechaX.Location = new System.Drawing.Point(205, 259);
            this.picFlechaX.Name = "picFlechaX";
            this.picFlechaX.Size = new System.Drawing.Size(68, 48);
            this.picFlechaX.TabIndex = 4;
            this.picFlechaX.TabStop = false;
            // 
            // lbX3
            // 
            this.lbX3.AutoSize = true;
            this.lbX3.BackColor = System.Drawing.Color.Transparent;
            this.lbX3.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX3.Location = new System.Drawing.Point(280, 219);
            this.lbX3.Name = "lbX3";
            this.lbX3.Size = new System.Drawing.Size(64, 43);
            this.lbX3.TabIndex = 15;
            this.lbX3.Text = "1";
            // 
            // lbX4
            // 
            this.lbX4.AutoSize = true;
            this.lbX4.BackColor = System.Drawing.Color.Transparent;
            this.lbX4.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX4.Location = new System.Drawing.Point(280, 309);
            this.lbX4.Name = "lbX4";
            this.lbX4.Size = new System.Drawing.Size(64, 43);
            this.lbX4.TabIndex = 16;
            this.lbX4.Text = "1";
            // 
            // picLineaX
            // 
            this.picLineaX1.Image = global::SistEcuaciones.Properties.Resources.Linea_Vertical;
            this.picLineaX1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLineaX1.Location = new System.Drawing.Point(350, 214);
            this.picLineaX1.Name = "picLineaX";
            this.picLineaX1.Size = new System.Drawing.Size(9, 143);
            this.picLineaX1.TabIndex = 1;
            this.picLineaX1.TabStop = false;
            // 
            // lbX5
            // 
            this.lbX5.AutoSize = true;
            this.lbX5.BackColor = System.Drawing.Color.Transparent;
            this.lbX5.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX5.Location = new System.Drawing.Point(360, 264);
            this.lbX5.Name = "lbX5";
            this.lbX5.Size = new System.Drawing.Size(280, 43);
            this.lbX5.TabIndex = 22;
            this.lbX5.Text = "= (6 * 10) - (2 * 5) = 50";
            #endregion

            #region DELTA Y
            // 
            // lbY1
            // 
            this.lbY1.AutoSize = true;
            this.lbY1.BackColor = System.Drawing.Color.Transparent;
            this.lbY1.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbY1.Location = new System.Drawing.Point(131, 442);
            this.lbY1.Name = "lbY1";
            this.lbY1.Size = new System.Drawing.Size(64, 43);
            this.lbY1.TabIndex = 17;
            this.lbY1.Text = "100";
            // 
            // lbY2
            // 
            this.lbY2.AutoSize = true;
            this.lbY2.BackColor = System.Drawing.Color.Transparent;
            this.lbY2.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbY2.Location = new System.Drawing.Point(131, 532);
            this.lbY2.Name = "lbY2";
            this.lbY2.Size = new System.Drawing.Size(64, 43);
            this.lbY2.TabIndex = 18;
            this.lbY2.Text = "100";
            // 
            // picFlechaY
            // 
            this.picFlechaY.BackColor = System.Drawing.Color.Transparent;
            this.picFlechaY.Image = global::SistEcuaciones.Properties.Resources.Flechas_Cruzadas;
            this.picFlechaY.Location = new System.Drawing.Point(180, 480);
            this.picFlechaY.Name = "picFlechaY";
            this.picFlechaY.Size = new System.Drawing.Size(68, 48);
            this.picFlechaY.TabIndex = 5;
            this.picFlechaY.TabStop = false;
            // 
            // lbY3
            // 
            this.lbY3.AutoSize = true;
            this.lbY3.BackColor = System.Drawing.Color.Transparent;
            this.lbY3.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbY3.Location = new System.Drawing.Point(250, 442);
            this.lbY3.Name = "lbY3";
            this.lbY3.Size = new System.Drawing.Size(64, 43);
            this.lbY3.TabIndex = 0;
            this.lbY3.Text = "100";
            // 
            // lbY4
            // 
            this.lbY4.AutoSize = true;
            this.lbY4.BackColor = System.Drawing.Color.Transparent;
            this.lbY4.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbY4.Location = new System.Drawing.Point(250, 532);
            this.lbY4.Name = "lbY4";
            this.lbY4.Size = new System.Drawing.Size(64, 43);
            this.lbY4.TabIndex = 0;
            this.lbY4.Text = "100";
            // 
            // picLineaY
            // 
            this.picLineaY1.Image = global::SistEcuaciones.Properties.Resources.Linea_Vertical;
            this.picLineaY1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLineaY1.Location = new System.Drawing.Point(305, 435);
            this.picLineaY1.Name = "picLineaY";
            this.picLineaY1.Size = new System.Drawing.Size(9, 143);
            this.picLineaY1.TabIndex = 0;
            this.picLineaY1.TabStop = false;
            // 
            // lbY5
            // 
            this.lbY5.AutoSize = true;
            this.lbY5.BackColor = System.Drawing.Color.Transparent;
            this.lbY5.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbY5.Location = new System.Drawing.Point(315, 485);
            this.lbY5.Name = "lbY5";
            this.lbY5.Size = new System.Drawing.Size(280, 43);
            this.lbY5.TabIndex = 23;
            this.lbY5.Text = "= (6 * 10) - (2 * 5) = 50";
            #endregion

            #region SOLUCION X
            // 
            // lbSoluX
            // 
            this.lbSoluX.AutoSize = true;
            this.lbSoluX.BackColor = System.Drawing.Color.Transparent;
            this.lbSoluX.Font = new System.Drawing.Font("Bebas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoluX.Location = new System.Drawing.Point(201, 685);
            this.lbSoluX.Name = "lbSoluX1";
            this.lbSoluX.Size = new System.Drawing.Size(64, 43);
            this.lbSoluX.TabIndex = 24;
            this.lbSoluX.Text = "X= ";
            // 
            // lbSoluX1
            // 
            this.lbSoluX1.AutoSize = true;
            this.lbSoluX1.BackColor = System.Drawing.Color.Transparent;
            this.lbSoluX1.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoluX1.Location = new System.Drawing.Point(201, 685);
            this.lbSoluX1.Name = "lbSoluX1";
            this.lbSoluX1.Size = new System.Drawing.Size(64, 43);
            this.lbSoluX1.TabIndex = 24;
            this.lbSoluX1.Text = "100";
            // 
            // lbSoluX2
            // 
            this.lbSoluX2.AutoSize = true;
            this.lbSoluX2.BackColor = System.Drawing.Color.Transparent;
            this.lbSoluX2.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoluX2.Location = new System.Drawing.Point(201, 743);
            this.lbSoluX2.Name = "lbSoluX2";
            this.lbSoluX2.Size = new System.Drawing.Size(64, 43);
            this.lbSoluX2.TabIndex = 25;
            this.lbSoluX2.Text = "100";
            // 
            // picLineaHorizX
            // 
            this.picLineaHorizX.BackColor = System.Drawing.Color.Transparent;
            this.picLineaHorizX.BackgroundImage = global::SistEcuaciones.Properties.Resources.Linea_Horizontal;
            this.picLineaHorizX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLineaHorizX.Location = new System.Drawing.Point(191, 731);
            this.picLineaHorizX.Name = "picLineaHorizX";
            this.picLineaHorizX.Size = new System.Drawing.Size(124, 9);
            this.picLineaHorizX.TabIndex = 6;
            this.picLineaHorizX.TabStop = false;
            // 
            // lbSolucionX
            // 
            this.lbSolucionX.AutoSize = true;
            this.lbSolucionX.BackColor = System.Drawing.Color.Transparent;
            this.lbSolucionX.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSolucionX.Location = new System.Drawing.Point(350, 711);
            this.lbSolucionX.Name = "lbSolucionX";
            this.lbSolucionX.Size = new System.Drawing.Size(85, 43);
            this.lbSolucionX.TabIndex = 29;
            this.lbSolucionX.Text = "= 100";
            #endregion

            #region SOLUCION Y
            // 
            // lbSoluY
            // 
            this.lbSoluY.AutoSize = true;
            this.lbSoluY.BackColor = System.Drawing.Color.Transparent;
            this.lbSoluY.Font = new System.Drawing.Font("Bebas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoluY.Location = new System.Drawing.Point(201, 685);
            this.lbSoluY.Name = "lbSoluX1";
            this.lbSoluY.Size = new System.Drawing.Size(64, 43);
            this.lbSoluY.TabIndex = 24;
            this.lbSoluY.Text = "Y= ";
            // 
            // lbSoluY1
            // 
            this.lbSoluY1.AutoSize = true;
            this.lbSoluY1.BackColor = System.Drawing.Color.Transparent;
            this.lbSoluY1.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoluY1.Location = new System.Drawing.Point(802, 685);
            this.lbSoluY1.Name = "lbSoluY1";
            this.lbSoluY1.Size = new System.Drawing.Size(64, 43);
            this.lbSoluY1.TabIndex = 26;
            this.lbSoluY1.Text = "1909,0";
            // 
            // lbSoluY2
            // 
            this.lbSoluY2.AutoSize = true;
            this.lbSoluY2.BackColor = System.Drawing.Color.Transparent;
            this.lbSoluY2.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoluY2.Location = new System.Drawing.Point(802, 743);
            this.lbSoluY2.Name = "lbSoluY2";
            this.lbSoluY2.Size = new System.Drawing.Size(64, 43);
            this.lbSoluY2.TabIndex = 27;
            this.lbSoluY2.Text = "1000";
            // 
            // picLineaHorizY
            // 
            this.picLineaHorizY.BackColor = System.Drawing.Color.Transparent;
            this.picLineaHorizY.BackgroundImage = global::SistEcuaciones.Properties.Resources.Linea_Horizontal;
            this.picLineaHorizY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLineaHorizY.Location = new System.Drawing.Point(792, 731);
            this.picLineaHorizY.Name = "picLineaHorizY";
            this.picLineaHorizY.Size = new System.Drawing.Size(124, 9);
            this.picLineaHorizY.TabIndex = 8;
            this.picLineaHorizY.TabStop = false;
            // 
            // lbSolucionY
            // 
            this.lbSolucionY.AutoSize = true;
            this.lbSolucionY.BackColor = System.Drawing.Color.Transparent;
            this.lbSolucionY.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSolucionY.Location = new System.Drawing.Point(350, 711);
            this.lbSolucionY.Name = "lbSolucionY";
            this.lbSolucionY.Size = new System.Drawing.Size(85, 43);
            this.lbSolucionY.TabIndex = 28;
            this.lbSolucionY.Text = "= 100";





            #endregion

            #region IMAGENES DE LINEAS

            // 
            // picLineaX
            // 
            this.picLineaX2.Image = global::SistEcuaciones.Properties.Resources.Linea_Vertical;
            this.picLineaX2.Location = new System.Drawing.Point(122, 6);
            this.picLineaX2.Name = "picLineaX";
            this.picLineaX2.Size = new System.Drawing.Size(10, 147);
            this.picLineaX2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLineaX2.TabIndex = 17;
            this.picLineaX2.TabStop = false;
            // 
            // picLineaY
            // 
            this.picLineaY2.Image = global::SistEcuaciones.Properties.Resources.Linea_Vertical;
            this.picLineaY2.Location = new System.Drawing.Point(189, 6);
            this.picLineaY2.Name = "picLineaY";
            this.picLineaY2.Size = new System.Drawing.Size(10, 147);
            this.picLineaY2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLineaY2.TabIndex = 18;
            this.picLineaY2.TabStop = false;
            // 
            // picLineaS
            // 
            this.picLineaS2.Image = global::SistEcuaciones.Properties.Resources.Linea_Vertical;
            this.picLineaS2.Location = new System.Drawing.Point(262, 15);
            this.picLineaS2.Name = "picLineaS";
            this.picLineaS2.Size = new System.Drawing.Size(10, 147);
            this.picLineaS2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLineaS2.TabIndex = 19;
            this.picLineaS2.TabStop = false;

            // 
            // picDeltaS
            // 
            this.picDeltaS.Image = global::SistEcuaciones.Properties.Resources.DeltaS;
            this.picDeltaS.Location = new System.Drawing.Point(6, 218);
            this.picDeltaS.Name = "picDeltaS";
            this.picDeltaS.Size = new System.Drawing.Size(96, 49);
            this.picDeltaS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeltaS.TabIndex = 16;
            this.picDeltaS.TabStop = false;
            // 
            // picDeltaY
            // 
            this.picDeltaY.Image = global::SistEcuaciones.Properties.Resources.DeltaY;
            this.picDeltaY.Location = new System.Drawing.Point(6, 129);
            this.picDeltaY.Name = "picDeltaY";
            this.picDeltaY.Size = new System.Drawing.Size(96, 49);
            this.picDeltaY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeltaY.TabIndex = 15;
            this.picDeltaY.TabStop = false;
            // 
            // picDeltaX
            // 
            this.picDeltaX.Image = global::SistEcuaciones.Properties.Resources.DeltaX;
            this.picDeltaX.Location = new System.Drawing.Point(6, 22);
            this.picDeltaX.Name = "picDeltaX";
            this.picDeltaX.Size = new System.Drawing.Size(96, 49);
            this.picDeltaX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeltaX.TabIndex = 14;
            this.picDeltaX.TabStop = false;

            #endregion
            
            mainScreen.Controls.Add(this.pnProcedimientos);



        }
        #endregion

        #region Métodos
        public void Imprimir(SistemaDeEcuaciones sistema)
        {
            //DELTA S
            lbS1.Text = sistema.e1.coefx.ToString();
            lbS2.Text = sistema.e2.coefx.ToString();
            lbS3.Text = sistema.e1.coefy.ToString();
            lbS4.Text = sistema.e2.coefy.ToString();
            lbS5.Text = $"= ({lbS1.Text} * {lbS4.Text}) - ({lbS2.Text} * {lbS3.Text}) = {sistema.deltasistema}";

            //DELTA X
            lbX1.Text = sistema.e1.coefindep.ToString();
            lbX2.Text = sistema.e2.coefindep.ToString();
            lbX3.Text = sistema.e1.coefy.ToString();
            lbX4.Text = sistema.e2.coefy.ToString();
            lbX5.Text = $"= ({lbX1.Text} * {lbX4.Text}) - ({lbX2.Text} * {lbX3.Text}) = {sistema.deltaX}";

            //DELTA Y
            lbY1.Text = sistema.e1.coefx.ToString();
            lbY2.Text = sistema.e2.coefx.ToString();
            lbY3.Text = sistema.e1.coefindep.ToString();
            lbY4.Text = sistema.e2.coefindep.ToString();
            lbY5.Text = $"= ({lbY1.Text} * {lbY4.Text}) - ({lbY2.Text} * {lbY3.Text}) = {sistema.deltaY}";

            //X
            lbSoluX1.Text = sistema.deltaX.ToString();
            lbSoluX2.Text = sistema.deltasistema.ToString();
            lbSolucionX.Text = $"= {sistema.solucionX}";

            //Y
            lbSoluY1.Text = sistema.deltaY.ToString();
            lbSoluY2.Text = sistema.deltasistema.ToString();
            lbSolucionY.Text = $"= {sistema.solucionY}";


            ProporcionControles();

        }
        
        public void Borrar()
        {
            mainScreen.Controls.Remove(pnProcedimientos);
        }

        public void ProporcionControles()
        {
            //Divido la pantalla principal en 4 espacio iguales.

            int espacio = (panelSize.Height / 4);


            #region PICS DELTA Y LINEAS HORIZONTALES

            picDeltaS.Location = new Point(0, ((espacio / 2) - (picDeltaS.Height / 2)));
            picDeltaX.Location = new Point(0, (picDeltaS.Location.Y + espacio));
            picDeltaY.Location = new Point(0, (picDeltaX.Location.Y + espacio));

            picLineaS2.Size = new Size(picLineaS2.Width, (panelSize.Width / 7));
            picLineaX2.Size = new Size(picLineaX2.Width, (panelSize.Width / 7));
            picLineaY2.Size = new Size(picLineaY2.Width, (panelSize.Width / 7));

            picLineaS1.Size = new Size(picLineaS2.Width, picLineaS2.Height);
            picLineaX1.Size = new Size(picLineaS2.Width, picLineaS2.Height);
            picLineaY1.Size = new Size(picLineaS2.Width, picLineaS2.Height);

            picLineaS2.Location = new Point((picDeltaS.Width + 3), ((espacio / 2) - (picLineaS2.Height / 2)));
            picLineaX2.Location = new Point((picDeltaX.Width + 3), (picLineaS2.Location.Y + espacio));
            picLineaY2.Location = new Point((picDeltaY.Width + 3), (picLineaX2.Location.Y + espacio));

            #endregion

            #region Controles DELTA S

            lbS1.Location = new Point((picLineaS2.Location.X + picLineaS2.Width + 3), picLineaS2.Location.Y);
            lbS2.Location = new Point(lbS1.Location.X, (picLineaS2.Location.Y + picLineaS2.Height) - lbS2.Height);

            if (this.lbS1.Width > this.lbS2.Width)
            {
                this.picFlechaS.Location = new Point((this.lbS1.Location.X + this.lbS1.Width + 5), picDeltaS.Location.Y);
            }
            else
            {
                this.picFlechaS.Location = new Point((this.lbS2.Location.X + this.lbS2.Width + 5), picDeltaS.Location.Y);
            }

            this.lbS3.Location = new Point((this.picFlechaS.Location.X + this.picFlechaS.Width + 4), lbS1.Location.Y);
            this.lbS4.Location = new Point((this.picFlechaS.Location.X + this.picFlechaS.Width + 4), lbS2.Location.Y);

            if (this.lbS3.Width > this.lbS4.Width)
            {
                this.picLineaS1.Location = new Point((this.lbS3.Location.X + this.lbS3.Width + 3), picLineaS2.Location.Y);
            }
            else
            {
                this.picLineaS1.Location = new Point((this.lbS4.Location.X + this.lbS4.Width + 3), picLineaS2.Location.Y);
            }

            this.lbS5.Location = new Point((this.picLineaS1.Width + this.picLineaS1.Location.X + 4), (picDeltaS.Location.Y + (picDeltaS.Height / 2) - (lbS5.Height / 2)));

            #endregion

            #region Controles DELTA X

            lbX1.Location = new Point((picLineaX2.Location.X + picLineaX2.Width + 3), picLineaX2.Location.Y);
            lbX2.Location = new Point(lbX1.Location.X, (picLineaX2.Location.Y + picLineaX2.Height) - lbX2.Height);

            if (this.lbX1.Width > this.lbX2.Width)
            {
                this.picFlechaX.Location = new Point((this.lbX1.Location.X + this.lbX1.Width + 5), picDeltaX.Location.Y);
            }
            else
            {
                this.picFlechaX.Location = new Point((this.lbX2.Location.X + this.lbX2.Width + 5), picDeltaX.Location.Y);
            }

            this.lbX3.Location = new Point((this.picFlechaX.Location.X + this.picFlechaX.Width + 4), lbX1.Location.Y);
            this.lbX4.Location = new Point((this.picFlechaX.Location.X + this.picFlechaX.Width + 4), lbX2.Location.Y);

            if (this.lbX3.Width > this.lbX4.Width)
            {
                this.picLineaX1.Location = new Point((this.lbX3.Location.X + this.lbX3.Width + 3), picLineaX2.Location.Y);
            }
            else
            {
                this.picLineaX1.Location = new Point((this.lbX4.Location.X + this.lbX4.Width + 3), picLineaX2.Location.Y);
            }

            this.lbX5.Location = new Point((this.picLineaX1.Width + this.picLineaX1.Location.X + 4), (picDeltaX.Location.Y + (picDeltaX.Height / 2) - (lbX5.Height / 2)));

            #endregion

            #region Controles DELTA Y

            lbY1.Location = new Point((picLineaY2.Location.X + picLineaY2.Width + 3), picLineaY2.Location.Y);
            lbY2.Location = new Point(lbY1.Location.X, (picLineaY2.Location.Y + picLineaY2.Height) - lbY2.Height);

            if (this.lbY1.Width > this.lbY2.Width)
            {
                this.picFlechaY.Location = new Point((this.lbY1.Location.X + this.lbY1.Width + 5), picDeltaY.Location.Y);
            }
            else
            {
                this.picFlechaY.Location = new Point((this.lbY2.Location.X + this.lbY2.Width + 5), picDeltaY.Location.Y);
            }

            this.lbY3.Location = new Point((this.picFlechaY.Location.X + this.picFlechaY.Width + 4), lbY1.Location.Y);
            this.lbY4.Location = new Point((this.picFlechaY.Location.X + this.picFlechaY.Width + 4), lbY2.Location.Y);

            if (this.lbY3.Width > this.lbY4.Width)
            {
                this.picLineaY1.Location = new Point((this.lbY3.Location.X + this.lbY3.Width + 3), picLineaY2.Location.Y);
            }
            else
            {
                this.picLineaY1.Location = new Point((this.lbY4.Location.X + this.lbY4.Width + 3), picLineaY2.Location.Y);
            }

            this.lbY5.Location = new Point((this.picLineaY1.Width + this.picLineaY1.Location.X + 4), (picDeltaY.Location.Y + (picDeltaY.Height / 2) - (lbY5.Height / 2)));

            #endregion

            #region SOLUCION X
            lbSoluX.Location = new Point(0,(picDeltaY.Location.Y + espacio));            
            picLineaHorizX.Location = new Point(lbSoluX.Width + 3, (lbSoluX.Location.Y + (lbSoluX.Height / 2)));

            if (this.lbSoluX1.Width > this.lbSoluX2.Width)
            {
                this.picLineaHorizX.Size = new Size((this.lbSoluX1.Width + 10), 9);
            }
            else
            {
                this.picLineaHorizX.Size = new Size((this.lbSoluX2.Width + 10), 9);
            }
            
            lbSoluX1.Location = new Point(picLineaHorizX.Location.X ,(picLineaHorizX.Location.Y - lbSoluX1.Height - 3));
            lbSoluX2.Location = new Point(lbSoluX1.Location.X,(picLineaHorizX.Location.Y + picLineaHorizX.Height + 3));

            this.lbSolucionX.Location = new Point((this.picLineaHorizX.Width + this.picLineaHorizX.Location.X + 5), (picLineaHorizX.Location.Y - (lbSolucionX.Height / 2)));
            #endregion

            #region SOLUCION Y

            lbSoluY.Location = new Point((panelSize.Width / 2), (picDeltaY.Location.Y + espacio));
            picLineaHorizY.Location = new Point(lbSoluY.Width + lbSoluY.Location.X + 3, (lbSoluY.Location.Y + (lbSoluY.Height / 2)));

            if (this.lbSoluY1.Width > this.lbSoluY2.Width)
            {
                this.picLineaHorizY.Size = new System.Drawing.Size((this.lbSoluY1.Width + 10), 9);
            }
            else
            {
                this.picLineaHorizY.Size = new System.Drawing.Size((this.lbSoluY2.Width + 10), 9);
            }

            lbSoluY1.Location = new Point(picLineaHorizY.Location.X, (picLineaHorizX.Location.Y - lbSoluY1.Height - 3));
            lbSoluY2.Location = new Point(lbSoluY1.Location.X, (picLineaHorizY.Location.Y + picLineaHorizY.Height + 3));

            this.lbSolucionY.Location = new Point((this.picLineaHorizY.Width + this.picLineaHorizY.Location.X + 5), (picLineaHorizY.Location.Y - (lbSolucionY.Height / 2)));
            #endregion


        }
        #endregion

    }
}
