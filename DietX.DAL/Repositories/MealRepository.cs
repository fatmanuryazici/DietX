using DietX.DAL.RepositoryInterfaces;
using DietX.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.DAL.Repositories
{
    public class MealRepository : BaseRepository<Meal>, IMealRepository
    {
    }
}
