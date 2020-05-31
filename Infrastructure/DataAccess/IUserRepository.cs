using Cars.Entities;
using Infrastructure.DataAccess.CRUDInterfaces;
using System.Collections.Generic;

namespace Infrastructure.DataAccess
{ 
    public interface IUserRepository : ICanAddEntity<User>, ICanDeleteEntity<User>, ICanGetEntity<User>, ICanUpdateEntity<User>
    {
        IReadOnlyList<User> GetUserByLastName(string lastName);
    }

}
