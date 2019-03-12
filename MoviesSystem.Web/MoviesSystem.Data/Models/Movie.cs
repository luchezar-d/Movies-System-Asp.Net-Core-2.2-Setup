using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoviesSystem.Data.Models
{
    public class Movie
    {
        public Movie()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        public DataType ReleaseDate { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 2)]
        public string PosterPath { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 2)]
        public string TrailerPath { get; set; }

        public List<UserMovie> Users { get; set; } = new List<UserMovie>();

        public List<GenreMovie> Genres { get; set; }
    }
}
