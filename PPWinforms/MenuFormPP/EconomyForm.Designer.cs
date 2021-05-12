
namespace MenuFormPP
{
    partial class EconomyForm
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
            this.radSpecificDay = new System.Windows.Forms.RadioButton();
            this.radBetweenDates = new System.Windows.Forms.RadioButton();
            this.lblFirstDate = new System.Windows.Forms.Label();
            this.lblSecondDate = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblIncomeResult = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // radSpecificDay
            // 
            this.radSpecificDay.AutoSize = true;
            this.radSpecificDay.Location = new System.Drawing.Point(63, 49);
            this.radSpecificDay.Name = "radSpecificDay";
            this.radSpecificDay.Size = new System.Drawing.Size(83, 17);
            this.radSpecificDay.TabIndex = 0;
            this.radSpecificDay.TabStop = true;
            this.radSpecificDay.Text = "Specific day";
            this.radSpecificDay.UseVisualStyleBackColor = true;
            this.radSpecificDay.CheckedChanged += new System.EventHandler(this.radSpecificDay_CheckedChanged);
            // 
            // radBetweenDates
            // 
            this.radBetweenDates.AutoSize = true;
            this.radBetweenDates.Location = new System.Drawing.Point(63, 72);
            this.radBetweenDates.Name = "radBetweenDates";
            this.radBetweenDates.Size = new System.Drawing.Size(96, 17);
            this.radBetweenDates.TabIndex = 1;
            this.radBetweenDates.TabStop = true;
            this.radBetweenDates.Text = "Between dates";
            this.radBetweenDates.UseVisualStyleBackColor = true;
            this.radBetweenDates.CheckedChanged += new System.EventHandler(this.radBetweenDates_CheckedChanged);
            // 
            // lblFirstDate
            // 
            this.lblFirstDate.AutoSize = true;
            this.lblFirstDate.Location = new System.Drawing.Point(210, 49);
            this.lblFirstDate.Name = "lblFirstDate";
            this.lblFirstDate.Size = new System.Drawing.Size(55, 13);
            this.lblFirstDate.TabIndex = 3;
            this.lblFirstDate.Text = "First Date:";
            // 
            // lblSecondDate
            // 
            this.lblSecondDate.AutoSize = true;
            this.lblSecondDate.Location = new System.Drawing.Point(210, 76);
            this.lblSecondDate.Name = "lblSecondDate";
            this.lblSecondDate.Size = new System.Drawing.Size(73, 13);
            this.lblSecondDate.TabIndex = 5;
            this.lblSecondDate.Text = "Second Date:";
            this.lblSecondDate.Visible = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(504, 46);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(88, 33);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblIncomeResult
            // 
            this.lblIncomeResult.Location = new System.Drawing.Point(210, 116);
            this.lblIncomeResult.Name = "lblIncomeResult";
            this.lblIncomeResult.Size = new System.Drawing.Size(309, 22);
            this.lblIncomeResult.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(286, 72);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // EconomyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 370);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblIncomeResult);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblSecondDate);
            this.Controls.Add(this.lblFirstDate);
            this.Controls.Add(this.radBetweenDates);
            this.Controls.Add(this.radSpecificDay);
            this.Name = "EconomyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Economy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radSpecificDay;
        private System.Windows.Forms.RadioButton radBetweenDates;
        private System.Windows.Forms.Label lblFirstDate;
        private System.Windows.Forms.Label lblSecondDate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblIncomeResult;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}