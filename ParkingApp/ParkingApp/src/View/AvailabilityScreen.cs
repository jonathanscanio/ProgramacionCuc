using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingApp.src.Controller;

namespace ParkingApp.src.View
{
    class AvailabilityScreen
    {
        Form1 mainScreen;
        ComboBox availabilityOptions;
        ComboBox availabilityCriteria;
        Button getAvailabilityButton;
        AvailabilityController controller;
        DataGridView availabilityDataGrid;

        public AvailabilityScreen(Form1 mainScreen)
        {
            this.mainScreen = mainScreen;
            controller = new AvailabilityController();

            //Availability options
            availabilityOptions = new ComboBox();
            availabilityOptions.Items.AddRange(new object[] {"All Vehicle Types",
                        "Bike",
                        "Motorbike",
                        "Car",
                        "Van",
                         "Truck"});
            
            availabilityOptions.Location = new System.Drawing.Point(mainScreen.MainMenuStrip.Location.X+100,mainScreen.MainMenuStrip.Location.Y+50);
            availabilityOptions.Size = new System.Drawing.Size(mainScreen.Size.Height/5,mainScreen.Width/5);
            availabilityOptions.SelectedIndex = 0;
            availabilityOptions.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right);
            availabilityOptions.DropDownWidth = 160;
            mainScreen.Controls.Add(availabilityOptions);
            
            //Availability criteria
            availabilityCriteria = new ComboBox();
            availabilityCriteria.Items.AddRange(new object[] {
                        "Any Fit",
                        "Exact Fit"});

            availabilityCriteria.Location = new System.Drawing.Point(mainScreen.MainMenuStrip.Location.X + 400, mainScreen.MainMenuStrip.Location.Y + 50);
            availabilityCriteria.Size = new System.Drawing.Size(mainScreen.Size.Height / 5, mainScreen.Width / 5);
            availabilityCriteria.SelectedIndex = 0;
            availabilityCriteria.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right);
            availabilityCriteria.DropDownWidth = 160;
            mainScreen.Controls.Add(availabilityCriteria);

            //Get availability Button

            getAvailabilityButton = new Button();
            getAvailabilityButton.Text = "Get Availability";
            getAvailabilityButton. Location= new System.Drawing.Point(mainScreen.MainMenuStrip.Location.X + 700, mainScreen.MainMenuStrip.Location.Y + 50);
            getAvailabilityButton.Width = 160;
            mainScreen.Controls.Add(getAvailabilityButton);
            getAvailabilityButton.Click += new EventHandler(this.UpdateView);

            //Availabilty DataGrid
            availabilityDataGrid = new DataGridView(); 
            availabilityDataGrid.Location= new System.Drawing.Point(mainScreen.MainMenuStrip.Location.X + 100, mainScreen.MainMenuStrip.Location.Y + 100);
            availabilityDataGrid.Size = new System.Drawing.Size(mainScreen.Size.Width-500, mainScreen.Height-300);
            availabilityDataGrid.BackgroundColor = System.Drawing.Color.White;
            availabilityDataGrid.Columns.Add("SLOT","SLOT");
            availabilityDataGrid.Columns.Add("SPOT TYPE", "SPOT TYPE");
            availabilityDataGrid.Columns.Add("AVAILABLE UNTIL", "AVAILABLE UNTIL");
            foreach (DataGridViewColumn column in availabilityDataGrid.Columns)
            {
                column.Width = availabilityDataGrid.Width / availabilityDataGrid.Columns.Count;
            }
            mainScreen.Controls.Add(availabilityDataGrid);
            
        }

        //Populate availabily when button is clicked
        public void UpdateView(object sender, EventArgs e)
        {
            if (availabilityDataGrid.Rows.Count != 1)
            {
                
                foreach (DataGridViewRow row in availabilityDataGrid.Rows)
                {                   
                    availabilityDataGrid.Rows.Clear();
                }
            }
            List<AvailabilityDTO> availability = controller.GetAvailability(availabilityOptions.SelectedIndex,availabilityCriteria.Text);
            if(availability.Count!=0)
            availabilityDataGrid.Rows.Add(availability.Count-1);
            int rowNumber = 0;
            foreach (AvailabilityDTO dto in availability)
            {
                            
                availabilityDataGrid.Rows[rowNumber].Cells[0].Value = dto.Slot;
                availabilityDataGrid.Rows[rowNumber].Cells[1].Value = dto.SlotType;
                availabilityDataGrid.Rows[rowNumber].Cells[2].Value = dto.EndTime;
                rowNumber+= 1;
                
            }
        
        }

        public void ClearView()
        {
            mainScreen.Controls.Remove(availabilityOptions);
            mainScreen.Controls.Remove(availabilityCriteria);
            mainScreen.Controls.Remove(getAvailabilityButton);
            mainScreen.Controls.Remove(availabilityDataGrid);
        }



    }
}
