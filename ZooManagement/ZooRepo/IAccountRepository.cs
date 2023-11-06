using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooRepo
{
    public interface IAccountRepository
    {
        public User GetAccountByMail(string email);
        public List<User> GetAllListUser();
        
        public User GetAccountByID(string id);
        public void AddAccount(User user);
        public void RemoveAccount(string UserID);
        public void UpdateAccount(User userID);
    }
}
