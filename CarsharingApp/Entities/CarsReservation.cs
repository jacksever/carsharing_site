
namespace Cars.Entities
{
	public class CarsReservation : AuditableEntity
	{
		public string Destination { get; set; }
		public string Distance { get; set; }
		public string Pay { get; set; }

		//public User User { get; set; }
		public Car Car { get; set; }
		public int CarId { get; set; }

		public CarsReservation()
		{

		}

		public CarsReservation(int id, string destination, string distance, string pay)
		{
			CarId = id;
			Destination = destination;
			Distance = distance;
			Pay = pay;
		}
	}
}
