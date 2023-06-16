using DAL.CustomMigration;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataContext
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext>options):base(options) 
        {
                
        }
        public DbSet<MySite> MySites { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataSeed.Seed(modelBuilder);    
        }
    }
}
