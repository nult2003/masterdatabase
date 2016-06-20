using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MasterDatabaseSystem.Models
{
    public class School
    {
        public  string SchoolId { get; set; }

        public string CategoryId { get; set; }

        [Display(Name="Tên Trường")]
        public string Name { get; set; }

        public string ProvinceId { get; set; }

        [Display(Name="Địa chỉ")]
        public string Address { get; set; }

        [Display(Name="Điện thoại")]
        public string Tel { get; set; }

        [Display(Name="Trang web")]
        public string Website { get; set; }
    }
}
