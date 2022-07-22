using Microsoft.EntityFrameworkCore;

namespace KayakRoutesFinalProject.Models
{
    public class GroupContext : DbContext
    {
        public GroupContext(DbContextOptions<GroupContext> options)
                : base(options)
        { }

        public DbSet<GroupFloat> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<GroupFloat>().HasData(
                new GroupFloat
                {
                    GroupId = 1,
                    Contact = "Noah",
                    Phone = "515-555-5589",
                    Location = "Red Rock Lake",
                    StartPoint = "Roberts Creak",
                    StopPoint = "Roberts Creak",
                    Description = "Bring all your own gear and snacks.",
                    Date = "07/23/2022",
                    Time = "10 AM"

                },
                new GroupFloat
                {
                    GroupId = 2,
                    Contact = "Alex",
                    Phone = "641-555-2532",
                    Location = "Red Haw Lake loop",
                    StartPoint = "boat ramp",
                    StopPoint = "boat ramp",
                    Description = "Bring all your own gear, I have a couple extra life jackets.",
                    Date = "07/28/2022",
                    Time = "9 AM"

                },
                new GroupFloat
                {
                    GroupId = 3,
                    Contact = "Leslie",
                    Phone = "515-555-9034",
                    Location = "Raccoon River",
                    StartPoint = "Walnut Woods state Park",
                    StopPoint = "Water Works Park",
                    Description = "Bring your own gear, call KayaksExpress @ 515-555-7756 for rentals! ",
                    Date = "08/10/2022",
                    Time = "12 PM"

                }
                );
        }

    }
}
