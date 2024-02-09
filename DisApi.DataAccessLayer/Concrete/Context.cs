using DisApi.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisApi.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Trusted_Connection = True;TrustServerCertificate=True
            optionsBuilder.UseSqlServer(@"Server = YIGITMONSTER\YIGITSQL;initial catalog=DisApiDb;integrated security=true;TrustServerCertificate=true;");
        }
        public DbSet<Tooth> Teeth { get; set; }
    }
}
