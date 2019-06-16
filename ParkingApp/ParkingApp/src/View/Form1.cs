using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingApp.src.View;

namespace ParkingApp
{
	public partial class Form1 : Form
	{
        private AvailabilityScreen availabilityScreen;
        private SpotStatusScreen spotStatusScreen;
       
        public Form1()
		{
            InitializeComponent();
           

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void changeSlotsStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void slotsStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearView();
            if (spotStatusScreen == null)
                spotStatusScreen = new SpotStatusScreen(this);

        }

        private void availabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearView();  
            if (availabilityScreen==null)
            availabilityScreen = new AvailabilityScreen(this);
            


        }

        private void viewSlotsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void ClearView()
        {
            if (availabilityScreen != null)
            {
                availabilityScreen.ClearView();
                availabilityScreen = null;
            }

            if (spotStatusScreen != null)
            {
                spotStatusScreen.ClearView();
                spotStatusScreen = null;
            }
        }

    }
}
