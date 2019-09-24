/*
 * Created by: Ethan L
 * Created on: 09/24/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #12 - Pizza Cost
 * This program calculates the cost of a pizza with the diameter and then tax
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

namespace PseudocodeEthan
{
    public partial class frmPseudocode : Form
    {
        public frmPseudocode()
        {
            InitializeComponent();
        }

        private void FrmPseudocode_Load(object sender, EventArgs e)
        {
            this.lblAnswer.Hide();
        }

        private void LblInches_Click(object sender, EventArgs e)
        {

        }

        private void TxtDiameter_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double diameter, costBeforeTax, costAfterTax;

            // convert the diameter to double
            diameter = double.Parse(txtDiameter.Text);

            // calculate cost before and after tax
            costBeforeTax = 0.75 + 0.99 + 0.50 * diameter;
            costAfterTax = costBeforeTax * 1.13;

            // display the cost as a label and rounded to two decimals
            lblAnswer.Text = String.Format("${0:0.00}", costAfterTax);

            // hide the answer text
            this.lblAnswer.Show();
        }

        private void LblTax_Click(object sender, EventArgs e)
        {

        }

        private void LblAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
