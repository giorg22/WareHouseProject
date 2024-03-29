﻿// <auto-generated />
using System;
using Data.Access;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Entities.AccountentTree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountentTreeId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FullCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountentTreeId");

                    b.HasIndex("Code")
                        .IsUnique()
                        .HasFilter("[Code] IS NOT NULL");

                    b.HasIndex("FullCode")
                        .IsUnique()
                        .HasFilter("[FullCode] IS NOT NULL");

                    b.ToTable("AccountentTrees", "acnt");
                });

            modelBuilder.Entity("Data.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Brands", "brnd");
                });

            modelBuilder.Entity("Data.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Colors", "clrs");
                });

            modelBuilder.Entity("Data.Entities.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Course")
                        .HasColumnType("int");

                    b.Property<int?>("FirstMoneyUnitId")
                        .HasColumnType("int");

                    b.Property<int?>("SecondMoneyUnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FirstMoneyUnitId");

                    b.HasIndex("SecondMoneyUnitId");

                    b.ToTable("Currencies", "crcy");
                });

            modelBuilder.Entity("Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountentTreeCodeId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GenderId")
                        .HasColumnType("int");

                    b.Property<int?>("JobPositionId")
                        .HasColumnType("int");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NationalityId")
                        .HasColumnType("int");

                    b.Property<string>("PersonalNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountentTreeCodeId");

                    b.HasIndex("GenderId");

                    b.HasIndex("JobPositionId");

                    b.HasIndex("NationalityId");

                    b.ToTable("Employees", "empl");
                });

            modelBuilder.Entity("Data.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Genders", "gndr");
                });

            modelBuilder.Entity("Data.Entities.JobPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("JobPositions", "jbps");
                });

            modelBuilder.Entity("Data.Entities.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers", "mnfc");
                });

            modelBuilder.Entity("Data.Entities.MoneyUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MoneyUnits", "mnun");
                });

            modelBuilder.Entity("Data.Entities.Nationality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Nationalities", "brnd");
                });

            modelBuilder.Entity("Data.Entities.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountentTreeCodeId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GPSAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationTypeId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebSite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountentTreeCodeId");

                    b.ToTable("Organizations", "orgn");
                });

            modelBuilder.Entity("Data.Entities.OrganizationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("OrganizationTypes", "orgt");
                });

            modelBuilder.Entity("Data.Entities.Origin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Origins", "orgn");
                });

            modelBuilder.Entity("Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountentTreeCodeId")
                        .HasColumnType("int");

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoxCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("EnglishName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InitialCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<int?>("MoneyUnitId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OriginId")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ProcutTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<double>("SelfCost")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AccountentTreeCodeId");

                    b.HasIndex("BrandId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("MoneyUnitId");

                    b.HasIndex("OriginId");

                    b.HasIndex("ProcutTypeId");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products", "prdc");
                });

            modelBuilder.Entity("Data.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories", "prct");
                });

            modelBuilder.Entity("Data.Entities.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes", "prdt");
                });

            modelBuilder.Entity("Data.Entities.WareHouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountentTreeCodeId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Report")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountentTreeCodeId");

                    b.HasIndex("ManagerId");

                    b.ToTable("WareHouses", "wrhs");
                });

            modelBuilder.Entity("Data.Entities.AccountentTree", b =>
                {
                    b.HasOne("Data.Entities.AccountentTree", null)
                        .WithMany("ChildrenTree")
                        .HasForeignKey("AccountentTreeId");
                });

            modelBuilder.Entity("Data.Entities.Currency", b =>
                {
                    b.HasOne("Data.Entities.MoneyUnit", "FirstMoneyUnit")
                        .WithMany()
                        .HasForeignKey("FirstMoneyUnitId");

                    b.HasOne("Data.Entities.MoneyUnit", "SecondMoneyUnit")
                        .WithMany()
                        .HasForeignKey("SecondMoneyUnitId");

                    b.Navigation("FirstMoneyUnit");

                    b.Navigation("SecondMoneyUnit");
                });

            modelBuilder.Entity("Data.Entities.Employee", b =>
                {
                    b.HasOne("Data.Entities.AccountentTree", "AccountentTreeCode")
                        .WithMany()
                        .HasForeignKey("AccountentTreeCodeId");

                    b.HasOne("Data.Entities.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId");

                    b.HasOne("Data.Entities.JobPosition", "JobPosition")
                        .WithMany()
                        .HasForeignKey("JobPositionId");

                    b.HasOne("Data.Entities.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId");

                    b.Navigation("AccountentTreeCode");

                    b.Navigation("Gender");

                    b.Navigation("JobPosition");

                    b.Navigation("Nationality");
                });

            modelBuilder.Entity("Data.Entities.Organization", b =>
                {
                    b.HasOne("Data.Entities.AccountentTree", "AccountentTreeCode")
                        .WithMany()
                        .HasForeignKey("AccountentTreeCodeId");

                    b.Navigation("AccountentTreeCode");
                });

            modelBuilder.Entity("Data.Entities.Product", b =>
                {
                    b.HasOne("Data.Entities.AccountentTree", "AccountentTreeCode")
                        .WithMany()
                        .HasForeignKey("AccountentTreeCodeId");

                    b.HasOne("Data.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("Data.Entities.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");

                    b.HasOne("Data.Entities.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId");

                    b.HasOne("Data.Entities.MoneyUnit", "MoneyUnit")
                        .WithMany()
                        .HasForeignKey("MoneyUnitId");

                    b.HasOne("Data.Entities.Origin", "Origin")
                        .WithMany()
                        .HasForeignKey("OriginId");

                    b.HasOne("Data.Entities.ProductType", "ProcutType")
                        .WithMany()
                        .HasForeignKey("ProcutTypeId");

                    b.HasOne("Data.Entities.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId");

                    b.Navigation("AccountentTreeCode");

                    b.Navigation("Brand");

                    b.Navigation("Color");

                    b.Navigation("Manufacturer");

                    b.Navigation("MoneyUnit");

                    b.Navigation("Origin");

                    b.Navigation("ProcutType");

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("Data.Entities.WareHouse", b =>
                {
                    b.HasOne("Data.Entities.AccountentTree", "AccountentTreeCode")
                        .WithMany()
                        .HasForeignKey("AccountentTreeCodeId");

                    b.HasOne("Data.Entities.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");

                    b.Navigation("AccountentTreeCode");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Data.Entities.AccountentTree", b =>
                {
                    b.Navigation("ChildrenTree");
                });
#pragma warning restore 612, 618
        }
    }
}
