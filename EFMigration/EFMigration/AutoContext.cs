using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMigration
{
    public class AutoContext:DbContext
    {
        public DbSet<Auto> autok { get; set; }
        public DbSet<Tulaj> tulajok { get; set; }
    }
}
