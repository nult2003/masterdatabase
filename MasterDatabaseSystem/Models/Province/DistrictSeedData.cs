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
    public static class DistrictSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            //var path = Environment.rootPath + @"\District.json";
            using (var context = new MasterContext(
                serviceProvider.GetRequiredService<DbContextOptions<MasterContext>>()))
            {
                if (context.Districts.Any())
                {
                    return;   // DB has been seeded
                }

                var path = ProjectEnvironment.rootPath + @"\District.json";
                //string file = @"D:\Other\Practice\WebAPI\WebApiDemo\src\MasterDatabaseSystem\App_Data\District.json";
                var districtes = JsonConvert.DeserializeObject<List<District>>(File.ReadAllText(path));

                context.Districts.AddRange(districtes);

                context.SaveChanges();
            }

            //using (var context = new ProvinceContext(
            //    serviceProvider.GetRequiredService<DbContextOptions<ProvinceContext>>()))
            //{
            //    if (context.Districts.Any())
            //    {
            //        return;   // DB has been seeded
            //    }

            //    context.Districts.AddRange(
            //         new District
            //         {
            //             DistrictId = "001",
            //             Name = "Quận 1",
            //             Region = "Đông Nam",
            //             MapPath = "",
            //             ProvinceId = "001"
            //         },

            //         new District
            //         {
            //             DistrictId = "002",
            //             Name = "Quận 2",
            //             Region = "Đông Nam",
            //             MapPath = "",
            //             ProvinceId = "001"
            //         },

            //         new District
            //         {
            //             DistrictId = "003",
            //             Name = "Quận 3",
            //             Region = "Đông Nam",
            //             MapPath = "",
            //             ProvinceId = "001"
            //         }


            //    );
            //    context.SaveChanges();
            //}
        }
    }
}
