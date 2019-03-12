using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MoviesSystem.Data.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<UserMovie> Movies { get; set; } = new List<UserMovie>();


    }
}
