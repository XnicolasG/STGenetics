using DataAccess;
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
        public List<BreedEntity> BreedList()
        {
            using (var Db = new InventaryContext()) 
            {
                return Db.BreedT.ToList();
            }
        }
    }
}
