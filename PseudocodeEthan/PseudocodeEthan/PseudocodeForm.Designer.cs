namespace PseudocodeEthan
{
    partial class frmPseudocode
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
            this.lblInches = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInches
            // 
            this.lblInches.AutoSize = true;
            this.lblInches.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInches.Location = new System.Drawing.Point(52, 82);
            this.lblInches.Name = "lblInches";
            this.lblInches.Size = new System.Drawing.Size(461, 25);
            this.lblInches.TabIndex = 0;
            this.lblInches.Text = "Enter the diameter of the pizza (in inches):";
            this.lblInches.Click += new System.EventHandler(this.LblInches_Click);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(52, 226);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(292, 25);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "The cost (including tax) is:";
            this.lblTax.Click += new System.EventHandler(this.LblTax_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(57, 142);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(206, 56);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(535, 87);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtDiameter.TabIndex = 3;
            this.txtDiameter.TextChanged += new System.EventHandler(this.TxtDiameter_TextChanged);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(387, 226);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(51, 25);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "???";
            this.lblAnswer.Click += new System.EventHandler(this.LblAnswer_Click);
            // 
            // frmPseudocode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblInches);
            this.Name = "frmPseudocode";
            this.Text = "Pseudocode by Ethan";
            this.Load += new System.EventHandler(this.FrmPseudocode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInches;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Label lblAnswer;
    }
}

