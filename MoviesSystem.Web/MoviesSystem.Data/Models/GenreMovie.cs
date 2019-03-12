using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesSystem.Data.Models
{
    public class GenreMovie
    {
        public Guid GenreId { get; set; }

        public Genre Genre { get; set; }

        public Guid MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
