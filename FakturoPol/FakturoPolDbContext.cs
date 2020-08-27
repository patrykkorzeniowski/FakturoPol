using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FakturoPol
{
    public class FakturoPolDbContext : DbContext
    {
        public FakturoPolDbContext()
            : base("name=FakturoPolConnectionString")
        { }
        public virtual DbSet<Kontrahent> Kontrahenci { get; set; }
        public virtual DbSet<Faktura> Faktury { get; set; }

    }


}
