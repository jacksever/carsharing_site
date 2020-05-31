using Cars.Entities;

namespace Infrastructure.DataAccess
{
	public class CarReservationRepository : AuditableRepository<CarsReservation>
	{
		private readonly AppDbContext _dbContext;
		public CarReservationRepository(AppDbContext dbContext) : base (dbContext)
		{
			_dbContext = dbContext;
		}
	}
}
