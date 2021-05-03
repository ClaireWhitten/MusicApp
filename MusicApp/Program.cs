using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*using (MusicAppContext context = new MusicAppContext())
            {
                User newUser = context.Users.Add(new User()
                {
                    FirstName = "Claire",
                    LastName = "Whitten",
                    Email = "claire_whitten@gmail.be",
                    Password = "1111111"
                });

                context.Playlists.Add(new Playlist()
                {
                    //UserId = newUser.UserId, //or
                    User = newUser,
                    Name = "Claire's PlayList",
                    CreatedAt = new DateTime(1993, 6, 4),
                    UpdatedAt = new DateTime(1993, 6, 10),

                });

                
                context.SaveChanges();
            }
*/






            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
     
        }
    }

    public class User
    {
        public int UserId { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<Playlist> Playlists { get; set; }
        public ICollection<Interaction> Interactions { get; set; }
    }



    public class Playlist
    {
        public int PlaylistId { get; set; }

        //[ForeignKey("User")] - knows to match up with PK in the user class/table even if another name
        public int? UserId { get; set; } //this is the foreign key to set the relationship

        public User User { get; set; } 

        public string Name { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public ICollection<PlaylistSong> PlayListSongs { get; set; }
    }

    public class Interaction
    {
        public int InteractionId { get; set; }

        public int? UserId { get; set; } //this is the foreign key to set the relationship

        public User User { get; set; } 

        public int? SongId { get; set; } //FK

        public Song Song { get; set; } 

        public int? Liked { get; set; }

        public int? PlayCount { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }

    public class Song
    {
        public int SongId { get; set; }
        public int? AlbumId { get; set; }

        public Album Album { get; set; } //FK

        public int? ArtistId { get; set; }

        public Artist Artist { get; set; } //FK

        public string Title { get; set; }

        public double? Length { get; set; }
        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
        public ICollection<Interaction> Interactions { get; set; }

        public ICollection<PlaylistSong> PlayListSongs { get; set; }

    }

    public class Album
    {
        public int AlbumId { get; set; }

        public int? ArtistId { get; set; }

        public Artist Artist { get; set; }

        public string Name { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public ICollection<Song> Songs { get; set; }


    }

    public class Artist
    {
        public int ArtistId { get; set; }

        public string Name { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public ICollection<Song> Songs { get; set; }

        public ICollection<Album> Albums { get; set; }
    }

    public class PlaylistSong
    {
        [Key]
        [Column(Order= 1)]
        public int PlaylistId { get; set; } //FK

        [Key]
        [Column(Order = 2)]
        public int SongId { get; set; } //FK

        public Playlist Playlist { get; set; }
        public Song Song { get; set; }


    }


    public class MusicAppContext : DbContext
    {
        public MusicAppContext() : base("name=MusicAppDBConnectString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MusicAppContext>()); //throws exception if you change the models 
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MusicAppContext>());// clears whole DB if you change the models
            //Database.SetInitializer(new DropCreateDatabaseAlways<MusicAppContext>()); //always clear
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Playlist> Playlists { get; set; }

        public DbSet<Interaction> Interactions { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<PlaylistSong> PlaylistSongs { get; set; }

    }
}
