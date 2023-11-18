using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDAO
{
    public class AccountDAO
    {
        private static AccountDAO instance = null;
        private AccountDAO()
        {

        }
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
        }
        public User GetAccountByMail(string email)
        {
            try
            {

                var db = new PRN211_ZOOContext();
                return db.User.SingleOrDefault(x => x.Username.Equals(email));


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<User> ListAccount;
        public List<User>  GetAllListUser()
        {
            try
            {
                var db = new PRN211_ZOOContext();
                return db.User.ToList();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public User GetAccountByID(string id)
        {
            var db = new PRN211_ZOOContext();
            return db.User.SingleOrDefault(m=>m.UserId.Equals(id));

        }
        public void AddAccount(User user)
        {
            try
            {
                var db = new PRN211_ZOOContext();
                User NewUser = GetAccountByID(user.UserId);
                if(NewUser == null)
                {
                    db.User.Add(user);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("UserID Is Duplicate !");
                }

            }
            catch( Exception ex )
            {
                throw new Exception(ex.Message);
            }

        }
        public void RemoveAccount(string UserID)
        {
            try
            {
                var db = new PRN211_ZOOContext();
                User user = GetAccountByID(UserID);
                if (user != null)
                {
                   db.User.Remove(user);
                    db.SaveChanges();
                }
                else
                    throw new Exception("UserID Is Not Found !");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void UpdateAccount(User userID)
        {
            try
            {
                var db = new PRN211_ZOOContext();
                if (userID != null)
                {
                    db.User.Update(userID);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("AccountID Is Not Found !");
                }

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public List<User> GetTrainerACcount()
        {
            var db = new PRN211_ZOOContext();
            return db.User.Where(x=>x.Role.Equals("trainer")).ToList();

        }


    }
}
