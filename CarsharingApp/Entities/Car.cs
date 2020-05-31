
namespace Cars.Entities
{
	public class Car : AuditableEntity
	{
		public string Type { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string State { get; set; }

		public Car()
		{

		}

		public Car(string type, string make, string model, string state)
		{
			Type = type;
			Make = make;
			Model = model;
			State = state;
		}
	}
}
