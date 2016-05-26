using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TentaASP.NET.Models
{
    public class Song
    {
        [Required]
        public int SongId { get; set; }

        [Required, CheckAttributesSong, StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Title { get; set; }

        [Required, Range(10,4000)]
        public double Duration { get; set; }

        [Required, StringLength(maximumLength:100, MinimumLength = 2)]
        public string Genre { get; set; }

        [Required]
        public int ArtistId { get; set; }
    }

    public class CheckAttributesSong : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            var toCheck = value.ToString().ToLower();
            return !toCheck.Contains("gun") && !toCheck.Contains("knife") && !toCheck.Contains("fight");
        }

        public override string FormatErrorMessage(string field)
        {
            return "Please dont use the words 'gun', 'knife' or 'fight'";
        }
    }
}