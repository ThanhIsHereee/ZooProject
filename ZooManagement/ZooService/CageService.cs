using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooRepo;

namespace ZooService
{
    public class CageService : ICageService
    {
        private CageRepository CageRepo;
        public CageService()
        {
            CageRepo = new CageRepository();
        }
        public void AddCage(Cage cage)
        {
            CageRepo.AddCage(cage);
        }

        public void RemoveCage(string id)
        {
            CageRepo.RemoveCage(id);
        }

        public List<Cage> GetAllCages()
        {
            return CageRepo.GetAllCages();
        }

        public Cage GetCageByID(string id)
        {
           return CageRepo.GetCageByID(id);
        }

        public void UpdateCage(Cage cage)
        {
            CageRepo.UpdateCage(cage);
        }
    }
}
