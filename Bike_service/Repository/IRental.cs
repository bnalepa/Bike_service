using Bike_service.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bike_service.Repository
{
    public interface IRental
    {
        Task<bool> CreateRental(Rental rental);
        Task<bool> UpdateRental(Rental rental);
        Task<bool> DeleteRental(int id);
        Task<Rental> GetRental(int id);
        Task<ICollection<Rental>> GetAllRental();
        
    }
}
