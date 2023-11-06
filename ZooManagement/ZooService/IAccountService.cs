using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooService
{
    public interface IAccountService
    {
        public User GetAccountByMail(string email,string pass);
        bool isValidUserWithRole(string mail, string password, string role);
        public List<User> GetAllListUser();
        public User GetAccountByID(string id);
        public void AddAccount(User user);
        public void RemoveAccount(string UserID);
        public void UpdateAccount(User userID);


    }
}
