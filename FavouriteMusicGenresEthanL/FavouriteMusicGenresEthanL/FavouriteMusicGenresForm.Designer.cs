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
            this.musicGenresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHipHopMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTrapMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRnBMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSoundCloudMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grbMusicGenres = new System.Windows.Forms.GroupBox();
            this.picArtist = new System.Windows.Forms.PictureBox();
            this.lblHipHopSubtext = new System.Windows.Forms.Label();
            this.lblHipHopHeading = new System.Windows.Forms.Label();
            this.mnuMusicGenres.SuspendLayout();
            this.grbMusicGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArtist)).BeginInit();
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
            this.mniHipHopMusic.Size = new System.Drawing.Size(140, 22);
            this.mniHipHopMusic.Text = "Hip Hop";
            this.mniHipHopMusic.Click += new System.EventHandler(this.MniHipHopMusic_Click);
            // 
            // mniTrapMusic
            // 
            this.mniTrapMusic.Name = "mniTrapMusic";
            this.mniTrapMusic.Size = new System.Drawing.Size(140, 22);
            this.mniTrapMusic.Text = "Trap";
            this.mniTrapMusic.Click += new System.EventHandler(this.MniTrapMusic_Click);
            // 
            // mniRnBMusic
            // 
            this.mniRnBMusic.Name = "mniRnBMusic";
            this.mniRnBMusic.Size = new System.Drawing.Size(140, 22);
            this.mniRnBMusic.Text = "RnB";
            this.mniRnBMusic.Click += new System.EventHandler(this.MniRnBMusic_Click);
            // 
            // mniSoundCloudMusic
            // 
            this.mniSoundCloudMusic.Name = "mniSoundCloudMusic";
            this.mniSoundCloudMusic.Size = new System.Drawing.Size(140, 22);
            this.mniSoundCloudMusic.Text = "SoundCloud";
            this.mniSoundCloudMusic.Click += new System.EventHandler(this.MniSoundCloudMusic_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grbMusicGenres
            // 
            this.grbMusicGenres.Controls.Add(this.picArtist);
            this.grbMusicGenres.Controls.Add(this.lblHipHopSubtext);
            this.grbMusicGenres.Controls.Add(this.lblHipHopHeading);
            this.grbMusicGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMusicGenres.Location = new System.Drawing.Point(166, 83);
            this.grbMusicGenres.Name = "grbMusicGenres";
            this.grbMusicGenres.Size = new System.Drawing.Size(570, 355);
            this.grbMusicGenres.TabIndex = 2;
            this.grbMusicGenres.TabStop = false;
            this.grbMusicGenres.Text = "Music Genres";
            // 
            // picArtist
            // 
            this.picArtist.Image = global::FavouriteMusicGenresEthanL.Properties.Resources.Kanye;
            this.picArtist.Location = new System.Drawing.Point(130, 154);
            this.picArtist.Name = "picArtist";
            this.picArtist.Size = new System.Drawing.Size(327, 201);
            this.picArtist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArtist.TabIndex = 3;
            this.picArtist.TabStop = false;
            // 
            // lblHipHopSubtext
            // 
            this.lblHipHopSubtext.AutoSize = true;
            this.lblHipHopSubtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHipHopSubtext.Location = new System.Drawing.Point(197, 107);
            this.lblHipHopSubtext.Name = "lblHipHopSubtext";
            this.lblHipHopSubtext.Size = new System.Drawing.Size(181, 33);
            this.lblHipHopSubtext.TabIndex = 1;
            this.lblHipHopSubtext.Text = "Kanye West";
            // 
            // lblHipHopHeading
            // 
            this.lblHipHopHeading.AutoSize = true;
            this.lblHipHopHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHipHopHeading.Location = new System.Drawing.Point(219, 46);
            this.lblHipHopHeading.Name = "lblHipHopHeading";
            this.lblHipHopHeading.Size = new System.Drawing.Size(148, 39);
            this.lblHipHopHeading.TabIndex = 0;
            this.lblHipHopHeading.Text = "Hip Hop";
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
            ((System.ComponentModel.ISupportInitialize)(this.picArtist)).EndInit();
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
        private System.Windows.Forms.PictureBox picArtist;
    }
}

