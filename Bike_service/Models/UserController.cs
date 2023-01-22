using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Bike_service.Models;

    public class UserController
    {
    [Required(ErrorMessage = "Podaj login!")]
    public string Login {get; set; }
    [DataType(DataType.Password)]
    public string Password {get; set; }
    }
