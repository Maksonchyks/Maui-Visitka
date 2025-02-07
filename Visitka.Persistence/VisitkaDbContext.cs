using Microsoft.EntityFrameworkCore;
using Visitka.Application;
using Visitka.Domain.Models;
using Visitka.Persistence.EntityTypeConfigurations;
namespace Visitka.Persistence
{
    public class VisitkaDbContext : DbContext, IVisitkaDbContext
    {
        public DbSet<User> Users { get; set; }

        public VisitkaDbContext(DbContextOptions<VisitkaDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            base.OnModelCreating(builder);
        }



    }
}
