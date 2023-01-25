using Bike_service.Data;
using Bike_service.Models;

namespace Bike_service
{
    public class DataSeed
    {
        private readonly AppDBContext _context;

        public DataSeed(AppDBContext context)
        {
            _context = context;
        }

        public void SeedDataContext()
        {

            if (!_context.Customers.Any())
            {
                var customers = new List<Customer>()
            {

                new Customer()

                {
                Name = "Dariusz",
                Surname = "Wilczyński",
                Email = "dariusz.wilczyn@gmail.com",
                Phone = 764238901,

                },

                new Customer()
                {
                Name = "Krzysztof",
                Surname = "Jeż",
                Email = "kjez@gmail.com",
                Phone = 619203103,

                },

            };
                _context.Customers.AddRange(customers);
                _context.SaveChanges();
            };

            //if (!_context.Bikes.Any())
            //{
            //    var bikes = new List<Bike>()
            //{

            //    new Bike()
            //    {
            //    Name = "Rower",
            //    Description = "Szybki",
            //    Type = Bike.Types.miejski,
            //    },
            //    new Bike()
            //    {
            //    Name = "Rower 2",
            //    Description = "Wolny",
            //    Type = Bike.Types.górski,
            //    },
            //};
            //    _context.Bikes.AddRange(bikes);
            //    _context.SaveChanges();
            //};

            //if (!_context.Rentals.Any())
            //{
            //    var rentals = new List<Rental>()
            //{

            //    new Rental()
            //    {
            //    StartDate = DateTime.Parse("2023-01-22"),
            //    EndDate = DateTime.Parse("2023-01-25"),
            //    },
            //};
            //    _context.Rentals.AddRange(rentals);
            //    _context.SaveChanges();
            //};
            //};


            //if (!_context.BikeRentals.Any())
            //{
            //    var bikeRentals = new List<BikeRental>()
            //{
            //    new BikeRental()
            //    {
            //        BikeId = 1,
            //        RentalId = 1,
            //    },


            //};
            //    _context.BikeRentals.AddRange(bikeRentals);
            //    _context.SaveChanges();
            //}

            //if (!_context.CustomerRentals.Any())
            //{
            //    var customerRentals = new List<CustomerRental>()
            //{
            //    new CustomerRental()
            //    {
            //        CustomerId = 2,
            //        RentalId = 1,
            //    },

            //};
            //    _context.CustomerRentals.AddRange(customerRentals);
            //    _context.SaveChanges();
            //}



        }
    }
}
