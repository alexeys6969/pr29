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
    public class UserContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public UserContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
