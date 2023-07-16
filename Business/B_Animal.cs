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
        public List<AnimalEntity> AnimalList()  //Read
        {
            using(var Db = new InventaryContext())
            {
                return Db.AnimalsT.ToList();
            }
        }
        public void CreateAnimal(AnimalEntity oAnimal) //Create
        {
            using (var Db = new InventaryContext())
            {
                Db.AnimalsT.Add(oAnimal);
                Db.SaveChanges();
            }
        }
        public void UpdateAnimal (AnimalEntity oAnimal) //Update
        {
            using (var Db = new InventaryContext())
            {
                Db.AnimalsT.Update(oAnimal);
                Db.SaveChanges();
            }
        }
        public void RemoveAnimal (AnimalEntity oAnimal) //Remove
        {
            using (var Db = new InventaryContext())
            {
                Db.AnimalsT.Remove(oAnimal);
                Db.SaveChanges();
            }
        }
    }
}
