
namespace MenuFormPP
{
    partial class CheckOutForm
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
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPreviousStep = new System.Windows.Forms.Button();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lblRegNum = new System.Windows.Forms.Label();
            this.radFreeOfCharge = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Location = new System.Drawing.Point(17, 49);
            this.lblExample.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(74, 13);
            this.lblExample.TabIndex = 17;
            this.lblExample.Text = "Ex: \"ABC123\"";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(230, 321);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(110, 27);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check out vehicle";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(132, 321);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear all info";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPreviousStep
            // 
            this.btnPreviousStep.Location = new System.Drawing.Point(7, 321);
            this.btnPreviousStep.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreviousStep.Name = "btnPreviousStep";
            this.btnPreviousStep.Size = new System.Drawing.Size(82, 27);
            this.btnPreviousStep.TabIndex = 4;
            this.btnPreviousStep.Text = "Prevous step";
            this.btnPreviousStep.UseVisualStyleBackColor = true;
            this.btnPreviousStep.Click += new System.EventHandler(this.btnPreviousStep_Click);
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(19, 66);
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
            this.lblRegNum.Location = new System.Drawing.Point(17, 28);
            this.lblRegNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new System.Drawing.Size(73, 13);
            this.lblRegNum.TabIndex = 9;
            this.lblRegNum.Text = "License plate:";
            // 
            // radFreeOfCharge
            // 
            this.radFreeOfCharge.AutoSize = true;
            this.radFreeOfCharge.Location = new System.Drawing.Point(20, 107);
            this.radFreeOfCharge.Name = "radFreeOfCharge";
            this.radFreeOfCharge.Size = new System.Drawing.Size(94, 17);
            this.radFreeOfCharge.TabIndex = 1;
            this.radFreeOfCharge.TabStop = true;
            this.radFreeOfCharge.Text = "Free of charge";
            this.radFreeOfCharge.UseVisualStyleBackColor = true;
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.radFreeOfCharge);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPreviousStep);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.lblRegNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CheckOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check out";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPreviousStep;
        public System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lblRegNum;
        private System.Windows.Forms.RadioButton radFreeOfCharge;
    }
}