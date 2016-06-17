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
    public class ProvinceController : Controller
    {
        private readonly ProvinceContext _context;
        public ProvinceController(ProvinceContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index(string provinceName)
        {
            ////Provinces
            IQueryable<string> provincenameQuery = from m in _context.Provinces
                                           orderby m.Name
                                           select m.Name;
            
            var provinces = from m in _context.Provinces
                           select m;

            /////District
            var districtes = from m in _context.Districts
                             select m;
            
            if (!string.IsNullOrEmpty(provinceName))
            {
                provinces = provinces.Where(s => s.Name.Contains(provinceName));

                districtes = from m in _context.Districts
                                 where m.ProvinceId == provinces.FirstOrDefault().ProvinceId
                                 select m;
            }
            
            var provinceVM = new ProvinceViewModel();
            if (provincenameQuery != null && provinces!=null)
            {
                provinceVM.provinceNames = new SelectList(provincenameQuery.ToList());
                provinceVM.provinces = provinces.ToList();
            }
            
            if(districtes!=null)
            {
                provinceVM.districtes = districtes.ToList();
            }

            return View(provinceVM);
        }
    }
}
