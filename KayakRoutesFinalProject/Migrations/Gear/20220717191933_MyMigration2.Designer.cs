﻿// <auto-generated />
using KayakRoutesFinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KayakRoutesFinalProject.Migrations.Gear
{
    [DbContext(typeof(GearContext))]
    [Migration("20220717191933_MyMigration2")]
    partial class MyMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KayakRoutesFinalProject.Models.Gear", b =>
                {
                    b.Property<int>("GearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GearId");

                    b.ToTable("Gears");

                    b.HasData(
                        new
                        {
                            GearId = 1,
                            Condition = "used",
                            Contact = "Valerie",
                            Description = "1 life jacket, size medium",
                            Phone = "515-555-2462",
                            Price = "$10.00"
                        },
                        new
                        {
                            GearId = 2,
                            Condition = "used",
                            Contact = "Tom",
                            Description = "2 kayaks paddles",
                            Phone = "641-555-8954",
                            Price = "$50.00 or OBO also open to trade"
                        },
                        new
                        {
                            GearId = 3,
                            Condition = "used",
                            Contact = "Leslie",
                            Description = "Pelican sit in kayak",
                            Phone = "515-555-9034",
                            Price = "$120.00, open to trade"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
