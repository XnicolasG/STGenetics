using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Animal
    {
        public static List<AnimalEntity> AnimalList()  //Read
        {
            using(var Db = new InventaryContext())
            {
                return Db.AnimalsT.ToList();
            }
        }
        public static AnimalEntity AnimalById(string id)  //Read
        {
            using (var Db = new InventaryContext())
            {
                return Db.AnimalsT.ToList().LastOrDefault(x=>x.AnimalId== id);
            }
        }
        public static void CreateAnimal(AnimalEntity oAnimal) //Create
        {
            using (var Db = new InventaryContext())
            {
                Db.AnimalsT.Add(oAnimal);
                Db.SaveChanges();
            }
        }
        public static void UpdateAnimal (AnimalEntity oAnimal) //Update
        {
            using (var Db = new InventaryContext())
            {
                Db.AnimalsT.Update(oAnimal);
                Db.SaveChanges();
            }
        }
        public static void RemoveAnimal (AnimalEntity oAnimal) //Remove
        {
            using (var Db = new InventaryContext())
            {
                Db.AnimalsT.Remove(oAnimal);
                Db.SaveChanges();
            }
        }
    }
}
