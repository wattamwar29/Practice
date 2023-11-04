using Microsoft.EntityFrameworkCore;
namespace MovieApp.Models
{
    public class MovieContext:DbContext
    {
        public virtual DbSet<Movie> Movies{get;set;}
        public virtual DbSet<Detail> Details{get;set;}
        public MovieContext(){}
        public MovieContext(DbContextOptions<MovieContext>options):base(options)
        {}
        protected override void OnConfiguring(DbContextOptionBuilder optionBuilder)
        {
            
        }
    }
}