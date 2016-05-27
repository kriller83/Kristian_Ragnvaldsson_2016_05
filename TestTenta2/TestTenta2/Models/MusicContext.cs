using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestTenta2.Models
{
    public class MusicContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }

        public MusicContext() : base("databas")
        {
            Database.SetInitializer<MusicContext>(new MusicContextInitializer());
        }

        public class MusicContextInitializer : DropCreateDatabaseAlways<MusicContext>
        {
            protected override void Seed(MusicContext context)
            {
                DummyData(context);
            }

            public void DummyData(MusicContext context)
            {
                Artist artist1 = new Artist()
                {
                    ArtistId = 1,
                    Songs = new List<Song>
                    {
                        new Song()
                        {
                            
                        }
                    }
                }
            }
        }
    }
}