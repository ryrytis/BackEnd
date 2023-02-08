using API0103;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzas1220
{
    public class Context : DbContext
    {
        public DbSet<Passwords> Department { get; set; }
        public DbSet<User> Students { get; set; }
        public DbSet<NewUser> NewUsers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source =OT-RYCIOSUK\\SQLEXPRESS; Initial Catalog = Egzas1220; Integrated Security = True; Connect Timeout = 30; " +
                "Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }
    }
}
