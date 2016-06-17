using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MasterDatabaseSystem.Models;

namespace MasterDatabaseSystem.Migrations
{
    [DbContext(typeof(ProvinceContext))]
    [Migration("20160616025604_MasterDatabaseSystem")]
    partial class MasterDatabaseSystem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MasterDatabaseSystem.Models.District", b =>
                {
                    b.Property<string>("DistrictId");

                    b.Property<string>("MapPath");

                    b.Property<string>("Name");

                    b.Property<string>("ProvinceId");

                    b.Property<string>("Region");

                    b.HasKey("DistrictId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("MasterDatabaseSystem.Models.Province", b =>
                {
                    b.Property<string>("ProvinceId");

                    b.Property<string>("MapPath");

                    b.Property<string>("Name");

                    b.Property<string>("Region");

                    b.Property<string>("TelCode");

                    b.HasKey("ProvinceId");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("MasterDatabaseSystem.Models.District", b =>
                {
                    b.HasOne("MasterDatabaseSystem.Models.Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId");
                });
        }
    }
}
