using System;
using System.ComponentModel.DataAnnotations;

namespace FullStackExcercise.Models
{
    public class Genre
    {
        public Byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}