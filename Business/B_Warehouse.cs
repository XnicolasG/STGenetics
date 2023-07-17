using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Warehouse
    {
        public static List<WarehouseEntity> ListWarehouse()
        {
            using (var Db = new InventaryContext())
            {
                return Db.WarehouseT.ToList();
            }
        }
        public static void CreateWarehouse(WarehouseEntity oWarehouse)
        {
            using (var Db = new InventaryContext())
            {
                Db.WarehouseT.Add(oWarehouse);
                Db.SaveChanges();
            }
        }
        public static void UpdateWarehouse(WarehouseEntity oWarehouse)
        {
            using (var Db = new InventaryContext())
            {
                Db.WarehouseT.Update(oWarehouse);
                Db.SaveChanges();
            }
        }
        public static void RemoveWarehouse(WarehouseEntity oWarehouse)
        {
            using (var Db = new InventaryContext())
            {
                Db.WarehouseT.Remove(oWarehouse);
                Db.SaveChanges();
            }
        }
    }
}
