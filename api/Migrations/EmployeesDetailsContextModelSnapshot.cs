﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Models;

namespace api.Migrations
{
    [DbContext(typeof(EmployeesDetailsContext))]
    partial class EmployeesDetailsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("api.Models.EmployeesDetails", b =>
                {
                    b.Property<int>("EmployeesDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("JobId")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("email")
                        .HasColumnType("varchar(100)");

                    b.HasKey("EmployeesDetailId");

                    b.ToTable("EmployeesDetails");
                });
#pragma warning restore 612, 618
        }
    }
}