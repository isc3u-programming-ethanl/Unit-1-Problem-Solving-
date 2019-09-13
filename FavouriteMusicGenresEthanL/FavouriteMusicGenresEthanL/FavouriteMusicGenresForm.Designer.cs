namespace FavouriteMusicGenresEthanL
{
    partial class frmFavouriteMusicGenres
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
            this.components = new System.ComponentModel.Container();
            this.mnuMusicGenres = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.musicGenresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHipHopMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTrapMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRnBMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSoundCloudMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.grbMusicGenres = new System.Windows.Forms.GroupBox();
            this.lblHipHopHeading = new System.Windows.Forms.Label();
            this.lblHipHopSubtext = new System.Windows.Forms.Label();
            this.mnuMusicGenres.SuspendLayout();
            this.grbMusicGenres.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMusicGenres
            // 
            this.mnuMusicGenres.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicGenresToolStripMenuItem});
            this.mnuMusicGenres.Location = new System.Drawing.Point(0, 0);
            this.mnuMusicGenres.Name = "mnuMusicGenres";
            this.mnuMusicGenres.Size = new System.Drawing.Size(800, 24);
            this.mnuMusicGenres.TabIndex = 0;
            this.mnuMusicGenres.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // musicGenresToolStripMenuItem
            // 
            this.musicGenresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniHipHopMusic,
            this.mniTrapMusic,
            this.mniRnBMusic,
            this.mniSoundCloudMusic});
            this.musicGenresToolStripMenuItem.Name = "musicGenresToolStripMenuItem";
            this.musicGenresToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.musicGenresToolStripMenuItem.Text = "Music Genres";
            // 
            // mniHipHopMusic
            // 
            this.mniHipHopMusic.Name = "mniHipHopMusic";
            this.mniHipHopMusic.Size = new System.Drawing.Size(180, 22);
            this.mniHipHopMusic.Text = "Hip Hop";
            // 
            // mniTrapMusic
            // 
            this.mniTrapMusic.Name = "mniTrapMusic";
            this.mniTrapMusic.Size = new System.Drawing.Size(180, 22);
            this.mniTrapMusic.Text = "Trap";
            // 
            // mniRnBMusic
            // 
            this.mniRnBMusic.Name = "mniRnBMusic";
            this.mniRnBMusic.Size = new System.Drawing.Size(180, 22);
            this.mniRnBMusic.Text = "RnB";
            // 
            // mniSoundCloudMusic
            // 
            this.mniSoundCloudMusic.Name = "mniSoundCloudMusic";
            this.mniSoundCloudMusic.Size = new System.Drawing.Size(180, 22);
            this.mniSoundCloudMusic.Text = "SoundCloud";
            // 
            // grbMusicGenres
            // 
            this.grbMusicGenres.Controls.Add(this.lblHipHopSubtext);
            this.grbMusicGenres.Controls.Add(this.lblHipHopHeading);
            this.grbMusicGenres.Location = new System.Drawing.Point(166, 83);
            this.grbMusicGenres.Name = "grbMusicGenres";
            this.grbMusicGenres.Size = new System.Drawing.Size(409, 251);
            this.grbMusicGenres.TabIndex = 2;
            this.grbMusicGenres.TabStop = false;
            this.grbMusicGenres.Text = "Music Genres";
            // 
            // lblHipHopHeading
            // 
            this.lblHipHopHeading.AutoSize = true;
            this.lblHipHopHeading.Location = new System.Drawing.Point(58, 65);
            this.lblHipHopHeading.Name = "lblHipHopHeading";
            this.lblHipHopHeading.Size = new System.Drawing.Size(46, 13);
            this.lblHipHopHeading.TabIndex = 0;
            this.lblHipHopHeading.Text = "Hip Hop";
            // 
            // lblHipHopSubtext
            // 
            this.lblHipHopSubtext.AutoSize = true;
            this.lblHipHopSubtext.Location = new System.Drawing.Point(170, 113);
            this.lblHipHopSubtext.Name = "lblHipHopSubtext";
            this.lblHipHopSubtext.Size = new System.Drawing.Size(65, 13);
            this.lblHipHopSubtext.TabIndex = 1;
            this.lblHipHopSubtext.Text = "Kanye West";
            // 
            // frmFavouriteMusicGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbMusicGenres);
            this.Controls.Add(this.mnuMusicGenres);
            this.MainMenuStrip = this.mnuMusicGenres;
            this.Name = "frmFavouriteMusicGenres";
            this.Text = "Favourite Music Genres";
            this.mnuMusicGenres.ResumeLayout(false);
            this.mnuMusicGenres.PerformLayout();
            this.grbMusicGenres.ResumeLayout(false);
            this.grbMusicGenres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMusicGenres;
        private System.Windows.Forms.ToolStripMenuItem musicGenresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniHipHopMusic;
        private System.Windows.Forms.ToolStripMenuItem mniTrapMusic;
        private System.Windows.Forms.ToolStripMenuItem mniRnBMusic;
        private System.Windows.Forms.ToolStripMenuItem mniSoundCloudMusic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grbMusicGenres;
        private System.Windows.Forms.Label lblHipHopSubtext;
        private System.Windows.Forms.Label lblHipHopHeading;
    }
}

