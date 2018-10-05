using FullStackExcercise.Models;
using System;
using System.Collections.Generic;

namespace FullStackExcercise.UIModels
{
    public class GigFormViewModel
    {
        public DateTime DateTime => DateTime.Parse($"{Date} {Time}");

        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}