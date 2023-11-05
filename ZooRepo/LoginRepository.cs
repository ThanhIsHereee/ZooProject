using BusinessObject.Models;
using ZooDAO;

namespace ZooRepo
{
    public class LoginRepository : ILoginRepository
    {
        public User GetAccountByMail(string email)
        =>LoginDAO.Instance.GetAccountByMail(email);
    }
}