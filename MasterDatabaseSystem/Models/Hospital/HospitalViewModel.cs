using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterDatabaseSystem.Models
{
    public class HospitalViewModel
    {
        public List<Province> provinces;
        public SelectList provinceNames;
        public string provinceName { get; set; }

        public List<Hospital> hospitals;
    }
}
