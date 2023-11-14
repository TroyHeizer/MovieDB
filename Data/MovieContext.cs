using Microsoft.EntityFrameworkCore;

namespace MovieDB.Data
{
    public class MovieDataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MovieDataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("MovieDB"));
        }

        public DbSet<Movie> Movies { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .ToTable("Movie");

                modelBuilder.Entity<Movie>()
                    .HasData(
                new Movie { Id = 1, MovieName = "Sherlock Holmes and the Secret Weapon", MovieGenre = "Crime|Mystery|Thriller", ReleaseDate = "09/29/2004"},
                new Movie { Id = 2, MovieName = "Lady and the Tramp", MovieGenre = "Animation|Children|Comedy|Romance", ReleaseDate = "09/05/1970"},
                new Movie { Id = 3, MovieName = "Collision: Christopher Hitchens vs. Douglas Wilson", MovieGenre = "Documentary", ReleaseDate = "12/04/1987"},
                new Movie { Id = 4, MovieName = "Cooking Up Dreams (De ollas y sueños)", MovieGenre = "Documentary", ReleaseDate = "12/14/2013"},
                new Movie { Id = 5, MovieName = "Merry Madagascar", MovieGenre = "Animation", ReleaseDate = "04/13/1953"},
                new Movie { Id = 6, MovieName = "Sleeper", MovieGenre = "Comedy|Sci-Fi", ReleaseDate = "07/02/2022"},
                new Movie { Id = 7, MovieName = "Article 99", MovieGenre = "Comedy|Drama", ReleaseDate = "05/21/1974"},
                new Movie { Id = 8, MovieName = "Battle in Outer Space", MovieGenre = "Adventure|Sci-Fi", ReleaseDate = "10/06/1990"},
                new Movie { Id = 9, MovieName = "The Pirates of Blood River", MovieGenre = "Action|Adventure|Comedy", ReleaseDate = "05/11/2009"},
                new Movie { Id = 10, MovieName = "Fun Size", MovieGenre = "Comedy", ReleaseDate = "06/30/1966"},
                new Movie { Id = 11, MovieName = "Lenny", MovieGenre = "Drama", ReleaseDate = "11/19/2011"},
                new Movie { Id = 12, MovieName = "Sonny", MovieGenre = "Crime|Drama", ReleaseDate = "06/12/1956"},
                new Movie { Id = 13, MovieName = "The Loft", MovieGenre = "Thriller", ReleaseDate = "06/11/2001"},
                new Movie { Id = 14, MovieName = "Sunshine", MovieGenre = "Adventure|Drama|Sci-Fi|Thriller", ReleaseDate = "11/16/1978"},
                new Movie { Id = 15, MovieName = "One Crazy Summer", MovieGenre = "Comedy", ReleaseDate = "07/15/2000"},
                new Movie { Id = 16, MovieName = "Prophet's Prey", MovieGenre = "Crime|Documentary", ReleaseDate = "11/05/1973"},
                new Movie { Id = 17, MovieName = "Confidentially Yours (Vivement dimanche!)", MovieGenre = "Comedy|Crime|Mystery|Thriller", ReleaseDate = "03/24/1958"},
                new Movie { Id = 18, MovieName = "Librarian: Quest for the Spear", MovieGenre = "Action|Adventure|Comedy|Fantasy|Romance", ReleaseDate = "12/05/2004"},
                new Movie { Id = 19, MovieName = "The Power and the Glory", MovieGenre = "Drama", ReleaseDate = "03/30/1950"},
                new Movie { Id = 20, MovieName = "Lupin the 3rd", MovieGenre = "Action|Adventure|Comedy", ReleaseDate = "10/08/1966"},
                new Movie { Id = 21, MovieName = "Dream (Bi-mong)", MovieGenre = "Drama|Fantasy|Mystery|Romance", ReleaseDate = "07/04/1986"},
                new Movie { Id = 22, MovieName = "Neds", MovieGenre = "Drama", ReleaseDate = "02/17/2020"},
                new Movie { Id = 23, MovieName = "Bodyguard", MovieGenre = "Drama|Romance|Thriller", ReleaseDate = "11/25/1992"},
                new Movie { Id = 24, MovieName = "Austin High", MovieGenre = "Comedy", ReleaseDate = "05/07/2010"},
                new Movie { Id = 25, MovieName = "Vision (Vision - Aus dem Leben der Hildegard von Bingen)", MovieGenre = "Drama", ReleaseDate = "10/12/2013"},
                new Movie { Id = 26, MovieName = "Reconstruction (Anaparastasi)", MovieGenre = "Crime|Drama", ReleaseDate = "03/19/2022"},
                new Movie { Id = 27, MovieName = "Fever Pitch", MovieGenre = "Comedy|Romance", ReleaseDate = "09/10/1973"},
                new Movie { Id = 28, MovieName = "Holocaust", MovieGenre = "Drama|Romance|War", ReleaseDate = "09/06/1958"},
                new Movie { Id = 29, MovieName = "Black Moon", MovieGenre = "Horror", ReleaseDate = "05/14/1964"},
                new Movie { Id = 30, MovieName = "Witches of Eastwick", MovieGenre = "Comedy|Fantasy|Horror|Thriller", ReleaseDate = "06/12/1987"}
                 );
         }
    }
}