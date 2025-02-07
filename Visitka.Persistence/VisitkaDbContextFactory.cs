using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitka.Persistence
{
    public class VisitkaDbContextFactory : IDesignTimeDbContextFactory<VisitkaDbContext>
    {
        public VisitkaDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VisitkaDbContext>();
            optionsBuilder.UseMySql("server=localhost;database=mauidb;user=root;password=1234",
                new MySqlServerVersion(new Version(8, 0, 30)));

            return new VisitkaDbContext(optionsBuilder.Options);
        }
    }
}
