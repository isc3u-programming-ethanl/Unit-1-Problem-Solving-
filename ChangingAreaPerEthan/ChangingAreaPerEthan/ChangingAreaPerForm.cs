/*
 * Created by: Ethan L
 * Created on: September 17. 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Changing Area and Perimeter
 * This program gets the length and width from the user and then calculates the area and perimeter of a rectangle
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

namespace ChangingAreaPerEthan
{
    public partial class frmChangingAreaPer : Form
    {
        public frmChangingAreaPer()
        {
            InitializeComponent();

            this.lblPerAnswer.Hide();
            this.lblAreaAnswer.Hide();
        }

        private void LblLength_Click(object sender, EventArgs e)
        {

        }

        private void FrmChangingAreaPer_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblWidth_Click(object sender, EventArgs e)
        {

        }

        private void TxtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double length, width, perimeter, area;

            // convert the string from each text box to a double
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            // calculate the area and perimeter 
            area = length * width;
            perimeter = length * 2 + width * 2;

            // insert the area and perimeter into their respective labels
            this.lblAreaAnswer.Text = Convert.ToString(area) + " squared meters";
            this.lblPerAnswer.Text = Convert.ToString(perimeter) + " meters";

            // display the perimeter and area labels with their respective answers
            this.lblPerAnswer.Show();
            this.lblAreaAnswer.Show();
        }

        private void LblPerAnswer_Click(object sender, EventArgs e)
        {

        }

        private void LblAreaAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
