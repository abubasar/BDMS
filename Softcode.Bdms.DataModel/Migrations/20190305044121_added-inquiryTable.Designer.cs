﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Softcode.Bdms.DataModel.Softcode.Bdms.DataModel;

namespace Softcode.Bdms.DataModel.Migrations
{
    [DbContext(typeof(MarketingDbContext))]
    [Migration("20190305044121_added-inquiryTable")]
    partial class addedinquiryTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Softcode.Bdms.DataModel.Softcode.Bdms.DataModel.MarketSoftware", b =>
                {
                    b.Property<int>("InstituteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("DecisionMaker");

                    b.Property<string>("Designation");

                    b.Property<string>("District");

                    b.Property<string>("Email");

                    b.Property<string>("MarketName");

                    b.Property<string>("Mkid");

                    b.Property<string>("Mobile");

                    b.Property<DateTime?>("Rdate");

                    b.Property<string>("Remarks");

                    b.Property<int>("StatusId");

                    b.Property<string>("Telephone");

                    b.Property<string>("WebSite");

                    b.HasKey("InstituteId");

                    b.HasIndex("StatusId");

                    b.ToTable("MarketSoftware");
                });

            modelBuilder.Entity("Softcode.Bdms.DataModel.Softcode.Bdms.DataModel.MarketingStatus", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<string>("StatusName");

                    b.HasKey("StatusId");

                    b.ToTable("MarketingStatus");
                });

            modelBuilder.Entity("Softcode.Bdms.DataModel.Softcode.Bdms.DataModel.MarketSoftware", b =>
                {
                    b.HasOne("Softcode.Bdms.DataModel.Softcode.Bdms.DataModel.MarketingStatus", "Status")
                        .WithMany("MarketSoftware")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}