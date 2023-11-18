using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooDAO;

namespace ZooRepo
{
    public class CageRepository : ICageReponsitory
    {
        public void AddCage(Cage cage)=>CageAreaDAO.Instance.AddCage(cage);



        //cage



        public List<Cage> GetAllListCage() => CageAreaDAO.Instance.GetAllListCage();

        public Cage GetCageById(string CageId) => CageAreaDAO.Instance.GetCageById(CageId);


        public void RemoveCage(string cageID) => CageAreaDAO.Instance.RemoveCage(cageID);

        public void UpdateCage(Cage cageID) => CageAreaDAO.Instance.UpdateCage(cageID);


        



    }
}
