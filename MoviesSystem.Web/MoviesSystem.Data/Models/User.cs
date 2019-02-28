using Microsoft.AspNetCore.Identity;

namespace MoviesSystem.Data.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
    }
}
