using Cars.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.DataAccess
{
	public class CarsReservationRepository : AuditableRepository<CarsReservation>, ICarsReservationRepository
	{
		private readonly AppDbContext _dbContext;
		public CarsReservationRepository(AppDbContext dbContext) : base (dbContext)
		{
			_dbContext = dbContext;
		}

		public IReadOnlyList<CarsReservation> GetAll()
		{
			return _dbContext.CarsReservation.ToList();
		}
	}
}
