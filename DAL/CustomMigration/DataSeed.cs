using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CustomMigration
{
    public static class DataSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            MySiteSeed.Seed(modelBuilder);
            RoleSeed.Seed(modelBuilder);
            UserSeed.Seed(modelBuilder);
            CategorySeed.Seed(modelBuilder);
        }
    }
}
