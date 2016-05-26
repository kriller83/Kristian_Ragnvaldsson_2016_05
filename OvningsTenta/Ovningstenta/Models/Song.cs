using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ovningstenta.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public string Title { get; set; }
        public double Duration { get; set; }
        public string Genre { get; set; }   
    }
}