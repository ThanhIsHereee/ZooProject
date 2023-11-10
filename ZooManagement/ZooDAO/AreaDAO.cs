using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDAO
{
    public class AreaDAO
    {
        private static AreaDAO instance = null;
        private AreaDAO() 
        { 
        
        }
        public List<Area> ListArea;
        public List<Area> GetAllListArea()
        {
            try
            {
                var db = new PRN211_ZOOContext();
                return db.Area.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public static AreaDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AreaDAO();
                }
                return instance;
            }

        }
        public Area GetAreaByID(string id)
        {
            var db = new PRN211_ZOOContext();
            return db.Area.SingleOrDefault(m => m.AreaId.Equals(id));

        }
        public void AddArea(Area Area)
        {
            try
            {
                var db = new PRN211_ZOOContext();
                Area NewArea = GetAreaByID(Area.AreaId);
                if (NewArea == null)
                {
                    db.Area.Add(Area);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("AreaID Is Duplicate !");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void RemoveArea(string AreaID)
        {
            try
            {
                var db = new PRN211_ZOOContext();
                Area Area = GetAreaByID(AreaID);
                if (Area != null)
                {
                    db.Area.Remove(Area);
                    db.SaveChanges();
                }
                else
                    throw new Exception("AreaID Is Not Found !");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void UpdateArea(Area AreaID)
        {
            try
            {
                var db = new PRN211_ZOOContext();
                if (AreaID != null)
                {
                    db.Area.Update(AreaID);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("AreaID Is Not Found !");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
