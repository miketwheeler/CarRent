using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        [Required]
        [StringLength(4, MinimumLength = 2)]
        public int Year { get; set; }

        public int ModelId { get; set; }

        public virtual Model Model { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public int MakeId { get; set; }
        
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public virtual Make Make { get; set; }
        
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public virtual Color Color { get; set; }

        public int ColorId { get; set; }

        [Required]
        [StringLength(10)]
        public string Vin { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 8)]
        public string LicensePlateNumber { get; set; }

        [Required]
        public double RentalRate { get; set; }
        
        public virtual List<Booking> Bookings { get; set; }

    }
}
