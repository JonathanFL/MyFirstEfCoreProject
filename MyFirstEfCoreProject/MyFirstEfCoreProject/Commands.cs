using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using MyFirstEfCoreProject.Model;

namespace MyFirstEfCoreProject
{
    public static class Commands
    {
        public static void ListAll()
        {
            using (var db = new AppDbContext())
            {

                foreach (PC pc in db.PCs)
                {
                    Console.WriteLine($"Price of pc with the specs {pc.price} {pc.Id}, {pc.hd}, {pc.ram}, {pc.productId}, {pc.speed}");
                }
            }
        }


        public static bool WipeCreateSeed(bool onlyIfNoDatabase)
        {
            using (var db = new AppDbContext())
            {
                if (onlyIfNoDatabase && (db.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
                    return false;

                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                if (!db.PCs.Any())
                {
                    WriteTestData(db);
                    Console.WriteLine("Seeded database");
                }
            }
            return true;
        }


        private static void WriteTestData(this AppDbContext db)
        {
            /*var product = new Product
            {
                Id = 1,
                maker = "tech",
                model = "2018",
                type = "PC"
            };*/
            
            var pcs = new List<PC>
            {
                new PC
                {
                    Id = 1,
                    price = 999.95,
                    hd = 500,
                    productId = 23,
                    ram = 4,
                    speed = 2.8
                },
                new PC
                {
                    Id = 1,
                    price = 999.95,
                    hd = 500,
                    productId = 23,
                    ram = 4,
                    speed = 2.8
                },
                new PC
                {
                    Id = 1,
                    price = 999.95,
                    hd = 500,
                    productId = 23,
                    ram = 4,
                    speed = 2.8
                },
                new PC
                {
                    Id = 1,
                    price = 999.95,
                    hd = 500,
                    productId = 23,
                    ram = 4,
                    speed = 2.8
                },
            };

            db.PCs.AddRange(pcs);
            db.SaveChanges();
        }
    }
}
