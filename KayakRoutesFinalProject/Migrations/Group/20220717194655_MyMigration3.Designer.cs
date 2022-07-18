﻿// <auto-generated />
using KayakRoutesFinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KayakRoutesFinalProject.Migrations.Group
{
    [DbContext(typeof(GroupContext))]
    [Migration("20220717194655_MyMigration3")]
    partial class MyMigration3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KayakRoutesFinalProject.Models.GroupFloat", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StopPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            Contact = "Noah",
                            Date = "07/23/2022",
                            Description = "Bring all your own gear and snacks.",
                            Location = "Red Rock Lake",
                            Phone = "515-555-5589",
                            StartPoint = "Roberts Creak",
                            StopPoint = "Roberts Creak",
                            Time = "10 AM"
                        },
                        new
                        {
                            GroupId = 2,
                            Contact = "Alex",
                            Date = "07/28/2022",
                            Description = "Bring all your own gear, I have a couple extra life jackets.",
                            Location = "Red Haw Lake loop",
                            Phone = "641-555-2532",
                            StartPoint = "boat ramp",
                            StopPoint = "boat ramp",
                            Time = "9 AM"
                        },
                        new
                        {
                            GroupId = 3,
                            Contact = "Leslie",
                            Date = "08/10/2022",
                            Description = "Bring your own gear, call KayaksExpress @ 515-555-7756 for rentals! ",
                            Location = "Raccoon River",
                            Phone = "515-555-9034",
                            StartPoint = "Walnut Woods state Park",
                            StopPoint = "Water Works Park",
                            Time = "12 PM"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
