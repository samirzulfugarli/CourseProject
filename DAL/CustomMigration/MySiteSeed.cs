using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CustomMigration
{
    public static class MySiteSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MySite>().HasData(new MySite()
            {
                Id = 1,Name="Turbo.az"
            },
            new MySite()
            {
                Id=2,Name="Bina.az"
            },
            new MySite()
            {
                Id=3,Name="Boss.az"
            });

        }
    }
}
