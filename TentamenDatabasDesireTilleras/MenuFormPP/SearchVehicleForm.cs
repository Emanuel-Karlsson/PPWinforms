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

namespace MenuFormPP
{
    public partial class SearchVehicleForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public SearchVehicleForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }        

        private void btnSearchVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                string regnr = HelperClass.StringWash(txtLicensePlate.Text.ToUpper());
                var vehicle = HelperClass.BackEndIO.VehicleInfo(regnr);
                if (regnr != null)
                {                    
                    txtArrivalTime.Text = vehicle.ArrivalTime.ToString();
                    txtCost.Text = HelperClass.BackEndIO.PrintMoney(vehicle.Regnr);
                    txtParkingSpot.Text = vehicle.ParkingSpotNum.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot find vehicle.");

            }
        }

        private void BtnPreviousStep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearAllInfo_Click(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                var field = c as TextBox;
                if (field != null)
                {
                    field.Text = string.Empty;
                }
            }
            if (txtLicensePlate.CanFocus)
            {
                txtLicensePlate.Focus();
            }
        }

        private void btnCheckOutVehicle_Click(object sender, EventArgs e)
        {
            var checkout = new CheckOutForm();
            checkout.txtLicensePlate.Text = txtLicensePlate.Text;
            checkout.Show();            
            this.Close();            
        }

        private void SearchVehicleForm_Load(object sender, EventArgs e)
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
