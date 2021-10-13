using Microsoft.EntityFrameworkCore;
using MoviesWeb.Models;

namespace MoviesWeb.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}
