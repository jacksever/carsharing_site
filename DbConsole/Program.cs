using Infrastructure.DataAccess;
using Cars.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using InInfrastructure.DataAccess;

namespace DbConsole
{
	//Фабрика для создания объекта контекста базы данных во время разработки
	public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Carsharing;Trusted_Connection=True;", b => b.MigrationsAssembly("Infrastructure"));
            return new AppDbContext(optionsBuilder.Options);
        }
    }


    class Program
    {
        private static readonly AppDbContext _appContext;
        private static ICarsRepository _carsRepository;
		private static IUserRepository _userRepository;
        private static ICarsReservationRepository _carsReservationRepository;
        static Program()
        {
            AppDbContextFactory factory = new AppDbContextFactory();
            _appContext = factory.CreateDbContext(null);
            _carsRepository = new CarsRepository(_appContext);
            _userRepository = new UserRepository(_appContext);
            _carsReservationRepository = new CarsReservationRepository(_appContext);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start!");

            Car cars = new Car("Passenger", "Mercedes-benz", "E320", "Free");
            _carsRepository.Add(cars);
            User user = new User("Anni", "Ritter", "-", 19, "Female", "anni-ritter@yandex.ru");
            _userRepository.Add(user);
            CarsReservation carsReservation = new CarsReservation(cars.Id, "Moscow-City", "12.5 km", "560", user.Id);
            _carsReservationRepository.Add(carsReservation);
        }
    }
}
