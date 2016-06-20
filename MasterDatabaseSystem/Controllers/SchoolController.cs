using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting.Server;
using Newtonsoft.Json;
using MasterDatabaseSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MasterDatabaseSystem.Controllers
{
    public class SchoolController : Controller
    {
        private readonly MasterContext _context;
        public SchoolController(MasterContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index(string categoryName)
        {
            ////Provinces
            IQueryable<string> categorynameQuery = from m in _context.SchoolCategory
                                           orderby m.Name
                                           select m.Name;
            
            var categories = from m in _context.SchoolCategory
                           select m;

            /////District
            var schooles = from m in _context.Schooles
                             select m;
            
            if (!string.IsNullOrEmpty(categoryName))
            {
                categories = categories.Where(s => s.Name.Contains(categoryName));

                schooles = from m in _context.Schooles
                                 where m.CategoryId == categories.FirstOrDefault().SchoolCategoryId
                                 select m;
            }
            
            var schoolVM = new SchoolViewModel();
            if (categorynameQuery != null && categories!=null)
            {
                schoolVM.categoryNames = new SelectList(categorynameQuery.ToList());
                schoolVM.categories = categories.ToList();
            }
            
            if(schooles!=null)
            {
                schoolVM.schooles = schooles.ToList();
            }

            return View(schoolVM);
        }
    }
}
