
namespace Cars.Entities
{
	enum Roles
	{
		Admin = 1,
		User = 2,
		Specials = 3
	}

	public class User : AuditableEntity
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Patronymic {get; set;}
		public int Age { get; set; }
		public string Gender { get; set; }
		public string Email { get; set; }

		public User()
		{

		}

		public User(string firstName, string lastName, string patronymic, int age, string gender, string email)
		{
			FirstName = firstName;
			LastName = lastName;
			Patronymic = patronymic;
			Age = age;
			Gender = gender;
			Email = email;
		}

	}
}
