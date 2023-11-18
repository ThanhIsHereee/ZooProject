using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooRepo;

namespace ZooService
{
    public class AccountService : IAccountService
    {
        private AccountRepository AccRepo;
        public AccountService()
        {
            AccRepo = new AccountRepository();
        }
        public User GetAccountByMail(string email, string pass)
        {
            try
            {
               User user = AccRepo.GetAccountByMail(email);
                if (user.Pasword.Equals(pass))
                {
                    return user;
                }return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool isValidUserWithRole(string mail, string password, string role)
        {
            User user = AccRepo.GetAccountByMail(mail);
            return user.Pasword.Equals(password) && user.Role == role;
        }
        public List<User> GetAllListUser()
        {
            return AccRepo.GetAllListUser();
        }

        public User GetAccountByID(string id)
        {
            return AccRepo.GetAccountByID(id);
        }

        public void AddAccount(User user)
        {
            AccRepo.AddAccount(user);
        }

        public void RemoveAccount(string UserID)
        {
            AccRepo.RemoveAccount(UserID);
        }

        public void UpdateAccount(User userID)
        {
            AccRepo.UpdateAccount(userID);
        }

        public List<User> GetTrainerACcount()
        {
            return AccRepo.GetTrainerACcount();
        }
    }
}
