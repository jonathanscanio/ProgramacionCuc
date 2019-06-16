namespace ParkingApp
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.slotsStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSlotsStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSlotsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseWaitCursor = true;
            // 
            // slotsStatusToolStripMenuItem
            // 
            this.slotsStatusToolStripMenuItem.Name = "slotsStatusToolStripMenuItem";
            this.slotsStatusToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.slotsStatusToolStripMenuItem.Text = "Spots Status";
            this.slotsStatusToolStripMenuItem.Click += new System.EventHandler(this.slotsStatusToolStripMenuItem_Click);
            // 
            // availabilityToolStripMenuItem
            // 
            this.availabilityToolStripMenuItem.Name = "availabilityToolStripMenuItem";
            this.availabilityToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.availabilityToolStripMenuItem.Text = "Availability";
            this.availabilityToolStripMenuItem.Click += new System.EventHandler(this.availabilityToolStripMenuItem_Click);
            // 
            // changeSlotsStatusToolStripMenuItem
            // 
            this.changeSlotsStatusToolStripMenuItem.Name = "changeSlotsStatusToolStripMenuItem";
            this.changeSlotsStatusToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.changeSlotsStatusToolStripMenuItem.Text = "Pay spot";
            this.changeSlotsStatusToolStripMenuItem.Click += new System.EventHandler(this.changeSlotsStatusToolStripMenuItem_Click);
            // 
            // viewSlotsHistoryToolStripMenuItem
            // 
            this.viewSlotsHistoryToolStripMenuItem.Name = "viewSlotsHistoryToolStripMenuItem";
            this.viewSlotsHistoryToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.viewSlotsHistoryToolStripMenuItem.Text = "Spots History";
            this.viewSlotsHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewSlotsHistoryToolStripMenuItem_Click);
            // 
            // viewBookingsToolStripMenuItem
            // 
            this.viewBookingsToolStripMenuItem.Name = "viewBookingsToolStripMenuItem";
            this.viewBookingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.viewBookingsToolStripMenuItem.Text = "Bookings";
            this.viewBookingsToolStripMenuItem.Click += new System.EventHandler(this.viewBookingsToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slotsStatusToolStripMenuItem,
            this.availabilityToolStripMenuItem,
            this.changeSlotsStatusToolStripMenuItem,
            this.viewSlotsHistoryToolStripMenuItem,
            this.viewBookingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Parking Lot App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem slotsStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSlotsStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSlotsHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

