namespace Bike_service.Models
{
    public class CustomerRental
    {
        public int CustomerId { get; set; }
        public int RentalId { get; set; }




        public Customer? Customer { get; set; }
        public Rental? Rental { get; set; }
    }
}

