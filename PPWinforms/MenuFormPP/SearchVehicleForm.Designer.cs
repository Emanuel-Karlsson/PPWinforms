
namespace UI
{
    partial class SearchVehicleForm
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
            this.lblParkingSpot = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCheckInTime = new System.Windows.Forms.Label();
            this.txtParkingSpot = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtArrivalTime = new System.Windows.Forms.TextBox();
            this.btnClearAllInfo = new System.Windows.Forms.Button();
            this.BtnPreviousStep = new System.Windows.Forms.Button();
            this.btnCheckOutVehicle = new System.Windows.Forms.Button();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.btnSearchVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblParkingSpot
            // 
            this.lblParkingSpot.AutoSize = true;
            this.lblParkingSpot.Location = new System.Drawing.Point(33, 180);
            this.lblParkingSpot.Name = "lblParkingSpot";
            this.lblParkingSpot.Size = new System.Drawing.Size(68, 13);
            this.lblParkingSpot.TabIndex = 49;
            this.lblParkingSpot.Text = "Parking Spot";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(33, 128);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 48;
            this.lblCost.Text = "Cost";
            // 
            // lblCheckInTime
            // 
            this.lblCheckInTime.AutoSize = true;
            this.lblCheckInTime.Location = new System.Drawing.Point(30, 73);
            this.lblCheckInTime.Name = "lblCheckInTime";
            this.lblCheckInTime.Size = new System.Drawing.Size(76, 13);
            this.lblCheckInTime.TabIndex = 47;
            this.lblCheckInTime.Text = "Check In Time";
            // 
            // txtParkingSpot
            // 
            this.txtParkingSpot.Enabled = false;
            this.txtParkingSpot.Location = new System.Drawing.Point(33, 196);
            this.txtParkingSpot.Name = "txtParkingSpot";
            this.txtParkingSpot.Size = new System.Drawing.Size(124, 20);
            this.txtParkingSpot.TabIndex = 45;
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(33, 144);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(124, 20);
            this.txtCost.TabIndex = 44;
            // 
            // txtArrivalTime
            // 
            this.txtArrivalTime.Enabled = false;
            this.txtArrivalTime.Location = new System.Drawing.Point(33, 89);
            this.txtArrivalTime.Name = "txtArrivalTime";
            this.txtArrivalTime.Size = new System.Drawing.Size(124, 20);
            this.txtArrivalTime.TabIndex = 43;
            // 
            // btnClearAllInfo
            // 
            this.btnClearAllInfo.Location = new System.Drawing.Point(125, 332);
            this.btnClearAllInfo.Name = "btnClearAllInfo";
            this.btnClearAllInfo.Size = new System.Drawing.Size(75, 23);
            this.btnClearAllInfo.TabIndex = 3;
            this.btnClearAllInfo.Text = "Clear all info";
            this.btnClearAllInfo.UseVisualStyleBackColor = true;
            this.btnClearAllInfo.Click += new System.EventHandler(this.btnClearAllInfo_Click);
            // 
            // BtnPreviousStep
            // 
            this.BtnPreviousStep.Location = new System.Drawing.Point(8, 332);
            this.BtnPreviousStep.Name = "BtnPreviousStep";
            this.BtnPreviousStep.Size = new System.Drawing.Size(95, 23);
            this.BtnPreviousStep.TabIndex = 4;
            this.BtnPreviousStep.Text = "Previous Step";
            this.BtnPreviousStep.UseVisualStyleBackColor = true;
            this.BtnPreviousStep.Click += new System.EventHandler(this.BtnPreviousStep_Click);
            // 
            // btnCheckOutVehicle
            // 
            this.btnCheckOutVehicle.Location = new System.Drawing.Point(221, 332);
            this.btnCheckOutVehicle.Name = "btnCheckOutVehicle";
            this.btnCheckOutVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOutVehicle.TabIndex = 2;
            this.btnCheckOutVehicle.Text = "Check Out Vehicle";
            this.btnCheckOutVehicle.UseVisualStyleBackColor = true;
            this.btnCheckOutVehicle.Click += new System.EventHandler(this.btnCheckOutVehicle_Click);
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Location = new System.Drawing.Point(30, 23);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(73, 13);
            this.lblLicensePlate.TabIndex = 36;
            this.lblLicensePlate.Text = "License plate:";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(33, 39);
            this.txtLicensePlate.MaxLength = 10;
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(124, 20);
            this.txtLicensePlate.TabIndex = 0;
            this.txtLicensePlate.TextChanged += new System.EventHandler(this.txtLicensePlate_TextChanged);
            // 
            // btnSearchVehicle
            // 
            this.btnSearchVehicle.Location = new System.Drawing.Point(169, 37);
            this.btnSearchVehicle.Name = "btnSearchVehicle";
            this.btnSearchVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnSearchVehicle.TabIndex = 1;
            this.btnSearchVehicle.Text = "Search";
            this.btnSearchVehicle.UseVisualStyleBackColor = true;
            this.btnSearchVehicle.Click += new System.EventHandler(this.btnSearchVehicle_Click);
            // 
            // SearchVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnSearchVehicle);
            this.Controls.Add(this.lblParkingSpot);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblCheckInTime);
            this.Controls.Add(this.txtParkingSpot);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtArrivalTime);
            this.Controls.Add(this.btnClearAllInfo);
            this.Controls.Add(this.BtnPreviousStep);
            this.Controls.Add(this.btnCheckOutVehicle);
            this.Controls.Add(this.lblLicensePlate);
            this.Controls.Add(this.txtLicensePlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SearchVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Vehicle";
            this.Load += new System.EventHandler(this.SearchVehicleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParkingSpot;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblCheckInTime;
        private System.Windows.Forms.TextBox txtParkingSpot;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtArrivalTime;
        private System.Windows.Forms.Button btnClearAllInfo;
        private System.Windows.Forms.Button BtnPreviousStep;
        private System.Windows.Forms.Button btnCheckOutVehicle;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Button btnSearchVehicle;
    }
}