using Microsoft.EntityFrameworkCore;
using VCA.Models;


namespace VCA.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        { }
        public AppDbContext(DbContextOptions<AppDbContext> options)
              : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=DemoData;Integrated Security=True");
            }


        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the relationship for AlternateComponent entity
        


            // ... Other configurations
        }
        public DbSet<Segment> Segments { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<Registration> Registrations { get; set; }

        public DbSet<Component> Components { get; set; }   
        
        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<AlternateComponent> AlternateComponents { get; set; }

    }

}

