using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDAO
{
    public class CageAreaDAO
    {
        private static CageAreaDAO instance = null;
        private CageAreaDAO()
        {

        }
        public static CageAreaDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CageAreaDAO();
                }
                return instance;
            }
        }




        public Cage GetCageById(string CageId)
        {
            try
            {

                var db = new PRN211_ZOOContext();
                return db.Cage.SingleOrDefault(x => x.CageId.Equals(CageId));


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
                Cage NewCage = GetCageById(cage.CageId);
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
        public void RemoveCage(string cageID)
        {
            try
            {   
                var db = new PRN211_ZOOContext();

                Cage cage = GetCageById(cageID);
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
        public void UpdateCage(Cage cageID)
        {
            try
            {
                var db = new PRN211_ZOOContext();
                if (cageID != null)
                {
                    db.Cage.Update(cageID);
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
