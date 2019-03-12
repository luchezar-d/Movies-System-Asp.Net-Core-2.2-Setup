using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoviesSystem.Data.Models;

namespace MoviesSystem.Data
{
    public class MoviesSystemDbContext : IdentityDbContext<User>
    {
        public MoviesSystemDbContext(DbContextOptions<MoviesSystemDbContext> options)
            : base(options)
        {
        }
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<UserMovie>()
                .HasKey(x => new { x.UserId, x.MovieId });
            builder
                .Entity<UserMovie>()
                .HasOne(x => x.User)
                .WithMany(m => m.Movies)
                .HasForeignKey(x => x.UserId);
            builder
               .Entity<UserMovie>()
               .HasOne(x => x.Movie)
               .WithMany(u => u.Users)
               .HasForeignKey(x => x.MovieId);

            builder
                .Entity<GenreMovie>()
                .HasKey(x => new { x.GenreId, x.MovieId });
            builder
                .Entity<GenreMovie>()
                .HasOne(x => x.Movie)
                .WithMany(m => m.Genres)
                .HasForeignKey(x => x.MovieId);
            builder
               .Entity<GenreMovie>()
               .HasOne(x => x.Genre)
               .WithMany(u => u.Movies)
               .HasForeignKey(x => x.GenreId);

            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("Users");
            builder.Entity<Role>().ToTable("Roles");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
        }
    }
}
