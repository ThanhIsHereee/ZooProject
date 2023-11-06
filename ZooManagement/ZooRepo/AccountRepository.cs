using BusinessObject.Models;
using ZooDAO;

namespace ZooRepo
{
    public class AccountRepository : IAccountRepository
    {
        public void AddAccount(User user)
        =>AccountDAO.Instance.AddAccount(user);

        public User GetAccountByID(string id)
        =>AccountDAO.Instance.GetAccountByID(id);

        public User GetAccountByMail(string email)
        =>AccountDAO.Instance.GetAccountByMail(email);
        public List<User> GetAllListUser()
            =>AccountDAO.Instance.GetAllListUser();

        public void RemoveAccount(string UserID)
        =>AccountDAO.Instance.RemoveAccount(UserID);

        public void UpdateAccount(User userID)
        =>AccountDAO.Instance.UpdateAccount(userID);
    }
}