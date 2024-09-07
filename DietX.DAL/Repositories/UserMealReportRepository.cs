using DietX.DAL.RepositoryInterfaces;
using DietX.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.DAL.Repositories
{
    public class UserMealReportRepository : BaseRepository<UserMealReport>, IUserMealReportRepository
    {
        //public void Test(int userId)
        //{
        //    ApplicationDatabase.Context.Set<UserMealReport>().FirstOrDefault(x => x.UserId==userId);
        //}
    }
}
