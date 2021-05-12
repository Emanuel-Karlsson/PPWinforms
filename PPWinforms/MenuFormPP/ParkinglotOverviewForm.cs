using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MenuFormPP
{
    public partial class ParkinglotOverviewForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public ParkinglotOverviewForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void ParkinglotOverviewForm_Load(object sender, EventArgs e)
        {
            var list = HelperClass.BackEndIO.BEListAllSpots();
            string vehicleType;
            foreach (var vehicle in list)
            {
                var itm = new ListViewItem();
                itm.SubItems.Add(vehicle.ParkingSpotNum.ToString());
                itm.SubItems.Add(vehicle.Regnr);
                if (vehicle.VehicleType == 1)
                {
                    vehicleType = "MC";
                }
                else if (vehicle.VehicleType == 2)
                {
                    vehicleType = "CAR";
                }
                else
                {
                    vehicleType = "";
                }
                itm.SubItems.Add(vehicleType);
                if (list.Select(v => v.ParkingSpotNum).Where(x => x.Value == vehicle.ParkingSpotNum).Count() == 1 && vehicle.VehicleType == 1)
                {
                    itm.BackColor = Color.LightSkyBlue;
                }
                else if (vehicle.Regnr == "EMPTY")
                {
                    itm.BackColor = Color.LightGreen;
                }
                else
                {
                    itm.BackColor = Color.LightCoral;
                }
                listView1.Items.Add(itm);                
            }            
        }

        private void btnPreviousStep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            
        }
    }
}
