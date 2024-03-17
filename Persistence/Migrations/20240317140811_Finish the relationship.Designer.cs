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
    [Migration("20240317140811_Finish the relationship")]
    partial class Finishtherelationship
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

                    b.Property<Guid?>("ContributorId")
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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContributorId");

                    b.ToTable("ComprobantesFiscales");
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
                            ContributorId = new Guid("6dfd832f-b868-4f76-9c02-67a8dda8fa1d"),
                            Name = "CRISTINO ALMANZAR",
                            RncCedula = "04000175463",
                            Status = 1,
                            Type = "PERSONA FISICA"
                        },
                        new
                        {
                            ContributorId = new Guid("b7395216-f028-40cf-a225-2ed9f4383f3a"),
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
                        .HasForeignKey("ContributorId");

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
