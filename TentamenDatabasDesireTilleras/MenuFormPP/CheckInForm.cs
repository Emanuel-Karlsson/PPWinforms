using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HemtentaDesireDatabaserPragueParking;

namespace MenuFormPP
{
    public partial class CheckInForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public CheckInForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnPreviousStep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLicensePlate.Text = string.Empty;
            radCar.Checked = false;
            radMC.Checked = false;
            if (txtLicensePlate.CanFocus)
            {
                txtLicensePlate.Focus();
            }
        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {     
            try
            {
                int vehicleType = 0;
                if (radCar.Checked)
                {
                    vehicleType = 1;
                }
                else if (radMC.Checked)
                {
                    vehicleType = 2;
                }
                
                string regnr = HelperClass.StringWash(txtLicensePlate.Text.ToUpper());
                if (regnr != null)
                {
                    if (vehicleType != 0)
                    {
                        var vehicle = HelperClass.BackEndIO.BackEndCheckIn(regnr, vehicleType);
                        txtLicensePlate.Text = string.Empty;
                        radCar.Checked = false;
                        radMC.Checked = false;
                        MessageBox.Show($"{vehicle.Regnr} successfully parked at parking spot {vehicle.ParkingSpotNum}.");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Vehicle type.");
                        
                    }
                }
                else
                {
                    MessageBox.Show("Invalid license plate.");
                    if (txtLicensePlate.CanFocus)
                    {
                        txtLicensePlate.Focus();
                    }
                }

            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void CheckInForm_Load(object sender, EventArgs e)
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
