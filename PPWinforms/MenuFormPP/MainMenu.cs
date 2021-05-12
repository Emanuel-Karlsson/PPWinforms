using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MenuFormPP
{
    public partial class MainMenu : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public MainMenu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            var cif = new CheckInForm();
            //this.Hide();
            cif.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var cof = new CheckOutForm();
            //this.Hide();
            cof.Show();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            var mvf = new MoveVehicleForm();
            //this.Hide();
            mvf.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var sv = new SearchVehicleForm();
            //this.Hide();
            sv.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMcOpti_Click(object sender, EventArgs e)
        {
            try
            {
                lstMcOpti.Visible = true;
                btnCloseMcOptiList.Visible = true;
                var list = HelperClass.BackEndIO.BEOptimizeMC();
                lstMcOpti.DataSource = list;
                
                if (HelperClass.BackEndIO.BEOptimizeMC().Count == 0)
                {
                    MessageBox.Show("The parking is optimized!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCloseMcOptiList_Click(object sender, EventArgs e)
        {
            lstMcOpti.Visible = false;
            btnCloseMcOptiList.Visible = false;
        }

        private void btnParkingLotOverview_Click(object sender, EventArgs e)
        {
            var pof = new ParkinglotOverviewForm();
            pof.Show();
        }

        private void btnParked48h_Click(object sender, EventArgs e)
        {
            var f = new lstView48h();
            f.Show();
        }

        private void btnEconomy_Click(object sender, EventArgs e)
        {
            var ef = new EconomyForm();
            ef.Show();
        }
    } 
}
