using AsanPardakht.CL.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace AsanPardakht.DAL.SQL
{
    public class APDB: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=APDB;Integrated Security=true");
            //  optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["PMDB_ConnectionString"].ConnectionString);

        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
    }
}
