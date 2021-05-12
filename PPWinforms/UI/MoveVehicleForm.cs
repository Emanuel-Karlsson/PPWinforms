using BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MoveVehicleForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public MoveVehicleForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        private void btnFindParkingSlots_Click(object sender, EventArgs e)
        {
            try
            {
                string regNr = HelperClass.StringWash(txtLicensePlate.Text);                
                var vehicle = HelperClass.BackEndIO.VehicleInfo(regNr);
                lblLicensePlate2.Text = vehicle.Regnr;
                lblArrivalTime2.Text = vehicle.ArrivalTime.ToString();
                lblNowOnSpot2.Text = vehicle.ParkingSpotNum.ToString();

                lstAvailableParkingSpots.DataSource = ListFreeSpots(vehicle.VehicleType);

            }
            catch (Exception)            
            {

                MessageBox.Show("Could not find vehicle.");
            }
        }
        private void btnPreviousStep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLicensePlate.Text = string.Empty;
            lstAvailableParkingSpots.DataSource = null;
            lblArrivalTime2.Text = string.Empty;
            lblLicensePlate2.Text = string.Empty;
            lblNowOnSpot2.Text = string.Empty;
            if (txtLicensePlate.CanFocus)
            {
                txtLicensePlate.Focus();
            }
        }
        private void btnMoveVehicle_Click(object sender, EventArgs e)
        {
            int newSpot = (int)lstAvailableParkingSpots.SelectedItem;
            string regNum = txtLicensePlate.Text;
            Vehicle vehicle = HelperClass.BackEndIO.VehicleInfo(regNum);
            if (HelperClass.BackEndIO.BackEndMoveVehicle(regNum, newSpot))
            {
                MessageBox.Show($"Vehicle moved to parking spot {newSpot}");
            }
            else
            {
                MessageBox.Show($"Could not move vehicle. Contact your sysadmin (Dessi).");
            }

            txtLicensePlate.Text = string.Empty;
            lstAvailableParkingSpots.DataSource = null;
            lblArrivalTime2.Text = string.Empty;
            lblLicensePlate2.Text = string.Empty;
            lblNowOnSpot2.Text = string.Empty;
        }
        public List<int> ListFreeSpots(int? vehicleType)
        {
            var availableSpots = new List<int>();
            try
            {              

                if (vehicleType == 1)
                {
                    //Available parking spots for MC's
                    availableSpots = HelperClass.BackEndIO.ListAllFreeSpotsMC();                    
                    
                }
                else if(vehicleType == 2)
                {
                    //Available parking spots for cars:");
                    availableSpots = HelperClass.BackEndIO.ListAllFreeSpotsCars();
                    
                }
                else
                {
                    MessageBox.Show("Could not find vehicle in the parking lot.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);              
                
            }
            return availableSpots;
        }

        private void MoveVehicleForm_Load(object sender, EventArgs e)
        {

        }

        private void txtLicensePlate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtLicensePlate.BackColor = HelperClass.ChangeLicensePlateTextBoxBackColor(txtLicensePlate.Text);
            }
            catch (Exception)
            {
                txtLicensePlate.BackColor = Color.LightCoral;
            }
        }
    }
}
