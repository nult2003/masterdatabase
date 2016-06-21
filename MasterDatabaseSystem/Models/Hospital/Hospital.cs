using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterDatabaseSystem.Models
{
    public class Hospital
    {
        public string HospitalId { get; set; }
        public string ProvinceId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }

        public string Tel { get; set; }
    }
}
