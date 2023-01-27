using Microsoft.AspNetCore;
using Bike_service.Data;
using Bike_service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Bike_service.Repository
{
    public class RentalRepository : IRental
    {
        private static AppDBContext _context;

        public RentalRepository(AppDBContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateRental(Rental rental)
        {
            int rentalId;
            Rental rental1 = new Rental()
            {
                StartDate = DateTime.Now,
                EndDate = rental.EndDate,
                BikeRentals = rental.BikeRentals,
                CustomerRentals = rental.CustomerRentals,
            };
            _context.Add(rental1);
            rentalId =_context.Rentals.Max(item => item.Id);
            BikeRental bikeRental = new BikeRental()
            {
                BikeId = 1,
                RentalId = rentalId,
            };

            _context.Add(bikeRental);
            _context.SaveChanges();
            return true;
        }

        public Task<bool> DeleteRental(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Rental>> GetAllRental()
        {
            return await _context.Rentals.ToListAsync();
        }

        public Task<Rental> GetRental(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRental(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
