namespace ChangingAreaPerEthan
{
    partial class frmChangingAreaPer
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPerimeterText = new System.Windows.Forms.Label();
            this.lblAreaText = new System.Windows.Forms.Label();
            this.lblPerAnswer = new System.Windows.Forms.Label();
            this.lblAreaAnswer = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(164, 99);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(125, 25);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length (m)";
            this.lblLength.Click += new System.EventHandler(this.LblLength_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(164, 169);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(113, 25);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width (m)";
            this.lblWidth.Click += new System.EventHandler(this.LblWidth_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(325, 175);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.TextChanged += new System.EventHandler(this.TxtWidth_TextChanged);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(325, 105);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 4;
            this.txtLength.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(466, 129);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(113, 48);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblPerimeterText
            // 
            this.lblPerimeterText.AutoSize = true;
            this.lblPerimeterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeterText.Location = new System.Drawing.Point(166, 285);
            this.lblPerimeterText.Name = "lblPerimeterText";
            this.lblPerimeterText.Size = new System.Drawing.Size(175, 24);
            this.lblPerimeterText.TabIndex = 6;
            this.lblPerimeterText.Text = "The perimeter is :";
            // 
            // lblAreaText
            // 
            this.lblAreaText.AutoSize = true;
            this.lblAreaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaText.Location = new System.Drawing.Point(167, 362);
            this.lblAreaText.Name = "lblAreaText";
            this.lblAreaText.Size = new System.Drawing.Size(127, 24);
            this.lblAreaText.TabIndex = 7;
            this.lblAreaText.Text = "The area is :";
            // 
            // lblPerAnswer
            // 
            this.lblPerAnswer.AutoSize = true;
            this.lblPerAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerAnswer.Location = new System.Drawing.Point(410, 285);
            this.lblPerAnswer.Name = "lblPerAnswer";
            this.lblPerAnswer.Size = new System.Drawing.Size(73, 24);
            this.lblPerAnswer.TabIndex = 8;
            this.lblPerAnswer.Text = "meters";
            this.lblPerAnswer.Click += new System.EventHandler(this.LblPerAnswer_Click);
            // 
            // lblAreaAnswer
            // 
            this.lblAreaAnswer.AutoSize = true;
            this.lblAreaAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaAnswer.Location = new System.Drawing.Point(410, 362);
            this.lblAreaAnswer.Name = "lblAreaAnswer";
            this.lblAreaAnswer.Size = new System.Drawing.Size(155, 24);
            this.lblAreaAnswer.TabIndex = 9;
            this.lblAreaAnswer.Text = "meters squared";
            this.lblAreaAnswer.Click += new System.EventHandler(this.LblAreaAnswer_Click);
            // 
            // frmChangingAreaPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAreaAnswer);
            this.Controls.Add(this.lblPerAnswer);
            this.Controls.Add(this.lblAreaText);
            this.Controls.Add(this.lblPerimeterText);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChangingAreaPer";
            this.Text = "Area and Perimeter of a rectangle by Ethan";
            this.Load += new System.EventHandler(this.FrmChangingAreaPer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPerimeterText;
        private System.Windows.Forms.Label lblAreaText;
        private System.Windows.Forms.Label lblPerAnswer;
        private System.Windows.Forms.Label lblAreaAnswer;
    }
}

