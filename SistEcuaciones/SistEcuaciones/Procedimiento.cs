using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistEcuaciones
{
    class Procedimiento
    {
        #region Controles
        Panel mainScreen;
        Panel pnProcedimientos;
        Label lbS5;
        Label lbX5;
        Label lbY5;
        Label lbSolucion;
        Label lbSolucionY;
        Label lbSolucionX;
        Label lbSoluY2;
        Label lbSoluY1;
        Label lbSoluX2;
        Label lbSoluX1;
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
        PictureBox picLineaY;
        PictureBox picLineaX;
        PictureBox picLineaS;

        Button btnInfo;
        Panel pnInfo;
        Button btnCerrarInfo;
        #endregion

        #region Constructor
        public Procedimiento(Panel mainScreen)
        {
            this.mainScreen = mainScreen;
            this.pnInfo = new System.Windows.Forms.Panel();
            this.btnCerrarInfo = new System.Windows.Forms.Button();
            this.pnProcedimientos = new System.Windows.Forms.Panel();            
            this.btnInfo = new System.Windows.Forms.Button();
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
            this.lbSolucionX = new System.Windows.Forms.Label();
            this.lbSolucionY = new System.Windows.Forms.Label();
            this.lbSolucion = new System.Windows.Forms.Label();
            this.lbY5 = new System.Windows.Forms.Label();
            this.lbX5 = new System.Windows.Forms.Label();
            this.lbS5 = new System.Windows.Forms.Label();
            this.picLineaHorizY = new System.Windows.Forms.PictureBox();
            this.picLineaHorizX = new System.Windows.Forms.PictureBox();
            this.picFlechaY = new System.Windows.Forms.PictureBox();
            this.picFlechaX = new System.Windows.Forms.PictureBox();
            this.picFlechaS = new System.Windows.Forms.PictureBox();
            this.picLineaY = new System.Windows.Forms.PictureBox();
            this.picLineaX = new System.Windows.Forms.PictureBox();
            this.picLineaS = new System.Windows.Forms.PictureBox();
            this.pnProcedimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLineaHorizY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineaHorizX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlechaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlechaX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlechaS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineaX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineaS)).BeginInit();

            // 
            // pnProcedimientos
            // 
            this.pnProcedimientos.Controls.Add(this.lbS5);
            this.pnProcedimientos.Controls.Add(this.lbX5);
            this.pnProcedimientos.Controls.Add(this.lbY5);
            this.pnProcedimientos.Controls.Add(this.lbSolucion);
            this.pnProcedimientos.Controls.Add(this.lbSolucionY);
            this.pnProcedimientos.Controls.Add(this.lbSolucionX);
            this.pnProcedimientos.Controls.Add(this.lbSoluY2);
            this.pnProcedimientos.Controls.Add(this.lbSoluY1);
            this.pnProcedimientos.Controls.Add(this.lbSoluX2);
            this.pnProcedimientos.Controls.Add(this.lbSoluX1);
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
            this.pnProcedimientos.Controls.Add(this.picLineaY);
            this.pnProcedimientos.Controls.Add(this.picLineaX);
            this.pnProcedimientos.Controls.Add(this.picLineaS);
            this.pnProcedimientos.Controls.Add(this.btnInfo);
            this.pnProcedimientos.BackgroundImage = global::SistEcuaciones.Properties.Resources.Background_Procedimiento1;
            this.pnProcedimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProcedimientos.Location = new System.Drawing.Point(250, 0);
            this.pnProcedimientos.Name = "pnInfo";
            this.pnProcedimientos.Size = new System.Drawing.Size(1150, 900);
            this.pnProcedimientos.TabIndex = 1;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(203)))), ((int)(((byte)(250)))));
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = global::SistEcuaciones.Properties.Resources.info_50px;
            this.btnInfo.Location = new System.Drawing.Point(6, 827);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(50, 50);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);

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
            this.picLineaS.BackColor = System.Drawing.Color.Transparent;
            this.picLineaS.Image = global::SistEcuaciones.Properties.Resources.Linea_Vertical;
            this.picLineaS.Location = new System.Drawing.Point(340, 6);
            this.picLineaS.Name = "picLineaS";
            this.picLineaS.Size = new System.Drawing.Size(9, 143);
            this.picLineaS.TabIndex = 0;
            this.picLineaS.TabStop = false;
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
            this.picLineaX.BackColor = System.Drawing.Color.Transparent;
            this.picLineaX.Image = global::SistEcuaciones.Properties.Resources.Linea_Vertical;
            this.picLineaX.Location = new System.Drawing.Point(350, 214);
            this.picLineaX.Name = "picLineaX";
            this.picLineaX.Size = new System.Drawing.Size(9, 143);
            this.picLineaX.TabIndex = 1;
            this.picLineaX.TabStop = false;
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
            this.picLineaY.BackColor = System.Drawing.Color.Transparent;
            this.picLineaY.Image = global::SistEcuaciones.Properties.Resources.Linea_Vertical;
            this.picLineaY.Location = new System.Drawing.Point(305, 435);
            this.picLineaY.Name = "picLineaY";
            this.picLineaY.Size = new System.Drawing.Size(9, 143);
            this.picLineaY.TabIndex = 0;
            this.picLineaY.TabStop = false;
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

            // 
            // lbSolucion
            // 
            this.lbSolucion.AutoSize = true;
            this.lbSolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(203)))), ((int)(((byte)(250)))));
            this.lbSolucion.Font = new System.Drawing.Font("Bebas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(47)))), ((int)(((byte)(157)))));
            this.lbSolucion.Location = new System.Drawing.Point(410, 801);
            this.lbSolucion.Name = "lbSolucion";
            this.lbSolucion.Size = new System.Drawing.Size(306, 63);
            this.lbSolucion.TabIndex = 21;
            this.lbSolucion.Text = "S=(-2,2 ; 4,44)";

            #region PANEL INFORMACION
            // 
            // pnInfo
            // 
            this.pnInfo.BackgroundImage = global::SistEcuaciones.Properties.Resources.pnInfoProcedimientos;
            this.pnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnInfo.Controls.Add(this.btnCerrarInfo);
            this.pnInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnInfo.Location = new System.Drawing.Point(0, 600);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(1150, 200);
            this.pnInfo.TabIndex = 14;
            this.pnInfo.Visible = false;
            // 
            // btnCerrarInfo
            // 
            this.btnCerrarInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrarInfo.FlatAppearance.BorderSize = 0;
            this.btnCerrarInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCerrarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarInfo.Image = global::SistEcuaciones.Properties.Resources.close_window_30px;
            this.btnCerrarInfo.Location = new System.Drawing.Point(23, 17);
            this.btnCerrarInfo.Name = "btnCerrarInfo";
            this.btnCerrarInfo.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarInfo.TabIndex = 9;
            this.btnCerrarInfo.UseVisualStyleBackColor = false;
            this.btnCerrarInfo.Click += new System.EventHandler(this.btnCerrarInfo_Click);
            #endregion

            mainScreen.Controls.Add(this.pnProcedimientos);
            mainScreen.Controls.Add(this.pnInfo);
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

            //SOLUCION
            lbSolucion.Text = sistema.solucion.ToString();

            ReacomodarControles();

        }
        private void ReacomodarControles()
        {
            #region Controles DELTA S
            if (this.lbS1.Width > this.lbS2.Width)
            {
                this.picFlechaS.Location = new System.Drawing.Point((this.lbS1.Location.X + this.lbS1.Width + 5), 54);
            }
            else
            {
                this.picFlechaS.Location = new System.Drawing.Point((this.lbS2.Location.X + this.lbS2.Width + 5), 54);
            }
            this.lbS3.Location = new System.Drawing.Point((this.picFlechaS.Location.X + this.picFlechaS.Width + 4), 16);
            this.lbS4.Location = new System.Drawing.Point((this.picFlechaS.Location.X + this.picFlechaS.Width + 4), 106);
            if (this.lbS3.Width > this.lbS4.Width)
            {
                this.picLineaS.Location = new System.Drawing.Point((this.lbS3.Location.X + this.lbS3.Width + 3), 6);
            }
            else
            {
                this.picLineaS.Location = new System.Drawing.Point((this.lbS4.Location.X + this.lbS4.Width + 3), 6);
            }
            this.lbS5.Location = new System.Drawing.Point((this.picLineaS.Width + this.picLineaS.Location.X + 4), 54);
            #endregion

            #region Controles DELTA X
            if (this.lbX1.Width > this.lbX2.Width)
            {
                this.picFlechaX.Location = new System.Drawing.Point((this.lbX1.Location.X + this.lbX1.Width + 5), 259);
            }
            else
            {
                this.picFlechaX.Location = new System.Drawing.Point((this.lbX2.Location.X + this.lbX2.Width + 5), 259);
            }
            this.lbX3.Location = new System.Drawing.Point((this.picFlechaX.Location.X + this.picFlechaX.Width + 4), 219);
            this.lbX4.Location = new System.Drawing.Point((this.picFlechaX.Location.X + this.picFlechaX.Width + 4), 309);
            if (this.lbX3.Width > this.lbX4.Width)
            {
                this.picLineaX.Location = new System.Drawing.Point((this.lbX3.Location.X + this.lbX3.Width + 3), 214);
            }
            else
            {
                this.picLineaX.Location = new System.Drawing.Point((this.lbX4.Location.X + this.lbX4.Width + 3), 214);
            }
            this.lbX5.Location = new System.Drawing.Point((this.picLineaX.Width + this.picLineaX.Location.X + 4), 264);
            #endregion

            #region Controles DELTA Y
            if (this.lbY1.Width > this.lbY2.Width)
            {
                this.picFlechaY.Location = new System.Drawing.Point((this.lbY1.Location.X + this.lbY1.Width + 5), 480);
            }
            else
            {
                this.picFlechaY.Location = new System.Drawing.Point((this.lbY2.Location.X + this.lbY2.Width + 5), 480);
            }
            this.lbY3.Location = new System.Drawing.Point((this.picFlechaY.Location.X + this.picFlechaY.Width + 4), 442);
            this.lbY4.Location = new System.Drawing.Point((this.picFlechaY.Location.X + this.picFlechaY.Width + 4), 532);
            if (this.lbY3.Width >= this.lbY4.Width)
            {
                this.picLineaY.Location = new System.Drawing.Point((this.lbY3.Location.X + this.lbY3.Width), 435);
            }
            else
            {
                this.picLineaY.Location = new System.Drawing.Point((this.lbY4.Location.X + this.lbY4.Width), 435);
            }
            this.lbY5.Location = new System.Drawing.Point((this.picLineaY.Width + this.picLineaY.Location.X + 4), 485);

            #endregion

            #region Controles SOLUCION X
            if (this.lbSoluX1.Width > this.lbSoluX2.Width)
            {
                this.picLineaHorizX.Size = new System.Drawing.Size((this.lbSoluX1.Width + 10), 9);
            }
            else
            {
                this.picLineaHorizX.Size = new System.Drawing.Size((this.lbSoluX2.Width + 10), 9);
            }
            this.lbSolucionX.Location = new System.Drawing.Point((this.picLineaHorizX.Width + this.picLineaHorizX.Location.X + 5), 711);

            #endregion

            #region Controles SOLUCION Y
            if (this.lbSoluY1.Width > this.lbSoluY2.Width)
            {
                this.picLineaHorizY.Size = new System.Drawing.Size((this.lbSoluY1.Width + 10), 9);
            }
            else
            {
                this.picLineaHorizY.Size = new System.Drawing.Size((this.lbSoluY2.Width + 10), 9);
            }
            this.lbSolucionY.Location = new System.Drawing.Point((this.picLineaHorizY.Width + this.picLineaHorizY.Location.X + 5), 711);
            #endregion
        }
        public void Borrar()
        {
            mainScreen.Controls.Remove(pnProcedimientos);
            mainScreen.Controls.Remove(pnInfo);
        }
        #endregion

        #region Funcion Botones
        private void btnCerrarInfo_Click(object sender, EventArgs e)
        {
            pnInfo.Visible = false;

        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            pnInfo.Visible = true;

        }
        #endregion

    }
}
