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
    public static class ProvinceSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MasterContext(
                serviceProvider.GetRequiredService<DbContextOptions<MasterContext>>()))
            {
                if (context.Provinces.Any())
                {
                    return;   // DB has been seeded
                }

                var path = ProjectEnvironment.rootPath + @"\Province.json";

                //string file = @"D:\Other\Practice\WebAPI\WebApiDemo\src\MasterDatabaseSystem\App_Data\Province.json";
                var provinces = JsonConvert.DeserializeObject<List<Province>>(File.ReadAllText(path));

                context.Provinces.AddRange(provinces);

                context.SaveChanges();
            }

            //using (var context = new ProvinceContext(
            //    serviceProvider.GetRequiredService<DbContextOptions<ProvinceContext>>()))
            //{
            //    if (context.Provinces.Any())
            //    {
            //        return;   // DB has been seeded
            //    }

            //    context.Provinces.AddRange(
            //         new Province
            //         {
            //             ProvinceId = "001",
            //             Name = "Thành phố Hồ Chí Minh",
            //             Region = "Nam bộ",
            //             TelCode = "083",
            //             MapPath = ""
            //         },

            //         new Province
            //         {
            //             ProvinceId = "002",
            //             Name = "Thành phố Vũng Tàu",
            //             Region = "Nam bộ",
            //             TelCode = "083",
            //             MapPath = ""
            //         },

            //         new Province
            //         {
            //             ProvinceId = "003",
            //             Name = "Thành phố Biên Hòa",
            //             Region = "Nam bộ",
            //             TelCode = "083",
            //             MapPath = ""
            //         },

            //       new Province
            //       {
            //           ProvinceId = "004",
            //           Name = "Thành phố Phan Thiết",
            //           Region = "Nam bộ",
            //           TelCode = "083",
            //           MapPath = ""
            //       }
            //    );
            //    context.SaveChanges();
            //}
        }
    }
}
