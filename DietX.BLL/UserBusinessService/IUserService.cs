using DietX.Entities.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.BLL.UserBusinessService
{
    public interface IUserService
    {
        bool Add(User user);
        bool Update(User user);
        bool Delete(int userId);  //Delete email üzerinden olmalı .Kontrol sağla
        User GetById(int userId);
        List<User> GettAll();
        bool ExistEmail(string email);
        User GetUserByEmail(string email);
        User Login(string email, string password);
        bool IsPasswordValid(string password);
        double CalculateBMIMale(double weight, double height);
        double CalculateBMIFemale(double weight, double height);
    }
}
