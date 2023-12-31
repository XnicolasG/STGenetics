﻿using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Breed
    {
        public static List<BreedEntity> BreedList() //method bring data
        {
            using (var Db = new InventaryContext()) 
            {
                return Db.BreedT.ToList();
            }
        }

        public  static void CreateBreed(BreedEntity oBreed) //object that save data
        {
            using (var Db = new InventaryContext())
            {
                Db.BreedT.Add(oBreed);
                Db.SaveChanges();
            }
        }

        public static void UpdateBreed(BreedEntity oBreed) //Object that Update data
        {
            using (var Db = new InventaryContext())
            {
                Db.BreedT.Update(oBreed);
                Db.SaveChanges();
            }
        }
        public static void RemoveBreed(BreedEntity oBreed) //Object that Removes data
        {
            using (var Db = new InventaryContext())
            {
                Db.BreedT.Remove(oBreed);
                Db.SaveChanges();
            }
        }
    }
}
