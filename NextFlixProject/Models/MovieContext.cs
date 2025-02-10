using Microsoft.EntityFrameworkCore;
namespace NextFlixProject.Models
{
    public class MovieContext : DbContext
    {
        // DbSet<Movie> Movies is a property that represents a collection of all Movie objects
        public DbSet<Movie> Movies { get; set; } = null!;

        public DbSet<Genre> Genres { get; set; } = null!;

        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                    new Genre() { GenreId = "D", Name = "Drama" },
                    new Genre() { GenreId = "C", Name = "Comedy" },
                    new Genre() { GenreId = "A", Name = "Action" },
                    new Genre() { GenreId = "H", Name = "Horror" },
                    new Genre() { GenreId = "M", Name = "Musical" },
                    new Genre() { GenreId = "R", Name = "RomCom" },
                    new Genre() { GenreId = "S", Name = "SciFi" }
                    );
            modelBuilder.Entity<Movie>().HasData(
                    new Movie() { MovieId = 1, MovieName = "The Godfather", Year = 1972, Rating = 4, GenreId = "D"},
                    new Movie() { MovieId = 2, MovieName = "Breaking Bad", Year = 2008, Rating = 5, GenreId = "D" },
                    new Movie() { MovieId = 3, MovieName = "The Dark Knight", Year = 2008, Rating = 5, GenreId = "A" }
                    );
        }
    }

}
