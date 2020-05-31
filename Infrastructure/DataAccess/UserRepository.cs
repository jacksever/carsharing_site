using Cars.Entities;
using Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InInfrastructure.DataAccess
{
    public class UserRepository : AuditableRepository<User>, IUserRepository
    {
        private readonly AppDbContext _dbContext;
        public UserRepository (AppDbContext dbContext) : base (dbContext)
        {
            _dbContext = dbContext;
        }

        public IReadOnlyList <User> GetUserByLastName(string name)
        {
            return _dbContext.User.Where(x => x.LastName.ToLower().Contains(name.ToLower())).ToList();
        }

		IReadOnlyList<User> IUserRepository.GetUserByLastName(string lastName)
		{
			throw new NotImplementedException();
		}
	}
}
