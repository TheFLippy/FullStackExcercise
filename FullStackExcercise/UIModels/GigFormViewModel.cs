using FullStackExcercise.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FullStackExcercise.UIModels
{
    public class GigFormViewModel
    {
        public DateTime GetDateTime()
        {
            return DateTime.Parse($"{Date} {Time}");
        }


        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [ValidTime]
        [Required]
        public string Time { get; set; }

        [Required]
        public byte Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
    }
}