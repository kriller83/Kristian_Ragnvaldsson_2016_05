using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestTenta2.Models
{
    public class Song
    {
        [Required]
        public int SongId { get; set; }
        [Required, CheckAttributeSong]
        public string Title { get; set; }
        [Required, Range(2,500)]
        public double Duration { get; set; }
        [Required, StringLength(maximumLength:100, MinimumLength = 2)]
        public string Genre { get; set; }
        [Required, StringLength(maximumLength: 100, MinimumLength = 2)]
        public int ArtistId { get; set; }   
    }

    public class CheckAttributeSong : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            var checkWord = value.ToString().ToLower();
            return !checkWord.Contains("gun");
        }
    }
   
}