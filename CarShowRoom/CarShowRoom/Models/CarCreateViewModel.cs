using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShowRoom.Models
{
    public class CarCreateViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(8) ,MaxLength(8)]
        [Display(Name = "RegNumber")]
        public string RegNumber { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Manufacturer")]
        public string Manufacturer { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [Display(Name = "Car Picture")]
        public string Picture { get; set; }

        [Display(Name = "Year of Manufacture")]
        public DateTime YearOfManufacture { get; set; }

        [Required]
        [Range(1000, 300000 ,ErrorMessage = "Price must be in the specified range")]
        [Display(Name = "Price")]
        public double Price { get; set; }
    }
}
