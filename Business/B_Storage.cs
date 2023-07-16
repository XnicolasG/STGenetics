using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Storage
    {
        public List<StorageEntity> ListStorage()
        {
            using (var Db = new InventaryContext())
            {
                return Db.StorageT.ToList();
            }
        }
        public void CreateStorage(StorageEntity oStorage)
        {
            using (var Db = new InventaryContext())
            {
                Db.StorageT.Add(oStorage);
                Db.SaveChanges();
            }
        }
        public void UpdateStorage(StorageEntity oStorage)
        {
            using (var Db = new InventaryContext())
            {
                Db.StorageT.Update(oStorage);
                Db.SaveChanges();
            }
        }
        public void RemoveStorage(StorageEntity oStorage)
        {
            using (var Db = new InventaryContext())
            {
                Db.StorageT.Remove(oStorage);
                Db.SaveChanges();
            }
        }
    }
}
