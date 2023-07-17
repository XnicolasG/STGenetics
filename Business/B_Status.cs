using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Status
    {
        public static List<StatusEntity> ListStatus()
        {
            using (var Db = new InventaryContext())
            {
                return Db.StatusT.ToList();
            }
        }
        public static void CreateStatus (StatusEntity oStatus) 
        {
            using (var Db = new InventaryContext())
            {
                Db.StatusT.Add(oStatus);
                Db.SaveChanges();
            }
        }
        public static void UpdateStatus (StatusEntity oStatus) 
        {
            using (var Db = new InventaryContext())
            {
                Db.StatusT.Update(oStatus);
                Db.SaveChanges();
            }
        }
        public static void RemoveStatus (StatusEntity oStatus) 
        {
            using (var Db= new InventaryContext())
            {
                Db.StatusT.Remove(oStatus);
                Db.SaveChanges();
            }
        }
    }
}
