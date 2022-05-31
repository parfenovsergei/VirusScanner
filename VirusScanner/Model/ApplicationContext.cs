using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VirusScanner.Model
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ByteSequnce> ByteSequnces { get; set; }
        public ApplicationContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ByteSequnceDB.db");
        }
    }
}
