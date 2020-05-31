using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using User.Entities;

namespace InInfrastructure.DataAccess
{
    public class UserRepository : AuditableRepository<User>, IUserRepository
    {
        private readonly AppDbContext _dbContext;
        public UserRepository (AddDbContext dbContext) : base (dbContext)
        {
            _dbContext = dbContext;
        }

        public IReadOnlyList <User> GetUserByLastName(string name)
        {
            return _dbContext.User.Where(x => x.LastName.ToLower().Contains(name.ToLower())).ToList();
        }

    }
}
