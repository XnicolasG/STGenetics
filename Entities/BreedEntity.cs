using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BreedEntity
    {
        [Key]
        [StringLength(50)]
        public string BreedId { get; set; }
        [Required]
        [StringLength(50)]
        public string BreedName { get; set; }

        public ICollection<AnimalEntity> Animals { get; set; }
    }
}
