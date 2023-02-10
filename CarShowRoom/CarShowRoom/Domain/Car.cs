using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarShowRoom.Domain
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MinLength(8) , MaxLength(8)]
        public string RegNumber { get; set; }
       
        [Required]
        [MaxLength(30)]
        public string Manufacturer { get; set; }

        [Required]
        [MaxLength(30)]
        public string Model { get; set; }

        public string Picture { get; set; }

        public DateTime YearOfManufacture { get; set; }

        [Required]
        [Range(1000 , 300000)]
        public double Price { get; set; }
    }
}
