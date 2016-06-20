using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MasterDatabaseSystem.Models;
using System.Linq;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MasterDatabaseSystem.Controllers.Api
{
    [Route("api/[controller]")]
    public class GetDistrictController : Controller
    {
        public readonly MasterContext _context;
        public GetDistrictController(MasterContext context)
        {
            _context = context;
        }

        // GET: api/DistrictQuery
        [HttpGet]
        public IEnumerable<District> GetAll()
        {
            IQueryable<District> districtes = from m in _context.Districts
                                                   select m;
            
            return districtes.ToList();
        }

        // GET api/ProvinceQuery/5
        [HttpGet("{id}")]
        public IEnumerable<District> GetById(string id)
        {
            IQueryable<District> districtes = from m in _context.Districts
                                              select m;

            if (!string.IsNullOrEmpty(id))
            {
                districtes = districtes.Where(m => m.DistrictId == id);
            }

            return districtes.ToList();
        }
        
    }
}
