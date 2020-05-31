using Cars.Entities;
using Infrastructure.DataAccess.CRUDInterfaces;

namespace Infrastructure.DataAccess
{
	public interface ICarsReservationRepository : ICanAddEntity<CarsReservation>, ICanDeleteEntity<CarsReservation>, ICanGetEntity<CarsReservation>, ICanUpdateEntity<CarsReservation>
	{
		CarsReservation Get(int id);
		void Add(CarsReservation carsReservation);
		void Update(CarsReservation carsReservation);
	}
}
