using Entities; // relation with entities layer
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InventaryContext : DbContext //call to entity, inheritance
    {
        public DbSet<AnimalEntity> AnimalsT { get; set; }
        public DbSet<BreedEntity> BreedT { get; set; }
        public DbSet<GenderEntity> GenderT { get; set; }
        public DbSet<StatusEntity> StatusT { get; set; }
        public DbSet<StorageEntity> StorageT { get; set; }
        public DbSet<WarehouseEntity> WarehouseT { get; set;}
        public DbSet<TradeEntity> TradeT { get; set; }

       protected override void  OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer("Server=SRPIZZA-PC; DataBase=STGDb; User Id=SRPIZZA-PC\nicol ;Trusted_Connection=True; TrustServerCertificate=True ");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //AnimalEntity
            modelBuilder.Entity<AnimalEntity>().HasData
                (
                new AnimalEntity
                {
                    AnimalId = "BR5",
                    AnimalName = "ButterCup",
                    DateOfBirth = new DateTime(2020, 2, 5),
                    AnimalPrice= 4500,
                },
                new AnimalEntity
                {
                    AnimalId = "TP13",
                    AnimalName = "Tommy",
                    DateOfBirth = new DateTime(2019, 8, 13),
                    AnimalPrice = 5200,
                },
                new AnimalEntity
                {
                    AnimalId = "LH6",
                    AnimalName = "Lola",
                    DateOfBirth = new DateTime(2022, 4, 6),
                    AnimalPrice = 2000,
                },
                new AnimalEntity
                {
                    AnimalId = "TL25",
                    AnimalName = "Thor",
                    DateOfBirth = new DateTime(2021, 12, 25),
                    AnimalPrice = 5100,
                },
                new AnimalEntity
                {
                    AnimalId = "DP20",
                    AnimalName = "Delilah",
                    DateOfBirth = new DateTime(2012, 8, 20),
                    AnimalPrice = 2000,
                },
                new AnimalEntity
                {
                    AnimalId = "DH12",
                    AnimalName = "Duke",
                    DateOfBirth = new DateTime(2020, 5, 12),
                    AnimalPrice = 3600,
                },
                new AnimalEntity
                {
                    AnimalId = "GR25",
                    AnimalName = "Ginger",
                    DateOfBirth = new DateTime(2022, 1, 25),
                    AnimalPrice = 2600,
                },
                new AnimalEntity
                {
                    AnimalId = "AW25",
                    AnimalName = "Atlas",
                    DateOfBirth = new DateTime(2014, 7, 25),
                    AnimalPrice = 2300,
                },
                new AnimalEntity
                {
                    AnimalId = "AC23",
                    AnimalName = "Aurora",
                    DateOfBirth = new DateTime(2019, 4, 23),
                    AnimalPrice = 6600,
                },
                new AnimalEntity
                {
                    AnimalId = "MH28",
                    AnimalName = "Maverick",
                    DateOfBirth = new DateTime(2011, 10, 28),
                    AnimalPrice = 1400,
                },
                new AnimalEntity
                {
                    AnimalId = "BS3",
                    AnimalName = "Brutus",
                    DateOfBirth = new DateTime(2018, 11, 3),
                    AnimalPrice = 6100,
                },
                new AnimalEntity
                {
                    AnimalId = "HR14",
                    AnimalName = "Hazel",
                    DateOfBirth = new DateTime(2010, 6, 14),
                    AnimalPrice = 1200,
                },
                new AnimalEntity
                {
                    AnimalId = "MR7",
                    AnimalName = "Molly",
                    DateOfBirth = new DateTime(2020, 11, 7),
                    AnimalPrice = 4700,
                },
                new AnimalEntity
                {
                    AnimalId = "TW8",
                    AnimalName = "Titan",
                    DateOfBirth = new DateTime(2017, 5, 8),
                    AnimalPrice = 6400,
                },
                new AnimalEntity
                {
                    AnimalId = "BP6",
                    AnimalName = "Bella",
                    DateOfBirth = new DateTime(2011, 3, 6),
                    AnimalPrice = 1400,
                },
                new AnimalEntity
                {
                    AnimalId = "MH12",
                    AnimalName = "Maisie",
                    DateOfBirth = new DateTime(2023, 1, 12),
                    AnimalPrice = 2000,
                },
                new AnimalEntity
                {
                    AnimalId = "MS21",
                    AnimalName = "Maximus",
                    DateOfBirth = new DateTime(2022, 12, 21),
                    AnimalPrice = 2800,
                },
                new AnimalEntity
                {
                    AnimalId = "RS19",
                    AnimalName = "Rocky",
                    DateOfBirth = new DateTime(2022, 5, 19),
                    AnimalPrice = 3000,
                },
                new AnimalEntity
                {
                    AnimalId = "CL3",
                    AnimalName = "Clover",
                    DateOfBirth = new DateTime(2021, 7, 3),
                    AnimalPrice = 3800,
                },
                new AnimalEntity
                {
                    AnimalId = "DR1",
                    AnimalName = "Daisy",
                    DateOfBirth = new DateTime(2013, 5, 1),
                    AnimalPrice = 1500,
                }
                );
            //BreedEntity
            modelBuilder.Entity<BreedEntity>().HasData
                (
                new BreedEntity
                {
                    BreedId = Guid.NewGuid().ToString(),
                    BreedName ="Red Angus"
                },
                new BreedEntity
                {
                    BreedId = Guid.NewGuid().ToString(),
                    BreedName = "Piedmontese"
                },
                new BreedEntity
                {
                    BreedId = Guid.NewGuid().ToString(),
                    BreedName = "Limousin"
                },
                new BreedEntity
                {
                    BreedId = Guid.NewGuid().ToString(),
                    BreedName = "Watusi" 
                },
                new BreedEntity
                {
                    BreedId = Guid.NewGuid().ToString(),
                    BreedName = "Charolais"
                },
                new BreedEntity
                {
                    BreedId = Guid.NewGuid().ToString(),
                    BreedName = "Simmental"
                },
                new BreedEntity
                {
                    BreedId = Guid.NewGuid().ToString(),
                    BreedName = "Hereford"
                }
                );
            //GenderEntity
            modelBuilder.Entity<GenderEntity>().HasData
                (
                new GenderEntity
                {
                    GenderId= Guid.NewGuid().ToString(),
                    GenderName ="Male"
                },
                new GenderEntity
                {
                    GenderId = Guid.NewGuid().ToString(),
                    GenderName = "Female"
                }
                );
            //StatusEntity
            modelBuilder.Entity<StatusEntity>().HasData
                (
                new StatusEntity
                {
                    StatusId= Guid.NewGuid().ToString(),
                    StatusName ="Active"
                },
                new StatusEntity
                {
                    StatusId = Guid.NewGuid().ToString(),
                    StatusName = "Inactive"
                }
                );
            
            //WarehouseEntity
            modelBuilder.Entity<WarehouseEntity>().HasData
                (
                new WarehouseEntity
                {
                    WarehouseId= Guid.NewGuid().ToString(),
                    WarehouseName ="Available"
                },
                new WarehouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Sold"
                }
                );
        }

    }
}
