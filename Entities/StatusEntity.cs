using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StatusEntity
    {
        [Key]
        [StringLength(50)]
        public string StatusId { get; set; }
        [Required]
        [StringLength(50)]
        public string StatusName { get; set; }

        public ICollection<AnimalEntity> Animals { get; set; }

    }
}
