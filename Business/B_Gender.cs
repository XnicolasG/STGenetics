using DataAccess;
using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Gender
    {
        public List<GenderEntity> GenderList()
        {
            using (var Db = new InventaryContext())
            {
                return Db.GenderT.ToList();
            }

        }
    public void CreateGender(GenderEntity oGender)
    {
        using (var Db = new InventaryContext())
        {
            Db.GenderT.Add(oGender);
            Db.SaveChanges();
        }
    }
    public void UpdateGender(GenderEntity oGender)
        {
            using (var Db = new InventaryContext())
            {
                Db.GenderT.Update(oGender);
                Db.SaveChanges();
            }
        }
    public void RemoveGender(GenderEntity oGender)
        {
            using (var Db = new InventaryContext())
            {
                Db.GenderT.Remove(oGender);
                Db.SaveChanges();
            }
        }

    }
}
