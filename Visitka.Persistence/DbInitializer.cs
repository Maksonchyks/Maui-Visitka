using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitka.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(VisitkaDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
