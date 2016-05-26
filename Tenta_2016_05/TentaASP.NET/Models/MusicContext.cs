using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.EnterpriseServices;
using System.Linq;
using System.Web;

namespace TentaASP.NET.Models
{
    public class MusicContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }

        public MusicContext() : base("MusikDb")
        {
            Database.SetInitializer<MusicContext>(new MusicContextInitializer());
        }

        private class MusicContextInitializer : DropCreateDatabaseAlways<MusicContext>
        {
            protected override void Seed(MusicContext context)
            {
                DummyData(context);
            }

            private void DummyData(MusicContext context)
            {

                Artist artist1 = new Artist()
                {
                    ArtistId = 1,
                    Age = 30,
                    Band = "Metallica",
                    Name = "Krille",
                    Songs = new List<Song>
                    {
                        new Song()
                        {
                            ArtistId = 1,
                            Duration = 124,
                            Genre = "Rock",
                            Title = "Highway",
                            SongId = 1,

                        },
                        new Song()
                        {
                            ArtistId = 1,
                            Duration = 120,
                            Genre = "Classic",
                            Title = "Herooow",
                            SongId = 2,
                        }
                    }
                };
                Artist artist2 = new Artist()
                {
                    ArtistId = 2,
                    Age = 23,
                    Band = "Hellacopters",
                    Name = "Jones",
                    Songs = new List<Song>
                    {
                        new Song()
                        {
                            ArtistId = 2,
                            Duration = 178,
                            Genre = "Pop",
                            Title = "Meeeh",
                            SongId = 1,

                        },
                        new Song()
                        {
                            ArtistId = 2,
                            Duration = 120,
                            Genre = "Rock",
                            Title = "Madda",
                            SongId = 2,

                        }
                    }
                };
                  Artist artist3 =  new Artist()
                    {
                        ArtistId = 3,
                        Age = 46,
                        Band = "Busy guitars",
                        Name = "Olaf",
                        Songs = new List<Song>
                        {
                            new Song()
                            {
                                ArtistId = 3,
                                Duration = 156,
                                Genre = "RnB",
                                Title = "Arrrgh",
                                SongId = 1,
                            },
                            new Song()
                            {
                                ArtistId = 3,
                                Duration = 134,
                                Genre = "Spocrck",
                                Title = "running",
                                SongId = 2
                            }
                        }                   
                };
                context.Artists.Add(artist1);
                context.Artists.Add(artist2);
                context.Artists.Add(artist3);
                context.SaveChanges();
            }
        }
    

    }
}