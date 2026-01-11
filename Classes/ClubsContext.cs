using Microsoft.EntityFrameworkCore;
using pcClubs.Classes.Common;
using pcClubs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcClubs.Classes
{
    public class ClubsContext : DbContext
    {
        public DbSet<Clubs> Clubs { get; set; }
        public ClubsContext() => Database.EnsureCreated();
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
