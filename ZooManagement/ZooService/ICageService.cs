using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooService
{
    public interface ICageService
    {
        public Cage GetCageById(string CageId);
        public List<Cage> GetAllListCage();
        public void AddCage(Cage cage);
        public void RemoveCage(string cageID);
        public void UpdateCage(Cage cageID);
    }
}
