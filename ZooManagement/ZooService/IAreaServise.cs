using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooService
{
    public interface IAreaServise
    {
        public Area GetAreaByID(string id);
        public void AddArea(Area Area);
        public void UpdateArea(Area Area);
        public void RemoveArea(string id);
        public List<Area> GetAllAreas();
    }
}
