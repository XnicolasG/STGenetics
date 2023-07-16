using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class GenderEntity
    {
        [Key]
        [StringLength(50)]
        public string GenderId { get; set; }
        [Required]
        [StringLength(50)]
        public string GenderName { get; set; }

        public ICollection<AnimalEntity> Animals { get; set; }

    }
}
