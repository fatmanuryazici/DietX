using DietX.DAL;
using DietX.Entities.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DietX.BLL.UserBusinessService
{
    public class UserService : IUserService
    {
        public bool Add(User user)
        {
            if (user == null)
            {
                return false;
            }
            var result = UnitOfWork.Intance.UserRepository.Add(user);
            if (result == null)
            {
                return false;
            }
            return true;
        }


        public bool Delete(int userId)
        {
            var result = UnitOfWork.Intance.UserRepository.Remove(userId);
            if (result == null)
            {
                return false;
            }
            return true;
        }


        public User GetById(int userId)
        {
            return UnitOfWork.Intance.UserRepository.GetbyId(userId);
        }

        public bool Update(User user)
        {
            if (user == null)
            {
                return false;
            }
            var result = UnitOfWork.Intance.UserRepository.Update(user);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public List<User> GettAll()
        {
            return UnitOfWork.Intance.UserRepository.GetAll();
        }
        public bool ExistEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            return UnitOfWork.Intance.UserRepository.GetAll().Any(x => x.Email == email);
        }
        public User Login(string email, string password)
        {
            return UnitOfWork.Intance.UserRepository.GetAll().FirstOrDefault(x => x.Email.Equals(email) && x.Password.Equals(HashPass(password)));
        }

        public User GetUserByEmail(string email)
        {
            return UnitOfWork.Intance.UserRepository.GetAll().FirstOrDefault(x => x.Email ==email);
        }

        public bool IsPasswordValid(string password)
        {
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            return Regex.IsMatch(password, passwordPattern);
        }
        private string HashPass(string sifre)
        {
            var hash = SHA256.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(sifre);
            byte[] hashBytes = hash.ComputeHash(inputBytes);
            return Convert.ToBase64String(hashBytes).Replace("-", "");
        }


        // Female BMI calculation
        public double CalculateBMIFemale(double weight, double height)
        {
            return 10000 * weight / (height * height) * 1.1;        // 10% higher for females
        }

        // Male BMI calculation
        public double CalculateBMIMale(double weight, double height)
        {
            return 10000 * weight / (height * height);
        }

    }
}
