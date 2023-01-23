using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Bike_service.Models;


public class Rental

{
    [HiddenInput]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Proszę podać poprawną datę początkową!")]
    [DataType(DataType.Date)]
    public int StartDate { get; set; }
    [Required(ErrorMessage = "Proszę podać poprawną datę końcową!")]
    [DataType(DataType.Date)]
    public int EndDate { get; set; }

    public virtual ICollection<BikeRental> BikeRentals { get; set; }
    public virtual ICollection<CustomerRental> CustomerRentals { get; set; }
}
