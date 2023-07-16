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
        public List<WarehouseEntity> ListWarehouse()
        {
            using (var Db = new InventaryContext())
            {
                return Db.WarehouseT.ToList();
            }
        }
        public void CreateWarehouse(WarehouseEntity oWarehouse)
        {
            using (var Db = new InventaryContext())
            {
                Db.WarehouseT.Add(oWarehouse);
                Db.SaveChanges();
            }
        }
        public void UpdateWarehouse(WarehouseEntity oWarehouse)
        {
            using (var Db = new InventaryContext())
            {
                Db.WarehouseT.Update(oWarehouse);
                Db.SaveChanges();
            }
        }
        public void RemoveWarehouse(WarehouseEntity oWarehouse)
        {
            using (var Db = new InventaryContext())
            {
                Db.WarehouseT.Remove(oWarehouse);
                Db.SaveChanges();
            }
        }
    }
}
