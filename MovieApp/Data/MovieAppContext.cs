using MovieApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieApp.Data;

public class MovieAppContext : DbContext
{
    public MovieAppContext(DbContextOptions<MovieAppContext> options)
            : base(options)
    {
    }

    public DbSet<Movie> Movie { get; set; }
    public DbSet<Category> Category { get; set; }
}
