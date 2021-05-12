
namespace MenuFormPP
{
    partial class lstView48h
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderEmpty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderParkingSpot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLicensePlate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVehicleType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHoursParked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEmpty,
            this.columnHeaderParkingSpot,
            this.columnHeaderLicensePlate,
            this.columnHeaderVehicleType,
            this.columnHeaderArrival,
            this.columnHeaderHoursParked});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(604, 321);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderEmpty
            // 
            this.columnHeaderEmpty.Text = "";
            this.columnHeaderEmpty.Width = 0;
            // 
            // columnHeaderParkingSpot
            // 
            this.columnHeaderParkingSpot.DisplayIndex = 0;
            this.columnHeaderParkingSpot.Text = "Parking Spot";
            this.columnHeaderParkingSpot.Width = 75;
            // 
            // columnHeaderLicensePlate
            // 
            this.columnHeaderLicensePlate.DisplayIndex = 1;
            this.columnHeaderLicensePlate.Text = "License Plate";
            this.columnHeaderLicensePlate.Width = 80;
            // 
            // columnHeaderVehicleType
            // 
            this.columnHeaderVehicleType.DisplayIndex = 2;
            this.columnHeaderVehicleType.Text = "Vehicle Type";
            this.columnHeaderVehicleType.Width = 75;
            // 
            // columnHeaderArrival
            // 
            this.columnHeaderArrival.DisplayIndex = 3;
            this.columnHeaderArrival.Text = "Arrival";
            this.columnHeaderArrival.Width = 120;
            // 
            // columnHeaderHoursParked
            // 
            this.columnHeaderHoursParked.DisplayIndex = 4;
            this.columnHeaderHoursParked.Text = "Hours Parked";
            this.columnHeaderHoursParked.Width = 80;
            // 
            // lstView48h
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 370);
            this.Controls.Add(this.listView1);
            this.Name = "lstView48h";
            this.Text = "Vehicles parked 48 hours";
            this.Load += new System.EventHandler(this.FortyEightHours_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderEmpty;
        private System.Windows.Forms.ColumnHeader columnHeaderParkingSpot;
        private System.Windows.Forms.ColumnHeader columnHeaderLicensePlate;
        private System.Windows.Forms.ColumnHeader columnHeaderVehicleType;
        private System.Windows.Forms.ColumnHeader columnHeaderArrival;
        private System.Windows.Forms.ColumnHeader columnHeaderHoursParked;
    }
}