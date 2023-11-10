using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDAO
{
    public class CageDAO
    {
        private static CageDAO instance = null;
        private CageDAO() 
        {
            

        }
        public static CageDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CageDAO();
                }
                return instance;
            }

        }
        public Cage GetCageByID(string id)
        {
            var db = new PRN211_ZOOContext();
            return db.Cage.SingleOrDefault(m => m.CageId.Equals(id));

        }
        public List<Cage> ListCage;
        public List<Cage> GetAllListCage()
        {
            try
            {
                var db = new PRN211_ZOOContext();
                return db.Cage.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public void AddCage(Cage cage)
        {
            try
            {
                var db = new PRN211_ZOOContext();
                Cage NewCage = GetCageByID(cage.CageId);
                if (NewCage == null)
                {
                    db.Cage.Add(cage);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("CageID Is Duplicate !");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void RemoveCage(string CageID)
        {
            try
            {
                var db = new PRN211_ZOOContext();
                Cage cage = GetCageByID(CageID);
                if (cage != null)
                {
                    db.Cage.Remove(cage);
                    db.SaveChanges();
                }
                else
                    throw new Exception("CageID Is Not Found !");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void UpdateCage(Cage CageID)
        {
            try
            {
                var db = new PRN211_ZOOContext();
                if (CageID != null)
                {
                    db.Cage.Update(CageID);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("CageID Is Not Found !");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
