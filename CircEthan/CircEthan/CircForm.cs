/*
 * Created by: Ethan L
 * Created on: 09/19/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Top Down Design Circumference
 * This program calculates the circumference of a circle with a given radius
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

namespace CircEthan
{
    public partial class frmCirc : Form
    {
        public frmCirc()
        {
            InitializeComponent();

            this.lblAnswer.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCirc_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double radius, circumference;

            // convert the string from each text box to a double
            radius = double.Parse(txtRadius.Text);

            // calculate the circumference
            circumference = 3.14 * radius * radius;

            // insert the circumference into the respective label
            this.lblAnswer.Text = Convert.ToString(circumference) + " centimeters";

            // display the circumference label with the respective answer
            this.lblAnswer.Show();
        }

        private void LblCircumference_Click(object sender, EventArgs e)
        {

        }

        private void LblAnswer_Click(object sender, EventArgs e)
        {
        
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
