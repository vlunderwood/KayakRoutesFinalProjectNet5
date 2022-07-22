using Microsoft.EntityFrameworkCore;

namespace KayakRoutesFinalProject.Models
{
    public class GearContext : DbContext
    {
        public GearContext(DbContextOptions<GearContext> options)
                : base(options)
        { }

        public DbSet<Gear> Gears { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Gear>().HasData(
                 new Gear
                 {
                     GearId = 1,
                     Contact = "Valerie",
                     Phone = "515-555-2462",
                     Description = "1 life jacket, size medium",
                     Condition = "used",
                     Price = "$10.00",

                 },
                 new Gear
                 {
                     GearId = 2,
                     Contact = "Tom",
                     Phone = "641-555-8954",
                     Description = "2 kayaks paddles",
                     Condition = "used",
                     Price = "$50.00 or OBO also open to trade",

                 },
                 new Gear
                 {
                     GearId = 3,
                     Contact = "Leslie",
                     Phone = "515-555-9034",
                     Description = "Pelican sit in kayak",
                     Condition = "used",
                     Price = "$120.00, open to trade",

                 }
                 );
        }

    }
}
