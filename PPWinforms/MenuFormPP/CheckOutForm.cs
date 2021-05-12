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
    
    public partial class CheckOutForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public CheckOutForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                string regNr = HelperClass.StringWash(txtLicensePlate.Text.ToUpper());
                if (regNr != null)
                {
                    if (radFreeOfCharge.Checked)
                    {
                        if (HelperClass.BackEndIO.BackEndCheckOutNoCost(regNr))
                        {

                            Vehicle checkedOutVehicle = new Vehicle(regNr);
                            checkedOutVehicle = HelperClass.BackEndIO.CheckOutInfo(regNr);
                            DateTime UpdatedTime = checkedOutVehicle.ArrivalTime ?? DateTime.Now;
                            TimeSpan span = DateTime.Now - UpdatedTime;
                            MessageBox.Show($"Vehicle {regNr} is now checked out from the parking.\n" +
                                $"Arrived at {checkedOutVehicle.ArrivalTime}\n" +
                                $"Checked out at {checkedOutVehicle.DepartureTime} \n" +
                                $"Parked for {span.Days} days ,{span.Hours} hours and {span.Minutes} minutes \n" +
                                $"Total cost {checkedOutVehicle.PricePaid} CZK" +
                                $"\n\nPress enter for main menu");
                        }
                        else
                        {
                            MessageBox.Show("Could not find vehicle in the parking lot.");
                        }
                    }
                    else
                    {
                        if (HelperClass.BackEndIO.BackEndCheckOut(regNr))
                        {
                            Vehicle checkedOutVehicle = new Vehicle(regNr);
                            checkedOutVehicle = HelperClass.BackEndIO.CheckOutInfo(regNr);
                            DateTime UpdatedTime = checkedOutVehicle.ArrivalTime ?? DateTime.Now;
                            TimeSpan span = DateTime.Now - UpdatedTime;
                            MessageBox.Show($"Vehicle {regNr} is now checked out from the parking.\n" +
                                $"Arrived at {checkedOutVehicle.ArrivalTime}\n" +
                                $"Checked out at {checkedOutVehicle.DepartureTime} \n" +
                                $"Parked for {span.Days} days ,{span.Hours} hours and {span.Minutes} minutes \n" +
                                $"Total cost {checkedOutVehicle.PricePaid} CZK" +
                                $"\n\nPress enter for main menu");
                        }
                        else
                        {
                            MessageBox.Show("Could not find vehicle in the parking lot.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input.");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            

            txtLicensePlate.Text = string.Empty;
            radFreeOfCharge.Checked = false;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLicensePlate.Text = string.Empty;
            radFreeOfCharge.Checked = false;
            if (txtLicensePlate.CanFocus)
            {
                txtLicensePlate.Focus();
            }
        }

        private void btnPreviousStep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
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
