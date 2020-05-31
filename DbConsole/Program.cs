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
        static Program()
        {
            AppDbContextFactory factory = new AppDbContextFactory();
            _appContext = factory.CreateDbContext(null);
            _carsRepository = new CarsRepository(_appContext);
            _userRepository = new UserRepository(_appContext);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start!");

            Car cars = new Car("Passenger", "Ford", "Focus", "Free");
            _carsRepository.Add(cars);
            User user = new User("Jack", "Sever", "-", 19, "Male", "jack.sever@yandex.ru");
            _userRepository.Add(user);
        }
    }
}
