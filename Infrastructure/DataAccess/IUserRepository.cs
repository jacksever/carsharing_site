using System;
using System.Collections.Generic;
using System.ComponentModel;
using User.Entities;

namespace Infrastructure.DataAccess
{ 
    public interface IUserRepository : ICanAddEntity<User>, ICanDeleteEntity<User>, ICanGetEntity<User>, ICanUpdateEntity<User>
    {
        IReadOnlyList<User> GetUserByLastName(string lastName);
    }

}
