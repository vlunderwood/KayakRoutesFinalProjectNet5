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
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Route>().HasData(
                new Route
                {
                    RouteId = 1,
                    Name = "Val",
                    Location = "Skunk River",
                    StartPoint = "Anderson Access",
                    StopPoint = "Sleepy Hollow Access",
                    Type = "River",
                    Miles = 2,
                    Date = "04/05/2022",
                    Level = "Intermediate",
                    Rating = 5,

                },
                new Route
                {
                    RouteId = 2,
                    Name = "Noah",
                    Location = "Raccoon River",
                    StartPoint = "City Park Access",
                    StopPoint = "White Horse Access",
                    Type = "River",
                    Miles = 4,
                    Date = "06/23/2022",
                    Level = "Advanced",
                    Rating = 5,

                },
                new Route
                {
                    RouteId = 3,
                    Name = "Alexander",
                    Location = "Des Moines River",
                    StartPoint = "Skillet Creek Access",
                    StopPoint = "North Fraser Access",
                    Type = "River",
                    Miles = 3,
                    Date = "05/10/2022",
                    Level = "Intermediate",
                    Rating = 5,

                });

        }
    }

}
