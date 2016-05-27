using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestTenta2.Models
{
    public class Artist
    {
        [Required]
        public int ArtistId { get; set; }
        [Required, StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Name { get; set; }
        [Required, Range(2, 500)]
        public int Age { get; set; }
        [Required, StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Band { get; set; }
        public List<Song> Songs { get; set; }
    }
}