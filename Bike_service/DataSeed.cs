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

            if (!_context.Bikes.Any())
            {
                var bikes = new List<Bike>()
            {

                new Bike()
                {
                Name = "TREK Domane SLR 7",
                Description = "TREK Domane SLR 7 to wyjątkowo lekki długodystansowy rower szosowy z włókna węglowego wyposażony w wysokiej klasy części stworzone do szybkiej i sprawnej jazdy. Otrzymujesz naszą najlepszą ramę z włókna węglowego OCLV z tylnym rozdzielaczem IsoSpeed, bezprzewodowy elektronicznie sterowany napęd SRAM Force dla precyzyjnej zmiany biegów oraz koła z włókna węglowego OCLV. Ponadto model ten posiada łatwo dostępny schowek na niezbędne rzeczy do jazdy oraz uniwersalny prześwit na opony 38c, który pozwoli lekko sunąć po nierównych drogach i lekkim szutrze.",
                Type = Bike.Types.górski,
                },
                new Bike()
                {
                Name = "TREK Verve 3",
                Description = "TREK Verve 3 Equipped to doskonale prowadzący się rower hybrydowy stworzony z myślą o wygodnym przemieszczaniu się po drogach, ścieżkach i ulicach. Został wyposażony w lekki napęd kategorii szosowej, wygładzający nierówności nawierzchni amortyzowany widelec Forklight 3.0 i sztycę, a także w piastę z prądnicą, zasilającą oświetlenie roweru. Dodatkowo, rower ten został także wyposażony w wiele użytecznych udogodnień, takich jak błotniki, oświetlenie i bagażnik tylny kompatybilny z MIK.",
                Type = Bike.Types.miejski,
                },
                new Bike()
                {
                Name = "TREK FX Sport 5",
                Description = "TREK FX Sport 5 to rower do fitnessu z włókna węglowego dla kogoś, kto szuka połączenia lekkiej szosówki z komfortem i kontrolą płaskiej kierownicy. Ma usprawniony, wysokiej jakości napęd, hydrauliczne hamulce tarczowe i przystosowane do montażu bezdętkowego obręcze, dzięki czemu idealnie się sprawdza zarówno podczas indywidualnych ćwiczeń, jak i szybkich przejażdżek grupowych. ",
                Type = Bike.Types.górski,
                },
                new Bike()
                {
                Name = "TREK Marlin 6",
                Description = "TREK Marlin 6 to idealna maszyna do poprawienia swoich umiejętności na szlaku. Jego ulepszona, bardziej płaska geometria ramy ułatwia zachowanie kontroli na zjazdach, podczas gdy amortyzowany widelec bierze na siebie wyboje na szlaku. Zintegrowane mocowania na bagażnik i nóżkę ułatwiają dodawanie akcesoriów do tej wszechstronnej maszyny.",
                Type = Bike.Types.górski,
                },
            };
                _context.Bikes.AddRange(bikes);
                _context.SaveChanges();
            };

            if (!_context.Rentals.Any())
            {
                var rentals = new List<Rental>()
            {

                new Rental()
                {
                StartDate = DateTime.Parse("2023-01-22"),
                EndDate = DateTime.Parse("2023-01-25"),
                },
            };
                _context.Rentals.AddRange(rentals);
                _context.SaveChanges();
            };



            if (!_context.BikeRentals.Any())
            {
                var bikeRentals = new List<BikeRental>()
            {
                new BikeRental()
                {
                    BikeId = 1,
                    RentalId = 1,
                },


            };
                _context.BikeRentals.AddRange(bikeRentals);
                _context.SaveChanges();
            }

            if (!_context.CustomerRentals.Any())
            {
                var customerRentals = new List<CustomerRental>()
            {
                new CustomerRental()
                {
                    CustomerId = 2,
                    RentalId = 1,
                },

            };
                _context.CustomerRentals.AddRange(customerRentals);
                _context.SaveChanges();
            }



        }
    }
}
