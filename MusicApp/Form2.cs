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
    public partial class Form2 : Form
    {
        
        public Form2(string username)
        {
            InitializeComponent();

            lbl_welcome.Text = $"Welcome {username}!";

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
                var albumArtist  = context.Albums.






                Song song = new Song()
                {
                    AlbumId = selectedId,
                    ArtistId = 
                    Title = txt_AddSong.Text,
                    Length = 2.5,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                context.Songs.Add(song);
                context.SaveChanges();
            }


        }
    }
}
