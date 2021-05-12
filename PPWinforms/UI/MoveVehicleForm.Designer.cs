
namespace UI
{
    partial class MoveVehicleForm
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
            this.lblExample = new System.Windows.Forms.Label();
            this.btnMoveVehicle = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPreviousStep = new System.Windows.Forms.Button();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lblRegNum = new System.Windows.Forms.Label();
            this.lblAvailableSpots = new System.Windows.Forms.Label();
            this.lstAvailableParkingSpots = new System.Windows.Forms.ListBox();
            this.btnFindParkingSlots = new System.Windows.Forms.Button();
            this.lblLicensePlate1 = new System.Windows.Forms.Label();
            this.lblArrivalTime1 = new System.Windows.Forms.Label();
            this.lblNowOnSpot1 = new System.Windows.Forms.Label();
            this.lblLicensePlate2 = new System.Windows.Forms.Label();
            this.lblArrivalTime2 = new System.Windows.Forms.Label();
            this.lblNowOnSpot2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Location = new System.Drawing.Point(19, 49);
            this.lblExample.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(74, 13);
            this.lblExample.TabIndex = 23;
            this.lblExample.Text = "Ex: \"ABC123\"";
            // 
            // btnMoveVehicle
            // 
            this.btnMoveVehicle.Location = new System.Drawing.Point(233, 326);
            this.btnMoveVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveVehicle.Name = "btnMoveVehicle";
            this.btnMoveVehicle.Size = new System.Drawing.Size(110, 27);
            this.btnMoveVehicle.TabIndex = 3;
            this.btnMoveVehicle.Text = "Move vehicle";
            this.btnMoveVehicle.UseVisualStyleBackColor = true;
            this.btnMoveVehicle.Click += new System.EventHandler(this.btnMoveVehicle_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(135, 326);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear all info";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPreviousStep
            // 
            this.btnPreviousStep.Location = new System.Drawing.Point(10, 326);
            this.btnPreviousStep.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreviousStep.Name = "btnPreviousStep";
            this.btnPreviousStep.Size = new System.Drawing.Size(82, 27);
            this.btnPreviousStep.TabIndex = 5;
            this.btnPreviousStep.Text = "Prevous step";
            this.btnPreviousStep.UseVisualStyleBackColor = true;
            this.btnPreviousStep.Click += new System.EventHandler(this.btnPreviousStep_Click);
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(21, 66);
            this.txtLicensePlate.Margin = new System.Windows.Forms.Padding(2);
            this.txtLicensePlate.MaxLength = 10;
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(114, 20);
            this.txtLicensePlate.TabIndex = 0;
            this.txtLicensePlate.TextChanged += new System.EventHandler(this.txtLicensePlate_TextChanged);
            // 
            // lblRegNum
            // 
            this.lblRegNum.AutoSize = true;
            this.lblRegNum.Location = new System.Drawing.Point(19, 28);
            this.lblRegNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new System.Drawing.Size(73, 13);
            this.lblRegNum.TabIndex = 18;
            this.lblRegNum.Text = "License plate:";
            // 
            // lblAvailableSpots
            // 
            this.lblAvailableSpots.AutoSize = true;
            this.lblAvailableSpots.Location = new System.Drawing.Point(20, 123);
            this.lblAvailableSpots.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableSpots.Name = "lblAvailableSpots";
            this.lblAvailableSpots.Size = new System.Drawing.Size(122, 13);
            this.lblAvailableSpots.TabIndex = 25;
            this.lblAvailableSpots.Text = "Available Parking Spots:";
            // 
            // lstAvailableParkingSpots
            // 
            this.lstAvailableParkingSpots.FormattingEnabled = true;
            this.lstAvailableParkingSpots.Location = new System.Drawing.Point(21, 139);
            this.lstAvailableParkingSpots.Name = "lstAvailableParkingSpots";
            this.lstAvailableParkingSpots.Size = new System.Drawing.Size(120, 95);
            this.lstAvailableParkingSpots.TabIndex = 2;
            // 
            // btnFindParkingSlots
            // 
            this.btnFindParkingSlots.Location = new System.Drawing.Point(207, 62);
            this.btnFindParkingSlots.Name = "btnFindParkingSlots";
            this.btnFindParkingSlots.Size = new System.Drawing.Size(99, 33);
            this.btnFindParkingSlots.TabIndex = 1;
            this.btnFindParkingSlots.Text = "Find parking slots";
            this.btnFindParkingSlots.UseVisualStyleBackColor = true;
            this.btnFindParkingSlots.Click += new System.EventHandler(this.btnFindParkingSlots_Click);
            // 
            // lblLicensePlate1
            // 
            this.lblLicensePlate1.AutoSize = true;
            this.lblLicensePlate1.Location = new System.Drawing.Point(204, 139);
            this.lblLicensePlate1.Name = "lblLicensePlate1";
            this.lblLicensePlate1.Size = new System.Drawing.Size(74, 13);
            this.lblLicensePlate1.TabIndex = 28;
            this.lblLicensePlate1.Text = "License Plate:";
            // 
            // lblArrivalTime1
            // 
            this.lblArrivalTime1.AutoSize = true;
            this.lblArrivalTime1.Location = new System.Drawing.Point(204, 160);
            this.lblArrivalTime1.Name = "lblArrivalTime1";
            this.lblArrivalTime1.Size = new System.Drawing.Size(65, 13);
            this.lblArrivalTime1.TabIndex = 29;
            this.lblArrivalTime1.Text = "Arrival Time:";
            // 
            // lblNowOnSpot1
            // 
            this.lblNowOnSpot1.AutoSize = true;
            this.lblNowOnSpot1.Location = new System.Drawing.Point(204, 183);
            this.lblNowOnSpot1.Name = "lblNowOnSpot1";
            this.lblNowOnSpot1.Size = new System.Drawing.Size(74, 13);
            this.lblNowOnSpot1.TabIndex = 30;
            this.lblNowOnSpot1.Text = "Now On Spot:";
            // 
            // lblLicensePlate2
            // 
            this.lblLicensePlate2.AutoSize = true;
            this.lblLicensePlate2.Location = new System.Drawing.Point(281, 139);
            this.lblLicensePlate2.Name = "lblLicensePlate2";
            this.lblLicensePlate2.Size = new System.Drawing.Size(0, 13);
            this.lblLicensePlate2.TabIndex = 31;
            // 
            // lblArrivalTime2
            // 
            this.lblArrivalTime2.AutoSize = true;
            this.lblArrivalTime2.Location = new System.Drawing.Point(281, 160);
            this.lblArrivalTime2.Name = "lblArrivalTime2";
            this.lblArrivalTime2.Size = new System.Drawing.Size(0, 13);
            this.lblArrivalTime2.TabIndex = 32;
            // 
            // lblNowOnSpot2
            // 
            this.lblNowOnSpot2.AutoSize = true;
            this.lblNowOnSpot2.Location = new System.Drawing.Point(281, 183);
            this.lblNowOnSpot2.Name = "lblNowOnSpot2";
            this.lblNowOnSpot2.Size = new System.Drawing.Size(0, 13);
            this.lblNowOnSpot2.TabIndex = 33;
            // 
            // MoveVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblNowOnSpot2);
            this.Controls.Add(this.lblArrivalTime2);
            this.Controls.Add(this.lblLicensePlate2);
            this.Controls.Add(this.lblNowOnSpot1);
            this.Controls.Add(this.lblArrivalTime1);
            this.Controls.Add(this.lblLicensePlate1);
            this.Controls.Add(this.btnFindParkingSlots);
            this.Controls.Add(this.lstAvailableParkingSpots);
            this.Controls.Add(this.lblAvailableSpots);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.btnMoveVehicle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPreviousStep);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.lblRegNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MoveVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Move Vehicle";
            this.Load += new System.EventHandler(this.MoveVehicleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.Button btnMoveVehicle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPreviousStep;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lblRegNum;
        private System.Windows.Forms.Label lblAvailableSpots;
        private System.Windows.Forms.ListBox lstAvailableParkingSpots;
        private System.Windows.Forms.Button btnFindParkingSlots;
        private System.Windows.Forms.Label lblLicensePlate1;
        private System.Windows.Forms.Label lblArrivalTime1;
        private System.Windows.Forms.Label lblNowOnSpot1;
        private System.Windows.Forms.Label lblLicensePlate2;
        private System.Windows.Forms.Label lblArrivalTime2;
        private System.Windows.Forms.Label lblNowOnSpot2;
    }
}