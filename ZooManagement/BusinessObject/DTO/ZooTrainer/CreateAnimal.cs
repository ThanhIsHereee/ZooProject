using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO.ZooTrainer
{
    public class CreateAnimal
    {
        public string id {  get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string speciesId { get; set; }
        public bool gender { get; set; }
        public string dob { get; set; }
    }
}
