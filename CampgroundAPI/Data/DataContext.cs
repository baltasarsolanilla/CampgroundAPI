using CampgroundAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CampgroundAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Campground> Campgrounds { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Geometry> Geometries { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
    }
}
