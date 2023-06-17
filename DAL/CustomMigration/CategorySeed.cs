using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CustomMigration
{
    public class CategorySeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id= 1,Name="Nəqliyyat",CategoryId=1
            },
            new Category()
            {
                Id=2,Name="Ev və bağ",CategoryId =2
            },
            new Category()
            {
                Id=3,Name="Elektronika",CategoryId=3
            },
            new Category()
            {
                Id=4,Name="Dasinmaz Emlak",CategoryId=4
            },
            new Category()
            {
                Id=5,Name="Sexsi esyalar",CategoryId=4
            },
            new Category()
            {
                Id=6,Name="Xidmetler ve Biznes",CategoryId=6
            },
            new Category()
            {
                Id=7,Name="Hobbi ve asude",CategoryId=7
            },
            new Category()
            {
                Id=8,Name="Usaq Alemi",CategoryId=8
            },
            new Category()
            {
                Id=9,Name="Heyvanlar",CategoryId=9
            },
            new Category()
            {
                Id=10,Name="Is elanlari",CategoryId=10
            });


        }
    }
}
