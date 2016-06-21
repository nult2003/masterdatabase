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
    public class HospitalController : Controller
    {
        private readonly MasterContext _context;
        public HospitalController(MasterContext context)
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

            /////Hospital
            var hospitals = from m in _context.Hospitals
                             select m;
            
            if (!string.IsNullOrEmpty(provinceName))
            {
                provinces = provinces.Where(s => s.Name.Contains(provinceName));

                hospitals = from m in _context.Hospitals
                                 where m.ProvinceId == provinces.FirstOrDefault().ProvinceId
                                 select m;
            }
            
            var hospitalVM = new HospitalViewModel();
            if (provincenameQuery != null && provinces!=null)
            {
                hospitalVM.provinceNames = new SelectList(provincenameQuery.ToList());
                hospitalVM.provinces = provinces.ToList();
            }
            
            if(hospitals!=null)
            {
                hospitalVM.hospitals = hospitals.ToList();
            }

            return View(hospitalVM);
        }
    }
}
