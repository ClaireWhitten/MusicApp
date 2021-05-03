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
    public partial class Form3 : Form
    {

        public User CurrentUser;
        public Form3(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;

            var context = new MusicAppContext();

            var existingPlaylists = context.Playlists.Where(p => p.UserId == CurrentUser.UserId);
            if (existingPlaylists != null)
            {
                var usersPlaylists = existingPlaylists
                        .Select(p => new
                        {
                            Name = p.Name,
                            Details = p.Name + " " + "Last updated: " + p.UpdatedAt,
                            Id = p.PlaylistId
                        }).ToList();

                lb_UserPlaylists.DataSource = usersPlaylists;
                lb_UserPlaylists.DisplayMember = "Details";
                lb_UserPlaylists.ValueMember = "Id";
            }
            else
            {
                lb_UserPlaylists.Text = "You have no playlists. Create one!";
            }

            
        }

        private void lb_UserPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(CurrentUser);
            form4.ShowDialog();

        }
    }
}
