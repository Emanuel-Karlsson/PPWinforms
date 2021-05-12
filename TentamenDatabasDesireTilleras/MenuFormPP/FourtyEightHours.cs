﻿using System;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace MenuFormPP
{
    public partial class lstView48h : Form
    {
        public lstView48h()
        {
            InitializeComponent();
        }

        private void FortyEightHours_Load(object sender, EventArgs e)
        {            
            var list = HelperClass.BackEndIO.Vehicle48h().OrderBy(v => v.ParkingSpotNum);
            string vehicleType;
            foreach (var vehicle in list)
            {
                var itm = new ListViewItem();
                itm.SubItems.Add(vehicle.ParkingSpotNum.ToString());
                itm.SubItems.Add(vehicle.Regnr);
                if (vehicle.VehicleType == 1)
                {
                    vehicleType = "MC";
                }
                else if (vehicle.VehicleType == 2)
                {
                    vehicleType = "CAR";
                }
                else
                {
                    vehicleType = "";
                }
                itm.SubItems.Add(vehicleType);
                itm.SubItems.Add(vehicle.ArrivalTime.ToString());                
                itm.SubItems.Add(vehicle.HoursParked.ToString());                
                listView1.Items.Add(itm); 
            }  
            
        }

    }  
}
