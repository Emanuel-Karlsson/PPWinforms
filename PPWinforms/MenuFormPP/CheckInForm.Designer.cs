
namespace UI
{
    partial class CheckInForm
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
            this.lblRegNum = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.radMC = new System.Windows.Forms.RadioButton();
            this.radCar = new System.Windows.Forms.RadioButton();
            this.btnPreviousStep = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.lblExample = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegNum
            // 
            this.lblRegNum.AutoSize = true;
            this.lblRegNum.Location = new System.Drawing.Point(24, 34);
            this.lblRegNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new System.Drawing.Size(73, 13);
            this.lblRegNum.TabIndex = 1;
            this.lblRegNum.Text = "License plate:";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(26, 72);
            this.txtLicensePlate.Margin = new System.Windows.Forms.Padding(2);
            this.txtLicensePlate.MaxLength = 10;
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(114, 20);
            this.txtLicensePlate.TabIndex = 0;
            this.txtLicensePlate.TextChanged += new System.EventHandler(this.txtLicensePlate_TextChanged);
            // 
            // radMC
            // 
            this.radMC.AutoSize = true;
            this.radMC.Location = new System.Drawing.Point(88, 145);
            this.radMC.Margin = new System.Windows.Forms.Padding(2);
            this.radMC.Name = "radMC";
            this.radMC.Size = new System.Drawing.Size(41, 17);
            this.radMC.TabIndex = 2;
            this.radMC.TabStop = true;
            this.radMC.Text = "MC";
            this.radMC.UseVisualStyleBackColor = true;
            // 
            // radCar
            // 
            this.radCar.AutoSize = true;
            this.radCar.Location = new System.Drawing.Point(26, 145);
            this.radCar.Margin = new System.Windows.Forms.Padding(2);
            this.radCar.Name = "radCar";
            this.radCar.Size = new System.Drawing.Size(41, 17);
            this.radCar.TabIndex = 1;
            this.radCar.TabStop = true;
            this.radCar.Text = "Car";
            this.radCar.UseVisualStyleBackColor = true;
            // 
            // btnPreviousStep
            // 
            this.btnPreviousStep.Location = new System.Drawing.Point(9, 319);
            this.btnPreviousStep.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreviousStep.Name = "btnPreviousStep";
            this.btnPreviousStep.Size = new System.Drawing.Size(82, 27);
            this.btnPreviousStep.TabIndex = 5;
            this.btnPreviousStep.Text = "Prevous step";
            this.btnPreviousStep.UseVisualStyleBackColor = true;
            this.btnPreviousStep.Click += new System.EventHandler(this.btnPreviousStep_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(134, 319);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear all info";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(232, 319);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(110, 27);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "Check in vehicle";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Location = new System.Drawing.Point(24, 128);
            this.lblVehicleType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(68, 13);
            this.lblVehicleType.TabIndex = 7;
            this.lblVehicleType.Text = "Vehicle type:";
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Location = new System.Drawing.Point(24, 55);
            this.lblExample.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(74, 13);
            this.lblExample.TabIndex = 8;
            this.lblExample.Text = "Ex: \"ABC123\"";
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPreviousStep);
            this.Controls.Add(this.radCar);
            this.Controls.Add(this.radMC);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.lblRegNum);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CheckInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckInForm";
            this.Load += new System.EventHandler(this.CheckInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegNum;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.RadioButton radMC;
        private System.Windows.Forms.RadioButton radCar;
        private System.Windows.Forms.Button btnPreviousStep;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Label lblExample;
    }
}