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
    public partial class Form2 : Form
    {

        public User CurrentUser;
        public Form2(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
            lbl_welcome.Text = $"Welcome {CurrentUser.FirstName} {CurrentUser.LastName}!";

            cb_ChoosePlaylist.Hide();
            lbl_choosePlaylist.Hide();


            var context = new MusicAppContext();
            var artistCollection = context.Artists.Select(a => new
            {
                Name = a.Name,
                Id = a.ArtistId
            }).ToList();


            cb_Artists.DataSource = artistCollection;
            cb_Artists.DisplayMember = "Name";
            cb_Artists.ValueMember = "Id";




            var albumCollection = context.Albums.Include("Artist").Select(a => new
            {
                NameAndArtist = a.Name + " " + "by " + a.Artist.Name,
                Id = a.AlbumId
            }).ToList();


            cb_Albums.DataSource = albumCollection;
            cb_Albums.DisplayMember = "NameAndArtist";
            cb_Albums.ValueMember = "Id";
            
        }

        private void btn_AddArtist_Click(object sender, EventArgs e)
        {
            string newArtist = txt_AddArtist.Text;
            var context = new MusicAppContext();
            if (context.Artists.FirstOrDefault(a => a.Name == txt_AddArtist.Text) != null)
            {
                MessageBox.Show("This artist already exists");
                txt_AddArtist.Clear();
            } 
            else
            {
                DateTime currentDate = DateTime.Now;
                Artist artist = new Artist()
                {
                    Name = txt_AddArtist.Text,
                    CreatedAt = currentDate,
                    UpdatedAt = currentDate
                };
                context.Artists.Add(artist);
                context.SaveChanges();
                var artistCollection = context.Artists.Select(a => new
                {
                    Name = a.Name,
                    Id = a.ArtistId
                }).ToList();

                cb_Artists.DataSource = null;
                cb_Artists.DataSource = artistCollection;
                cb_Artists.DisplayMember = "Name";
                cb_Artists.ValueMember = "Id";
                txt_AddArtist.Clear();
            }
            
        }

        private void btn_AddAlbum_Click(object sender, EventArgs e)
        {
            var context = new MusicAppContext();
            int selectedId = Convert.ToInt32(cb_Artists.SelectedValue);
            if (context.Albums.FirstOrDefault(a => a.Name == txt_AddAlbum.Text && a.ArtistId == selectedId) != null)
            {
                MessageBox.Show($"This album already exists.");
                txt_AddAlbum.Clear();
            }
            else
            {
                DateTime currentDate = DateTime.Now;
                Album album = new Album()
                {
                    Name = txt_AddAlbum.Text,
                    ArtistId = selectedId,
                    CreatedAt = currentDate,
                    UpdatedAt = currentDate
                };
                context.Albums.Add(album);
                context.SaveChanges();

                var albumCollection = context.Albums.Include("Artist").Select(a => new
                {
                    NameAndArtist = a.Name + " " + "by " + a.Artist.Name,
                    Id = a.AlbumId
                }).ToList();


                cb_Albums.DataSource = null;
                cb_Albums.DataSource = albumCollection;
                cb_Albums.DisplayMember = "NameAndArtist";
                cb_Albums.ValueMember = "Id";
                txt_AddAlbum.Clear();
            }
        }

        private void btn_AddSong_Click(object sender, EventArgs e)
        {
            var context = new MusicAppContext();
            int selectedId = Convert.ToInt32(cb_Albums.SelectedValue);
            if (context.Songs.FirstOrDefault(s => s.Title == txt_AddSong.Text && s.AlbumId == selectedId) != null)
            {
                MessageBox.Show($"This song already exists in the album.");
                txt_AddSong.Clear();
            }
            else
            {
                Album album = context.Albums
                    .Where(a => a.AlbumId == selectedId)
                    .FirstOrDefault();
                   


                Song song = new Song()
                {
                    AlbumId = selectedId,
                    ArtistId = album.ArtistId,
                    Title = txt_AddSong.Text,
                    Length = 2.5,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                context.Songs.Add(song);
                context.SaveChanges();

                if (chk_playlistYes.Checked)
                {
                    var ExistingPlaylists = context.Playlists.Where(p => p.UserId == CurrentUser.UserId);

                    if (ExistingPlaylists != null)
                    {
                        /*var usersPlaylists = ExistingPlaylists
                        .Select(p => new
                        {
                            Name = p.Name,
                            Details = p.Name + " " + "Last updated: " + p.UpdatedAt,
                            Id = p.PlaylistId
                        }).ToList();

                        cb_ChoosePlaylist.DataSource = usersPlaylists;
                        cb_ChoosePlaylist.DisplayMember = "Name";
                        cb_ChoosePlaylist.ValueMember = "Id";*/


                        Playlist selectedPlaylist = (Playlist)cb_ChoosePlaylist.SelectedItem;

                        PlaylistSong newSongForPlaylist = new PlaylistSong()
                        {
                            PlaylistId = selectedPlaylist.PlaylistId,
                            SongId = song.SongId
                        };

                        context.PlaylistSongs.Add(newSongForPlaylist);
                        context.SaveChanges();

                        Playlist playList = context.Playlists.FirstOrDefault(p => p.PlaylistId == selectedPlaylist.PlaylistId);
                        var playListSongs = context.PlaylistSongs.Where(ps => ps.PlaylistId == playList.PlaylistId).ToList();
                        int NumberOfSongs = playListSongs.Count;


                        MessageBox.Show($"{song.Title} has been added to the playlist '{playList.Name}'.\n This playlist now has {NumberOfSongs} songs.");

                        Playlist playlist = context.Playlists.FirstOrDefault(p => p.PlaylistId == selectedPlaylist.PlaylistId);
                        playlist.UpdatedAt = DateTime.Now;


                        context.SaveChanges();


                    }
                    else
                    {
                        cb_ChoosePlaylist.Text = "You have no playlists";
                    }
                    
                }
                
            }


        }

        private void chk_playlistYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_playlistYes.Checked)
            {
                cb_ChoosePlaylist.Show();
                lbl_choosePlaylist.Show();

                var context = new MusicAppContext();
                List<Playlist> usersPlaylists = context.Playlists.Where(p => p.UserId == CurrentUser.UserId).ToList();

                cb_ChoosePlaylist.DataSource = usersPlaylists;
                //cb_ChoosePlaylist.ValueMember = "PlaylistId";

            } else
            {
                cb_ChoosePlaylist.Hide();
                lbl_choosePlaylist.Hide();
            }
        }

        private void btn_Playlists_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(CurrentUser);
            form3.ShowDialog();

        }
    }
}
