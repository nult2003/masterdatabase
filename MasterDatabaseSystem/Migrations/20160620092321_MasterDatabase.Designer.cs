using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MasterDatabaseSystem.Models;

namespace MasterDatabaseSystem.Migrations
{
    [DbContext(typeof(MasterContext))]
    [Migration("20160620092321_MasterDatabase")]
    partial class MasterDatabase
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

            modelBuilder.Entity("MasterDatabaseSystem.Models.School", b =>
                {
                    b.Property<string>("SchoolId");

                    b.Property<string>("Address");

                    b.Property<string>("CategoryId");

                    b.Property<string>("Name");

                    b.Property<string>("ProvinceId");

                    b.Property<string>("Tel");

                    b.Property<string>("Website");

                    b.HasKey("SchoolId");

                    b.ToTable("Schooles");
                });

            modelBuilder.Entity("MasterDatabaseSystem.Models.SchoolCategory", b =>
                {
                    b.Property<string>("SchoolCategoryId");

                    b.Property<string>("Name");

                    b.HasKey("SchoolCategoryId");

                    b.ToTable("SchoolCategory");
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
