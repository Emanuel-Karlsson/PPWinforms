
namespace MenuFormPP
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMcOpti = new System.Windows.Forms.Button();
            this.lstMcOpti = new System.Windows.Forms.ListBox();
            this.btnCloseMcOptiList = new System.Windows.Forms.Button();
            this.btnParkingLotOverview = new System.Windows.Forms.Button();
            this.btnParked48h = new System.Windows.Forms.Button();
            this.btnEconomy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(35, 24);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(75, 41);
            this.btnCheckIn.TabIndex = 0;
            this.btnCheckIn.Text = "Check in";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(35, 69);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 41);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(35, 114);
            this.btnMove.Margin = new System.Windows.Forms.Padding(2);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 41);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(35, 204);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 41);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(35, 294);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 41);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMcOpti
            // 
            this.btnMcOpti.Location = new System.Drawing.Point(35, 159);
            this.btnMcOpti.Margin = new System.Windows.Forms.Padding(2);
            this.btnMcOpti.Name = "btnMcOpti";
            this.btnMcOpti.Size = new System.Drawing.Size(75, 41);
            this.btnMcOpti.TabIndex = 3;
            this.btnMcOpti.Text = "MC Optimization";
            this.btnMcOpti.UseVisualStyleBackColor = true;
            this.btnMcOpti.Click += new System.EventHandler(this.btnMcOpti_Click);
            // 
            // lstMcOpti
            // 
            this.lstMcOpti.FormattingEnabled = true;
            this.lstMcOpti.Location = new System.Drawing.Point(259, 11);
            this.lstMcOpti.Name = "lstMcOpti";
            this.lstMcOpti.Size = new System.Drawing.Size(329, 290);
            this.lstMcOpti.TabIndex = 8;
            this.lstMcOpti.TabStop = false;
            this.lstMcOpti.Visible = false;
            // 
            // btnCloseMcOptiList
            // 
            this.btnCloseMcOptiList.Location = new System.Drawing.Point(513, 306);
            this.btnCloseMcOptiList.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseMcOptiList.Name = "btnCloseMcOptiList";
            this.btnCloseMcOptiList.Size = new System.Drawing.Size(75, 41);
            this.btnCloseMcOptiList.TabIndex = 4;
            this.btnCloseMcOptiList.Text = "Close MC Optimization";
            this.btnCloseMcOptiList.UseVisualStyleBackColor = true;
            this.btnCloseMcOptiList.Visible = false;
            this.btnCloseMcOptiList.Click += new System.EventHandler(this.btnCloseMcOptiList_Click);
            // 
            // btnParkingLotOverview
            // 
            this.btnParkingLotOverview.Location = new System.Drawing.Point(35, 249);
            this.btnParkingLotOverview.Margin = new System.Windows.Forms.Padding(2);
            this.btnParkingLotOverview.Name = "btnParkingLotOverview";
            this.btnParkingLotOverview.Size = new System.Drawing.Size(75, 41);
            this.btnParkingLotOverview.TabIndex = 9;
            this.btnParkingLotOverview.Text = "Overview";
            this.btnParkingLotOverview.UseVisualStyleBackColor = true;
            this.btnParkingLotOverview.Click += new System.EventHandler(this.btnParkingLotOverview_Click);
            // 
            // btnParked48h
            // 
            this.btnParked48h.Location = new System.Drawing.Point(128, 24);
            this.btnParked48h.Margin = new System.Windows.Forms.Padding(2);
            this.btnParked48h.Name = "btnParked48h";
            this.btnParked48h.Size = new System.Drawing.Size(75, 41);
            this.btnParked48h.TabIndex = 10;
            this.btnParked48h.Text = "Parked 48h";
            this.btnParked48h.UseVisualStyleBackColor = true;
            this.btnParked48h.Click += new System.EventHandler(this.btnParked48h_Click);
            // 
            // btnEconomy
            // 
            this.btnEconomy.Location = new System.Drawing.Point(128, 69);
            this.btnEconomy.Margin = new System.Windows.Forms.Padding(2);
            this.btnEconomy.Name = "btnEconomy";
            this.btnEconomy.Size = new System.Drawing.Size(75, 41);
            this.btnEconomy.TabIndex = 11;
            this.btnEconomy.Text = "Economy";
            this.btnEconomy.UseVisualStyleBackColor = true;
            this.btnEconomy.Click += new System.EventHandler(this.btnEconomy_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnEconomy);
            this.Controls.Add(this.btnParked48h);
            this.Controls.Add(this.btnParkingLotOverview);
            this.Controls.Add(this.btnCloseMcOptiList);
            this.Controls.Add(this.lstMcOpti);
            this.Controls.Add(this.btnMcOpti);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMcOpti;
        private System.Windows.Forms.ListBox lstMcOpti;
        private System.Windows.Forms.Button btnCloseMcOptiList;
        private System.Windows.Forms.Button btnParkingLotOverview;
        private System.Windows.Forms.Button btnParked48h;
        private System.Windows.Forms.Button btnEconomy;
    }
}

