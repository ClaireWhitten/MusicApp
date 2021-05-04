using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class Form3 : Form
    {

        public User CurrentUser { get; set; }

        
        public Form3(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;

            lbl_likedSong.Hide();

            var context = new MusicAppContext();

            var existingPlaylists = context.Playlists
                .Where(p => p.UserId == CurrentUser.UserId);
            if (existingPlaylists != null)
            {
                var usersPlaylists = existingPlaylists.ToList();

                lb_UserPlaylists.DataSource = usersPlaylists;
                //lb_UserPlaylists.DisplayMember = "Name";
                //lb_UserPlaylists.ValueMember = "Id";
            }
            else
            {
                lb_UserPlaylists.Text = "You have no playlists. Create one!";
            }

            
        }

        private void lb_UserPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {

            Playlist chosenPlaylist = (Playlist)lb_UserPlaylists.SelectedItem;
            var context = new MusicAppContext();
            var playlistSongs = context.PlaylistSongs
                .Where(p => p.PlaylistId == chosenPlaylist.PlaylistId)
                .Include("Song").ToList();

            List<Song> songs = new List<Song>();

            foreach (var row in playlistSongs)
            {
                songs.Add(context.Songs.FirstOrDefault(s => s.SongId == row.SongId));
                context.SaveChanges();
            }





            /* foreach (var item in playlistSongs)
             {
                 MessageBox.Show(item.Song.ToString());
             }*/

            //stops first song being automatically selected and playing 
            lb_PlaylistSongs.SelectedIndexChanged -= lb_PlaylistSongs_SelectedIndexChanged;
            lb_PlaylistSongs.DataSource = null;
            lb_PlaylistSongs.DataSource = songs;
            lb_PlaylistSongs.SelectedIndex = -1; // This optional line keeps the first item from being selected.
            lb_PlaylistSongs.SelectedIndexChanged += lb_PlaylistSongs_SelectedIndexChanged;



           
            //lb_PlaylistSongs.DisplayMember = "";

            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(CurrentUser);
            form4.ShowDialog();

        }

        private void lb_PlaylistSongs_SelectedIndexChanged(object sender, EventArgs e)
        {

          
            Song song = (Song)lb_PlaylistSongs.SelectedItem;
            var context = new MusicAppContext();
            //checking all interactions in the interaction table  - how to just check the users? 
            Interaction existingInteraction = context.Interactions.FirstOrDefault(i => i.UserId == CurrentUser.UserId && i.SongId == song.SongId);
            if (existingInteraction == null)
            {
                Interaction interaction = new Interaction()
                {
                    UserId = CurrentUser.UserId,
                    SongId = song.SongId,
                    Liked = 0,
                    PlayCount = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                context.Interactions.Add(interaction);
                //existingInteraction = interaction;
                //CurrentUser.Interactions.Add(interaction); - error " not set to an instance of an object)
                context.SaveChanges();

                MessageBox.Show($"{song.Title} is now playing.... \n You've played it {interaction.PlayCount} times.");
            }
            else
            {
                if(existingInteraction.Liked == 1)
                {
                    btn_like.Enabled = false;
                    lbl_likedSong.Show();

                } else
                {
                    btn_like.Enabled = true;
                    lbl_likedSong.Hide();
                }
                existingInteraction.PlayCount++;
                existingInteraction.UpdatedAt = DateTime.Now;
                context.SaveChanges();
                MessageBox.Show($"{song.Title} is now playing.... \n You've played it {existingInteraction.PlayCount} times.");
            }


            


        }

        private void btn_like_Click(object sender, EventArgs e)
        {
            var context = new MusicAppContext();
            Song song  = (Song)lb_PlaylistSongs.SelectedItem;
            Interaction existingInteraction = context.Interactions.FirstOrDefault(i => i.UserId == CurrentUser.UserId && i.SongId == song.SongId);
            existingInteraction.Liked = 1;
            MessageBox.Show("Song liked");
            context.SaveChanges();

        }
    }
}
