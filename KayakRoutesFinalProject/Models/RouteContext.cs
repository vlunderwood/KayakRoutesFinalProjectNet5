using Microsoft.EntityFrameworkCore;

namespace KayakRoutesFinalProject.Models
{
    public class RouteContext : DbContext
    {
        public RouteContext(DbContextOptions<RouteContext> options)
                : base(options)
        { }

        public DbSet<Route> Routes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Route>().HasData(
                new Route
                {
                    RouteId = 1,
                    Name = "Val",
                    Location = "Skunk River",
                    Level = "High",
                    Rating = 5,

                },
                new Route
                {
                    RouteId = 2,
                    Name = "Noah",
                    Location = "Chariton River",
                    Level = "Low",
                    Rating = 5,

                },
                new Route
                {
                    RouteId = 3,
                    Name = "Alexander",
                    Location = "Des Moines River",
                    Level = "High",
                    Rating = 5,

                }
                );


        }
    }
}
