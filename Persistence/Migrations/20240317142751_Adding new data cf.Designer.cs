﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240317142751_Adding new data cf")]
    partial class Addingnewdatacf
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.ComprobantesFiscales", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Itebis")
                        .HasColumnType("float");

                    b.Property<double>("Monto")
                        .HasColumnType("float");

                    b.Property<string>("NCF")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RncCedula")
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.HasIndex("RncCedula");

                    b.ToTable("ComprobantesFiscales");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0457f52e-8245-44ea-bb81-21939364c63a"),
                            Itebis = 450.0,
                            Monto = 2500.0,
                            NCF = "E310000000001",
                            RncCedula = "04000175463"
                        },
                        new
                        {
                            Id = new Guid("fa32dbb5-c39a-4e18-b527-7e9558c9325a"),
                            Itebis = 486.0,
                            Monto = 2700.0,
                            NCF = "E310000000002",
                            RncCedula = "045788655"
                        });
                });

            modelBuilder.Entity("Entities.Contributor", b =>
                {
                    b.Property<Guid>("ContributorId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RncCedula")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ContributorId");

                    b.ToTable("Contributors", (string)null);

                    b.HasData(
                        new
                        {
                            ContributorId = new Guid("3cf3f6be-61d4-4568-b423-20ee5db37620"),
                            Name = "CRISTINO ALMANZAR",
                            RncCedula = "04000175463",
                            Status = 1,
                            Type = "PERSONA FISICA"
                        },
                        new
                        {
                            ContributorId = new Guid("0a69f796-861d-4d0d-920e-7906e45f89c6"),
                            Name = "MARIO MARTINEZ",
                            RncCedula = "045788655",
                            Status = 1,
                            Type = "PERSONA FISICA"
                        });
                });

            modelBuilder.Entity("Entities.ComprobantesFiscales", b =>
                {
                    b.HasOne("Entities.Contributor", "Contributor")
                        .WithMany("ComprobantesFiscales")
                        .HasForeignKey("RncCedula")
                        .HasPrincipalKey("RncCedula");

                    b.Navigation("Contributor");
                });

            modelBuilder.Entity("Entities.Contributor", b =>
                {
                    b.Navigation("ComprobantesFiscales");
                });
#pragma warning restore 612, 618
        }
    }
}
