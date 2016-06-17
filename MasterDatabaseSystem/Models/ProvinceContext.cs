using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterDatabaseSystem.Models
{
    public class ProvinceContext: DbContext
    {
        public ProvinceContext(DbContextOptions<ProvinceContext> options)
            : base(options)
        { }

        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
    }
}
