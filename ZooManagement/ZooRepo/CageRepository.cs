using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooDAO;

namespace ZooRepo
{
    public class CageRepository : ICageRepository
    {
        public void AddCage(Cage cage)
         => CageDAO.Instance.AddCage(cage);

        public void RemoveCage(string id)
         => CageDAO.Instance.RemoveCage(id);

        public List<Cage> GetAllCages()
         => CageDAO.Instance.GetAllListCage();

        public Cage GetCageByID(string id)
         => CageDAO.Instance.GetCageByID(id);

        public void UpdateCage(Cage cage)
         => CageDAO.Instance.UpdateCage(cage);
    }
}
