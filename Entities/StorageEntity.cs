using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }
        [Required]
        public DateTime LastUpdate { get; set; }
        [Required]
        public int PartialQuantity { get; set; }

        //animalEntity
        public string AnimalId { get; set; }
        public AnimalEntity Animal { get; set; }

        //WarehouseEntity
        public string WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }

        //TradeEntity
        public ICollection<TradeEntity> Trades { get; set; }
    }
}
