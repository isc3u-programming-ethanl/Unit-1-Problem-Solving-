/*
 * Created by: Ethan L
 * Created on: September 14, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Favourite Music Genres
 * This program has a menu that when clicked displays my favourite music genres with my favourite artist of that genre

*/using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FavouriteMusicGenresEthanL
{
    public partial class frmFavouriteMusicGenres : Form
    {
        public frmFavouriteMusicGenres()
        {
            InitializeComponent();
        }

        private void MniHipHopMusic_Click(object sender, EventArgs e)
        {
            // change the heading to say Hip Hop
            this.lblHipHopHeading.Text = "Hip Hop";
            // // change the subheading to say Kanye West
            this.lblHipHopSubtext.Text = "Kanye West";
            // change the image to a picture of Kanye West
            this.picArtist.Image = Properties.Resources.Kanye;

        }

        private void MniTrapMusic_Click(object sender, EventArgs e)
        {
            // change the heading to say Trap
            this.lblHipHopHeading.Text = "Trap";
            // change the subheading to say Travis Scott
            this.lblHipHopSubtext.Text = "Travis Scott";
            // change the image to a picture of Travis Scott
            this.picArtist.Image = Properties.Resources.Rodeoalbum;

        }

        private void MniRnBMusic_Click(object sender, EventArgs e)
        {
            // change the heading to say RnB
            this.lblHipHopHeading.Text = "RnB";
            // change the subheading to say Frank Ocean
            this.lblHipHopSubtext.Text = "Frank Ocean";
            // change the image to a picture of Frank Ocean
            this.picArtist.Image = Properties.Resources.Frank_Ocean;
        }

        private void MniSoundCloudMusic_Click(object sender, EventArgs e)
        {
            // change the heading to say SoundCloud Rap
            this.lblHipHopHeading.Text = "Soundcloud Rap";
            // change the subheading to say Playboi Carti
            this.lblHipHopSubtext.Text = "Playboi Carti";
            // change the image to a picture of Playboi Carti
            this.picArtist.Image = Properties.Resources.playboi_carti_fader;
        }
    }
}
