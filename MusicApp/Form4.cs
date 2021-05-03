using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class Form4 : Form
    {
        public User CurrentUser { get; set; }

        public List<Song> AllChosenSongs { get; set; } = new List<Song>();


        public Form4(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;

            var context = new MusicAppContext();
            var albumCollection = context.Albums
                .Include("Artist")
/*                .Select(a => new
            {
                NameAndArtist = a.Name + " " + "by " + a.Artist.Name,
                Id = a.AlbumId
            })*/
                .ToList();

            cb_ChooseAlbum.DataSource = albumCollection;
            cb_ChooseAlbum.DisplayMember = "Name";
            //cb_ChooseAlbum.ValueMember = "Id";


            
        }

        private void cb_ChooseAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int selectedAlbum = Convert.ToInt32(cb_ChooseAlbum.SelectedValue);
            int selectedAlbum = ((Album)cb_ChooseAlbum.SelectedItem).AlbumId;
            var context = new MusicAppContext();
            var songsOnAlbum = context.Songs
                .Where(s => s.AlbumId == selectedAlbum)
                /*.Select(s => new
                {
                    Id = s.SongId,
                    Title = s.Title,
                })*/
                .ToList();


            lb_ChooseSong.DataSource = songsOnAlbum;
            lb_ChooseSong.DisplayMember = "Title";
            //lb_ChooseSong.ValueMember = "SongId";

        }

        private void lb_ChooseSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_addsong_Click(object sender, EventArgs e)
        {
            
            var chosenAlbumSongs = lb_ChooseSong.SelectedItems;
            
            foreach (var song in chosenAlbumSongs)
            {
                AllChosenSongs.Add((Song)song);
            }

            cbFinalPlaylist.DataSource = null;
            cbFinalPlaylist.DataSource = AllChosenSongs;
            cbFinalPlaylist.DisplayMember = "Title";
            


        }

        private void btn_SavePlaylist_Click(object sender, EventArgs e)
        {
            Playlist newPlaylist = new Playlist()
            {
                UserId = CurrentUser.UserId,
                Name = txt_NewPlaylistName.Text,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            var context = new MusicAppContext();
            context.Playlists.Add(newPlaylist);



            foreach (var song in AllChosenSongs)
            {
                PlaylistSong newPlaylistSong = new PlaylistSong()
                {
                    PlaylistId = newPlaylist.PlaylistId,
                    SongId = song.SongId
                };
                context.PlaylistSongs.Add(newPlaylistSong);
                context.SaveChanges();
                MessageBox.Show($"{newPlaylist.Name} is saved!");
            }



        }
    }
}
