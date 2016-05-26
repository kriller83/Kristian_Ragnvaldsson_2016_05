using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ovningstenta.Models
{
    public class ArtistContext : DbContext
    {
        public ArtistContext():base("Music") //Konstruktor
        {
            Database.SetInitializer<ArtistContext>(new ArtistInitializer());
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }

        public class ArtistInitializer : DropCreateDatabaseAlways<ArtistContext>
        {
            protected override void Seed(ArtistContext context)
            {
                var artists = new List<Artist>()
                {
                    new Artist()
                    {
                        ArtistID = 1,
                        Name = "Per Gessle",
                        Age = 49,
                        Band = "Gyllene tider",
                    },
                    new Artist()
                    {
                        ArtistID = 2,
                        Name = "Lars",
                        Age = 46,
                        Band = "Metallica"
                    },
                    new Artist()
                    {
                        ArtistID = 3,
                        Name = "Bengt",
                        Age = 35,
                        Band = "Brandsta släckers"
                    }
                };
                foreach (var artist in artists)
                {
                    context.Artists.Add(artist);
                }
                context.SaveChanges();

                var songs = new List<Song>()
                {
                    new Song()
                    {
                        SongID = 23,
                        Title = "Sommartider hej hej",
                        Duration = 3.45,
                        Genre = "Pop/Rock"
                    },
                    new Song()
                    {
                        SongID = 45,
                        Title = "Nothing else matters",
                        Duration = 4.56,
                        Genre = "Rock"
                    },
                    new Song()
                    {
                        SongID = 43,
                        Title = "Kom och ta mig",
                        Duration = 3.45,
                        Genre = "Slager"
                    }
                };
                foreach (var song in songs)
                {
                    context.Songs.Add(song);
                }
                context.SaveChanges();
            }
        }
    }
}