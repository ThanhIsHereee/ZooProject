using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooDAO;

namespace ZooRepo
{
    public class AreaRes : IAreaRes
    {
        public void AddArea(Area Area)
         => AreaDAO.Instance.AddArea(Area);

        public void RemoveArea(string id)
         => AreaDAO.Instance.RemoveArea(id);

        public List<Area> GetAllAreas()
         => AreaDAO.Instance.GetAllListArea();

        public Area GetAreaByID(string id)
         => AreaDAO.Instance.GetAreaByID(id);

        public void UpdateArea(Area Area)
         => AreaDAO.Instance.UpdateArea(Area);
    }
}
