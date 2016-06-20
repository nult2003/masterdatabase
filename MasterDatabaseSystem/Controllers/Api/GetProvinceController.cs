using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MasterDatabaseSystem.Models;
using System.Linq;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MasterDatabaseSystem.Controllers.Api
{
    [Route("api/[controller]")]
    public class GetProvinceController : Controller
    {
        public readonly MasterContext _context;
        public GetProvinceController(MasterContext context)
        {
            _context = context;
        }

        // GET: api/ProvinceQuery
        [HttpGet]
        //public IEnumerable<string> GetProvinceAll()
        public IEnumerable<Province> GetAll()
        {
            IQueryable<Province> provinces = from m in _context.Provinces
                                                   select m;
            
            return provinces.ToList();
        }

        // GET api/ProvinceQuery/5
        [HttpGet("{provinceId}")]
        public IEnumerable<Province> GetById(string provinceId)
        {
            IQueryable<Province> provinces = from m in _context.Provinces
                                                     select m;

            if (!string.IsNullOrEmpty(provinceId))
            {
                provinces = provinces.Where(m => m.ProvinceId == provinceId);
            }

            return provinces.ToList();
        }
        
    }
}
