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
    public partial class EconomyForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public EconomyForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void radBetweenDates_CheckedChanged(object sender, EventArgs e)
        {
            lblFirstDate.Visible = true;
            dateTimePicker1.Visible = true;
            lblSecondDate.Visible = true;
            dateTimePicker2.Visible = true;
            lblIncomeResult.Text = string.Empty;
            
        }

        private void radSpecificDay_CheckedChanged(object sender, EventArgs e)
        {

            lblSecondDate.Visible = false;
            dateTimePicker2.Visible = false;
            lblIncomeResult.Text = string.Empty;
        }

        private void radAverageIncome_CheckedChanged(object sender, EventArgs e)
        {
            lblFirstDate.Visible = false;
            dateTimePicker1.Visible = false;
            lblSecondDate.Visible = false;
            dateTimePicker2.Visible = false;
            lblIncomeResult.Text = string.Empty;

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string income;
            int income2;
            if (radSpecificDay.Checked)
            {
                try
                {
                    //income = HelperClass.BackEndIO.MoneySpecDay(DateTime.Parse(txtFirstDate.Text));
                    income = HelperClass.BackEndIO.MoneySpecDay(DateTime.Parse(dateTimePicker1.Text));
                    lblIncomeResult.Text = income;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
            else if (radBetweenDates.Checked)
            {
                income2 = HelperClass.BackEndIO.MoneyBetwDates(DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dateTimePicker2.Text));
                lblIncomeResult.Text = $"Average income: {income2.ToString()}";
            }           
            
        }
    }
}
