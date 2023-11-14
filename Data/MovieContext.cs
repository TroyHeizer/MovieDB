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
    }
}