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
        public Cage GetCageByID(string id);
        public void AddCage(Cage cage);
        public void UpdateCage(Cage cage);
        public void RemoveCage(string id);
        public List<Cage> GetAllCages();
        
    }
}
