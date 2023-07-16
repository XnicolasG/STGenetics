using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TradeEntity
    {
        [Key]
        [StringLength(50)]
        public string TradeId { get; set; }
        [Required]
        public DateTime TradeDate { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public bool IsInput { get; set; }

        //StoraEntity
        public string StorageId { get; set; }
        public StorageEntity Storages { get; set; }

    }
}
