using System;

namespace Cars.Entities
{
	public class CarsReservation : AuditableEntity
	{
		public string Destination { get; set; }
		public string Distance { get; set; }
		public string Pay { get; set; }
		public Car Car { get; set; }
		public int CarId { get; set; }
		public User User { get; set; }
		public int UserId { get; set; }

		public CarsReservation()
		{

		}

		public CarsReservation(int carId, string destination, string distance, string pay, int userId)
		{
			CarId = carId;
			Destination = destination;
			Distance = distance;
			Pay = pay;
			UserId = userId;
		}
	}
}
