using DietX.DAL.RepositoryInterfaces;
using DietX.Entities.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.DAL.Repositories
{
    public class UserRepository : BaseRepository<User> ,IUserRepository
    {
    }
}
