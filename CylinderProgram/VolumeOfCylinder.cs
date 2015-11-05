/*
Created by Matthew Ho
Created on 11-05-15
Created for ICS3U
Assignment #4-06
This program uses a function to calculate the volume of a cylinder
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CylinderProgram
{
    public partial class frmVolumeOfCylinder : Form
    {
        public double VolumeOfCylinder(double radius, double height)
        {
            //This function calculates the volume of a cynlinder
            double volume = 0;

            volume = Math.PI * Math.Pow(radius, 2) * height;

            return volume;
        }

        public frmVolumeOfCylinder()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Variables
            double radius = 0;
            double height = 0;
            double volume = 0;

            radius =Convert.ToDouble(this.nudRadius.Value);
            height = Convert.ToDouble(this.nudHeight.Value);

            //Calling the function
            volume = VolumeOfCylinder(radius, height);

            //Show answer
            this.lblAnswer.Text = "The volume of the cylinder is: " + volume;
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //Close the program
            this.Close();
        }
    }
}
