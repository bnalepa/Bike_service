namespace Bike_service.Models
{
    public class BikeRental
    {
        public int BikeId { get; set; }
        public int RentalId { get; set; }




        public Bike? Bike { get; set; }
        public Rental? Rental { get; set; }
    }
}
