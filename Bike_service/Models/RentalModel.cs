using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Bike_service.Models;


public class Rental

{
    //[HiddenInput]
    //public int Id { get; set; }

    [Required(ErrorMessage = "Proszę podać imię!")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Proszę podać nazwisko!")]
    public string Surname { get; set; }
    [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
    [Required(ErrorMessage = "Proszę podać poprawny email!")]
    public string Email { get; set; }
    [Phone]
    [Required(ErrorMessage = "Proszę podać poprawny numer telefonu!")]
    public int Phone { get; set; }
    [Required(ErrorMessage = "Proszę podać poprawny numer telefonu!")]
    [DataType(DataType.Date)]
    public int StartDate { get; set; }
    [DataType(DataType.Date)]
    public int EndDate { get; set; }
}
