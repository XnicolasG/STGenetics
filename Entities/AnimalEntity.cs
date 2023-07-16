using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AnimalEntity
    {
        [Key]
        [StringLength(10)]
        public string AnimalId { get; set; }
        [Required]
        [StringLength(100)]
        public string AnimalName { get; set;}
        
        public int AnimalPrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public int TotalQuantity { get; set; }

        //Breed 
        public string BreedId { get; set; }
        public BreedEntity Breed { get; set; }

        //Gender
        public string GenderId { get; set; }
        public GenderEntity Gender { get; set; }

        //Status
        public string StatusId { get; set; }
        public StatusEntity Status { get; set; }

        //Storage relationship
        public ICollection<StorageEntity> Storage { get; set; }
    }
}
