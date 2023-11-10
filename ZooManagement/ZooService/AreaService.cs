using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooRepo;

namespace ZooService
{
    public class AreaService:IAreaServise
    {
        private AreaRes AreaRepo;
        public AreaService()
        {
            AreaRepo = new AreaRes();
        }
        public void AddArea(Area Area)
        {
            AreaRepo.AddArea(Area);
        }

        public void RemoveArea(string id)
        {
            AreaRepo.RemoveArea(id);
        }

        public List<Area> GetAllAreas()
        {
            return AreaRepo.GetAllAreas();
        }

        public Area GetAreaByID(string id)
        {
            return AreaRepo.GetAreaByID(id);
        }

        public void UpdateArea(Area Area)
        {
            AreaRepo.UpdateArea(Area);
        }
    }
}
