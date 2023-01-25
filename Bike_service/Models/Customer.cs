using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bike_service.Models
{
    public class Customer
    {

        [HiddenInput]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać imię!")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Proszę podać nazwisko!")]
        public string Surname { get; set; } = string.Empty;
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        [Required(ErrorMessage = "Proszę podać poprawny email!")]
        public string Email { get; set; } = string.Empty;
        [Phone]
        [Required(ErrorMessage = "Proszę podać poprawny numer telefonu!")]
        public int Phone { get; set; } 

        public virtual ICollection<CustomerRental>? CustomerRentals { get; set; }

    }
}
