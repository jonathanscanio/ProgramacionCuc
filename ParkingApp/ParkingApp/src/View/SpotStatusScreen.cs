using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingApp.src.Controller;
using ParkingApp.src.DTO;

namespace ParkingApp.src.View
{
    class SpotStatusScreen
    {
        Form1 mainScreen;
        DataGridView spotStatusDataGrid;
        Button searchButton;
        ComboBox carTypeOptions;
        SpotStatusController controller= new SpotStatusController();

        public SpotStatusScreen(Form1 mainScreen)
        {
            this.mainScreen = mainScreen;

            //Availability options
            carTypeOptions = new ComboBox();
            carTypeOptions.Items.AddRange(new object[] {"All Vehicle Types",
                        "Bike",
                        "Motorbike",
                        "Car",
                        "Van",
                         "Truck"});

            carTypeOptions.Location = new System.Drawing.Point(mainScreen.MainMenuStrip.Location.X + 100, mainScreen.MainMenuStrip.Location.Y + 50);
            carTypeOptions.Size = new System.Drawing.Size(mainScreen.Size.Height / 5, mainScreen.Width / 5);
            carTypeOptions.SelectedIndex = 0;
            carTypeOptions.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right);
            carTypeOptions.DropDownWidth = 160;
            mainScreen.Controls.Add(carTypeOptions);

            //Search Button
            searchButton = new Button();
            searchButton.Text = "Search";
            searchButton.Location = new System.Drawing.Point(mainScreen.MainMenuStrip.Location.X + 700, mainScreen.MainMenuStrip.Location.Y + 50);
            searchButton.Width = 160;
            mainScreen.Controls.Add(searchButton);
            searchButton.Click += new EventHandler(this.UpdateView);
            
            //Spot Status grid
            spotStatusDataGrid = new DataGridView();
            spotStatusDataGrid.Location = new System.Drawing.Point(mainScreen.MainMenuStrip.Location.X + 100, mainScreen.MainMenuStrip.Location.Y + 100);
            spotStatusDataGrid.Size = new System.Drawing.Size(mainScreen.Size.Width - 300, mainScreen.Height - 300);
            spotStatusDataGrid.BackgroundColor = System.Drawing.Color.White;
            spotStatusDataGrid.Columns.Add("SPOT", "SPOT");
            spotStatusDataGrid.Columns.Add("SPOT TYPE", "SPOT TYPE");
            spotStatusDataGrid.Columns.Add("STATUS", "STATUS");
            spotStatusDataGrid.Columns.Add("VEHICLE LICENSE PLATE NUMBER", "VEHICLE LICENSE PLATE NUMBER");
            foreach (DataGridViewColumn column in spotStatusDataGrid.Columns)
            {
                column.Width = spotStatusDataGrid.Width / spotStatusDataGrid.Columns.Count;
            }
            mainScreen.Controls.Add(spotStatusDataGrid);


        }

        public void UpdateView(object sender, EventArgs e)
        {
            if (spotStatusDataGrid.Rows.Count != 1)
            {

                foreach (DataGridViewRow row in spotStatusDataGrid.Rows)
                {

                    spotStatusDataGrid.Rows.Clear();
                }
            }

            List<SpotStatusDTO> spotsStatus = controller.GetSpotsStatus(carTypeOptions.SelectedIndex);          
            if (spotsStatus.Count != 0)
                spotStatusDataGrid.Rows.Add(spotsStatus.Count - 1);
            int rowNumber = 0;
            foreach (SpotStatusDTO dto in spotsStatus)
            {
                spotStatusDataGrid.Rows[rowNumber].Cells[0].Value = dto.Slot;
                spotStatusDataGrid.Rows[rowNumber].Cells[1].Value = dto.SlotType;
                spotStatusDataGrid.Rows[rowNumber].Cells[2].Value = dto.Status;
                spotStatusDataGrid.Rows[rowNumber].Cells[3].Value = dto.LicensePlateNumber;
                rowNumber += 1;
            }
        }

        public void ClearView()
        {
            mainScreen.Controls.Remove(spotStatusDataGrid);
            mainScreen.Controls.Remove(searchButton);
            mainScreen.Controls.Remove(carTypeOptions);

        }
    }
}
