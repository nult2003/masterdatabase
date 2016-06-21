using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterDatabaseSystem.Models
{
    public class SchoolViewModel
    {
        public List<SchoolCategory> categories;
        public SelectList categoryNames;
        public string categoryName { get; set; }

        public List<School> schooles;
    }
}
