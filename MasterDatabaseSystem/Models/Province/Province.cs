using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MasterDatabaseSystem.Models
{
    public class Province
    {
        [Display(Name ="Mã tỉnh")]
        public string ProvinceId { get; set; }

        [Display(Name = "Tên tỉnh")]
        public string Name { get; set; }

        [Display(Name = "Khu vực")]
        public string Region { get; set; }

        [Display(Name = "Mã điện thoại")]
        public string TelCode { get; set; }

        public string MapPath { get; set; }

        public virtual List<District> Districtes { get; set; }
        
    }
}
