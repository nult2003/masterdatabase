using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterDatabaseSystem.Models
{
    public class District
    {
        [Display(Name = "Mã quận/huyện")]
        public string DistrictId { get; set; }

        [Display(Name = "Tên quận/huyện")]
        public string Name { get; set; }
        public string Region { get; set; }
        public string MapPath { get; set; }
        
        
        public string ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}
