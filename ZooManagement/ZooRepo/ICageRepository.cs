using BusinessObject.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooRepo
{
    public interface ICageRepository
    {
        public Cage GetCageByID(string id);
        public void AddCage(Cage cage);
        public void UpdateCage(Cage cage);
        public void RemoveCage(string id);  
        public List<Cage> GetAllCages();
         
    }
}
