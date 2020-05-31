using System;
using CarsReservation.Entities;

namespace Infrastructure.DataAccess
{
	public class CarReservationRepository
	{
		private readonly AppDbContext _dbContext;
		public CarReservationRepository(AddDbContext dbContext) : base (dbContext)
		{
			_dbContext = dbContext;
		}
	}
}
