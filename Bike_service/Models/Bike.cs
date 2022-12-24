using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bike_service.Models;


public class Bike

{
    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required(ErrorMessage ="Enter valid name!")]
    [StringLength(50)]
    public string Name { get; set; }
    public int FrameLength { get; set; }
    public string TyreType { get; set; }
    public int WheelSize { get; set; }

    public string BikeType { get; set;}

    [DataType(DataType.Date)]
    public DateTime RepairOrderStart { get; set; }
    [DataType( DataType.Date )]
    public DateTime RepairOrderFinish { get; set; }


}
