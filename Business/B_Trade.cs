using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Trade
    {
        public static List<TradeEntity> ListTrade()
        {
            using (var Db = new InventaryContext())
            {
                return Db.TradeT.ToList();
            }
        }
        public static void CreateTrade(TradeEntity oTrade)
        {
            using (var Db = new InventaryContext())
            {
                Db.TradeT.Add(oTrade);
                Db.SaveChanges();
            }
        }
        public static void UpdateTrade(TradeEntity oTrade)
        {
            using (var Db = new InventaryContext())
            {
                Db.TradeT.Update(oTrade);
                Db.SaveChanges();
            }
        }
        public static void RemoveTrade(TradeEntity oTrade)
        {
            using (var Db = new InventaryContext())
            {
                Db.TradeT.Remove(oTrade);
                Db.SaveChanges();
            }
        }
    }
}
