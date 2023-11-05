using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDAO
{
    public class LoginDAO
    {
        private static LoginDAO instance = null;
        private LoginDAO()
        {

        }
        public static LoginDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginDAO();
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
    }
}
