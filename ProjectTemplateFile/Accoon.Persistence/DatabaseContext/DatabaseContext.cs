using Accoon.Application.Interfaces.Database;
using Accoon.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace $safeprojectname$.DatabaseContext
{
    public class DefaultDatabaseContext : DbContext, IDatabaseContext
    {
        // constructor
        public DefaultDatabaseContext(DbContextOptions<DefaultDatabaseContext> options) : base(options)
        {

        }

        // database entities
        public DbSet<Customer> Customers { get; set; }

        // register entity configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DefaultDatabaseContext).Assembly);
        }



    }
}

// Add migrations
// Add-Migration InitMigration -Project $safeprojectname$ -StartupProject Accoon.Api -Context DefaultDatabaseContext
// update-database -Project $safeprojectname$ -StartupProject Accoon.Api