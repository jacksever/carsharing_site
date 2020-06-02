using Cars.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.DataAccess
{
    public class CarsRepository : AuditableRepository<Car>, ICarsRepository
    {
        private readonly AppDbContext _dbContext;
        public CarsRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

		public IReadOnlyList<Car> GetAll()
		{
            return _dbContext.Car.ToList();
        }

		public IReadOnlyList<Car> GetManufacturerByLastName(string name)
        {
            return _dbContext.Car.Where(x => x.Make.ToLower().Contains(name.ToLower())).ToList();
        }

		public IReadOnlyList<Car> GetCarByName(string name)
		{
			throw new NotImplementedException();
		}
	}
}
