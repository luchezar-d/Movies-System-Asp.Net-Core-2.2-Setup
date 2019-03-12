using System;

namespace MoviesSystem.Data.Models
{
    public class UserMovie
    {
        public string UserId { get; set; }

        public User User { get; set; }

        public Guid MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
