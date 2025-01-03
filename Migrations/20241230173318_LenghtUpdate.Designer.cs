﻿// <auto-generated />
using System;
using ERP_IMR.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ERP_IMR.Migrations
{
    [DbContext(typeof(IMRDbContext))]
    [Migration("20241230173318_LenghtUpdate")]
    partial class LenghtUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRBOM001", b =>
                {
                    b.Property<string>("DOCTYPE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DOCTYPETEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool>("ISPASSIVE")
                        .HasColumnType("bit");

                    b.HasKey("DOCTYPE");

                    b.ToTable("BSMIMRBOM001");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRBOMCONTENT", b =>
                {
                    b.Property<string>("CONTENTNUM")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("BOMDOCFROM")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("BOMDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("BOMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("BOMDOCUNTIL")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMPBOMDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("COMPBOMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMPONENT")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("MATDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("MATDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<decimal>("QUANTITY")
                        .HasMaxLength(5)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CONTENTNUM");

                    b.ToTable("BSMIMRBOMCONTENT");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRBOMHEAD", b =>
                {
                    b.Property<string>("BOMDOCNUM")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("BOMDOCFROM")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("BOMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("BOMDOCUNTIL")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DRAWNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("ISDELETED")
                        .HasColumnType("bit");

                    b.Property<bool>("ISPASSIVE")
                        .HasColumnType("bit");

                    b.Property<string>("MATDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("MATDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<decimal>("QUANTITY")
                        .HasMaxLength(5)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BOMDOCNUM");

                    b.ToTable("BSMIMRBOMHEAD");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRCCM001", b =>
                {
                    b.Property<string>("DOCTYPE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DOCTYPETEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool>("ISPASSIVE")
                        .HasColumnType("bit");

                    b.HasKey("DOCTYPE");

                    b.ToTable("BSMIMRCCM001");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRCCMHEAD", b =>
                {
                    b.Property<string>("CCMDOCNUM")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("CCMDOCFROM")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("CCMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("CCMDOCUNTIL")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<bool>("ISDELETED")
                        .HasColumnType("bit");

                    b.Property<bool>("ISPASSIVE")
                        .HasColumnType("bit");

                    b.Property<string>("MAINCCMDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("MAINCCMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("CCMDOCNUM");

                    b.ToTable("BSMIMRCCMHEAD");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRCCMTEXT", b =>
                {
                    b.Property<string>("CCMSTEXT")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CCMDOCFROM")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("CCMDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CCMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("CCMDOCUNTIL")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("CCMLTEXT")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("LANCODE")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("CCMSTEXT");

                    b.ToTable("BSMIMRCCMTEXT");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRGEN001", b =>
                {
                    b.Property<string>("COMCODE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("ADDRESS1")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("ADDRESS2")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("CITYCODE")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("COMTEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("COUNTRYCODE")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("COMCODE");

                    b.ToTable("BSMIMRGEN001");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRGEN002", b =>
                {
                    b.Property<string>("LANCODE")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("LANTEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("LANCODE");

                    b.ToTable("BSMIMRGEN002");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRGEN003", b =>
                {
                    b.Property<string>("COUNTRYCODE")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COUNTRYTEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("COUNTRYCODE");

                    b.ToTable("BSMIMRGEN003");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRGEN004", b =>
                {
                    b.Property<string>("CITYCODE")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("CITYTEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COUNTRYCODE")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("CITYCODE");

                    b.ToTable("BSMIMRGEN004");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRGEN005", b =>
                {
                    b.Property<string>("UNITCODE")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<bool>("ISMAINUNIT")
                        .HasColumnType("bit");

                    b.Property<string>("MAINUNITCODE")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("UNITTEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("UNITCODE");

                    b.ToTable("BSMIMRGEN005");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRMAT001", b =>
                {
                    b.Property<string>("DOCTYPE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DOCTYPETEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool>("ISPASSIVE")
                        .HasColumnType("bit");

                    b.HasKey("DOCTYPE");

                    b.ToTable("BSMIMRMAT001");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRMATHEAD", b =>
                {
                    b.Property<string>("MATDOCNUM")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("BOMDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("BOMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<decimal?>("BRUTWEIGHT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BWUNIT")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<bool>("ISBOM")
                        .HasColumnType("bit");

                    b.Property<bool>("ISDELETED")
                        .HasColumnType("bit");

                    b.Property<bool>("ISPASSIVE")
                        .HasColumnType("bit");

                    b.Property<bool>("ISROUTE")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MATDOCFROM")
                        .HasColumnType("datetime2");

                    b.Property<string>("MATDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("MATDOCUNTIL")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("NETWEIGHT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("NWUNIT")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("ROTDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ROTDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("STUNIT")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<int>("SUPPLYTYPE")
                        .HasColumnType("int");

                    b.HasKey("MATDOCNUM");

                    b.ToTable("BSMIMRMATHEAD");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRMATTEXT", b =>
                {
                    b.Property<string>("MATSTEXT")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("LANCODE")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("MATDOCFROM")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MATDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("MATDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("MATDOCUNTIL")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MATLTEXT")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("MATSTEXT");

                    b.ToTable("BSMIMRMATTEXT");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMROPR001", b =>
                {
                    b.Property<string>("DOCTYPE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DOCTYPETEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool>("ISPASSIVE")
                        .HasColumnType("bit");

                    b.HasKey("DOCTYPE");

                    b.ToTable("BSMIMROPR001");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRROT001", b =>
                {
                    b.Property<string>("DOCTYPE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DOCTYPETEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool>("ISPASSIVE")
                        .HasColumnType("bit");

                    b.HasKey("DOCTYPE");

                    b.ToTable("BSMIMRROT001");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRROTBOMCONTENT", b =>
                {
                    b.Property<int>("CONTENTNUM")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CONTENTNUM"), 1L, 1);

                    b.Property<string>("BOMDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("BOMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMPONENT")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("MATDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("MATDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<int>("OPRNUM")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<decimal>("QUANTITY")
                        .HasMaxLength(5)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ROTDOCFROM")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("ROTDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ROTDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("ROTDOCUNTIL")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.HasKey("CONTENTNUM");

                    b.ToTable("BSMIMRROTBOMCONTENT");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRROTHEAD", b =>
                {
                    b.Property<string>("ROTDOCNUM")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DRAWNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("ISDELETED")
                        .HasColumnType("bit");

                    b.Property<bool>("ISPASSIVE")
                        .HasColumnType("bit");

                    b.Property<string>("MATDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("MATDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<decimal>("QUANTITY")
                        .HasMaxLength(5)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ROTDOCFROM")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("ROTDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("ROTDOCUNTIL")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.HasKey("ROTDOCNUM");

                    b.ToTable("BSMIMRROTHEAD");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRROTOPRCONTENT", b =>
                {
                    b.Property<int>("OPRNUM")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OPRNUM"), 1L, 1);

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<decimal>("LABOURTIME")
                        .HasMaxLength(3)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MACHINETIME")
                        .HasMaxLength(3)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MATDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("MATDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("OPRDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("ROTDOCFROM")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("ROTDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ROTDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("ROTDOCUNTIL")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<decimal>("SETUPTIME")
                        .HasMaxLength(3)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("WCMDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("WCMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("OPRNUM");

                    b.ToTable("BSMIMRROTOPRCONTENT");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRWCM001", b =>
                {
                    b.Property<string>("DOCTYPE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DOCTYPETEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool>("ISPASSIVE")
                        .HasColumnType("bit");

                    b.HasKey("DOCTYPE");

                    b.ToTable("BSMIMRWCM001");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRWCMHEAD", b =>
                {
                    b.Property<string>("WCMDOCNUM")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CCMDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CCMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<bool>("ISDELETED")
                        .HasColumnType("bit");

                    b.Property<bool>("ISPASSIVE")
                        .HasColumnType("bit");

                    b.Property<string>("MAINWCMDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("MAINWCMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("WCMDOCFROM")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("WCMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("WCMDOCUNTIL")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("WORKTIME")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("WCMDOCNUM");

                    b.ToTable("BSMIMRWCMHEAD");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRWCMOPR", b =>
                {
                    b.Property<string>("WCMDOCNUM")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("OPRDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("WCMDOCFROM")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("WCMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("WCMDOCUNTIL")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.HasKey("WCMDOCNUM");

                    b.ToTable("BSMIMRWCMOPR");
                });

            modelBuilder.Entity("ERP_IMR.Models.BSMIMRWCMTEXT", b =>
                {
                    b.Property<string>("WCMSTEXT")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("LANCODE")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<DateTime>("WCMDOCFROM")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("WCMDOCNUM")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("WCMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("WCMDOCUNTIL")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("WCMLTEXT")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("WCMSTEXT");

                    b.ToTable("BSMIMRWCMTEXT");
                });
#pragma warning restore 612, 618
        }
    }
}
