using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bike_service.Models
{
    public class Bike
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Proszę podać odpowiednią nazwę!")]

        public string Name { get; set; }
        public enum Type { 
        górski = 1,
        miejski = 2
        }
        [Required(ErrorMessage = "Proszę podać opis!")]
        public string Description { get; set; }

        public virtual ICollection<BikeRental> BikeRentals { get; set; }
    }
}
