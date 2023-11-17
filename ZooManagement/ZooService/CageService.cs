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
        public void AddCage(Cage cage) => CageRepo.AddCage(cage);
        

        public List<Cage> GetAllListCage() => CageRepo.GetAllListCage();
        

        public Cage GetCageById(string CageId)=> CageRepo.GetCageById(CageId);
        

        public void RemoveCage(string cageID) => CageRepo.RemoveCage(cageID);

        public void UpdateCage(Cage cageID) => CageRepo.UpdateCage(cageID);
    }
}
