using Cars.Entities;
using Infrastructure.DataAccess.CRUDInterfaces;
using System.Collections.Generic;

namespace Infrastructure.DataAccess
{
	public interface ICarsReservationRepository : ICanAddEntity<CarsReservation>, ICanDeleteEntity<CarsReservation>, ICanGetEntity<CarsReservation>, ICanUpdateEntity<CarsReservation>
	{
		CarsReservation Get(int id);
		void Add(CarsReservation carsReservation);
		void Update(CarsReservation carsReservation);

		IReadOnlyList<CarsReservation> GetAll();
	}
}
