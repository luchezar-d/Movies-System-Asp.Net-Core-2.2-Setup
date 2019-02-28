using System;
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
    }
}
