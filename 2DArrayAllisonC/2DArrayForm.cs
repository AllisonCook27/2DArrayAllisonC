/*
 * Created by: Allison Cook
 * Created on: 16 May, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #40 - 2D Arrays
 * This program calculates the average of the numbers in a 2D array which the user specify the size of the array
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

namespace _2DArrayAllisonC
{
    public partial class frm2DArray : Form
    {
        public frm2DArray()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //local variables
            int lenght, width, aRandomNumber;
            string line = null;

            //gettiong the random number generator 
            Random randomNumberGenerator = new Random();

            //get the lenght and width from the user
            lenght = Convert.ToInt16(this.nudLenght.Value);
            width = Convert.ToInt16(this.nudWidth.Value);

            //create the array

        }
    }
}
