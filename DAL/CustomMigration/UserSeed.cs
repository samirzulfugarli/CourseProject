using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CustomMigration
{
    public static class UserSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                Fullname = "Test",
                Username = "Test1",
                Password = "Test1",
                RoleId = 1,
                //Role = new Role()
            },
            new User() 
                {
                Id = 2,
                Fullname = "Test2",
                Username = "Test2",
                Password = "Test2",
                RoleId = 2,
            });


        }
    }
}
