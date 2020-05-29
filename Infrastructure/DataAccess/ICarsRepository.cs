using Cars.Entities;
using Infrastructure.DataAccess.CRUDInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataAccess
{
	public interface ICarsRepository : ICanAddEntity<Car>, ICanUpdateEntity<Car>, ICanGetEntity<Car>
	{
		IReadOnlyList<Car> GetAuthorByLastName(string name);
		IReadOnlyList<Car> GetAll();
		Car Get(int id);
		void Add(Car car);
		void Update(Car car);
		IReadOnlyList<Car> GetCarByName(string name);
	}
}
