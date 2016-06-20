using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterDatabaseSystem.Models
{
    public class MasterContext: DbContext
    {
        public MasterContext(DbContextOptions<MasterContext> options)
            : base(options)
        { }

        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }

        public DbSet<School> Schooles { get; set; }
        public DbSet<SchoolCategory> SchoolCategory { get; set; }
    }
}
