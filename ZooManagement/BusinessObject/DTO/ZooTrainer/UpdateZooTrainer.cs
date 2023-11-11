using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO.ZooTrainer
{
    public class UpdateZooTrainer
    {
        public string? UserId { get; set; }
        public string? Fullname { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Phonenumber { get; set; }
        public string? Address { get; set; }
        public string? Experience { get; set; }
    }
}
