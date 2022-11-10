using Eterna.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet<Setting>Settings { get; set; } 
        public DbSet<TeamPosition>TeamPositions { get; set; }   
        public DbSet<TeamTrainer> TeamTrainers { get; set; }
        public DbSet <Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<PricingService> PricingServices { get; set; }  
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Map>Maps { get; set; }

    }
}
