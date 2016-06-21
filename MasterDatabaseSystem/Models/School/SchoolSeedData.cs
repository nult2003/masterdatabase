using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MasterDatabaseSystem.Models
{
    public static class SchoolSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MasterContext(
                serviceProvider.GetRequiredService<DbContextOptions<MasterContext>>()))
            {
                if (context.Schooles.Any())
                {
                    return;   // DB has been seeded
                }

                var path = ProjectEnvironment.rootPath + @"\School.json";
                var schooles = JsonConvert.DeserializeObject<List<School>>(File.ReadAllText(path));

                context.Schooles.AddRange(schooles);

                context.SaveChanges();
            }
            
        }
    }
}
