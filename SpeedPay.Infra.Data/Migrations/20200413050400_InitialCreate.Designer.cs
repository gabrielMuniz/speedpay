﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpeedPay.Infra.Data.Contexts;

namespace SpeedPay.Infra.Data.Migrations
{
    [DbContext(typeof(DefaultContext))]
    [Migration("20200413050400_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SpeedPay.Domain.Entities.Enterprise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FantasyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FederalRegistration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FederativeUnit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Enterprises");
                });

            modelBuilder.Entity("SpeedPay.Domain.Entities.Phone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProviderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("SpeedPay.Domain.Entities.Provider", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BornDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EnterpriseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FederalRegistration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeneralRegistration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnterpriseId");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("SpeedPay.Domain.Entities.Phone", b =>
                {
                    b.HasOne("SpeedPay.Domain.Entities.Provider", "Provider")
                        .WithMany("Phones")
                        .HasForeignKey("ProviderId");
                });

            modelBuilder.Entity("SpeedPay.Domain.Entities.Provider", b =>
                {
                    b.HasOne("SpeedPay.Domain.Entities.Enterprise", "Enterprise")
                        .WithMany()
                        .HasForeignKey("EnterpriseId");
                });
#pragma warning restore 612, 618
        }
    }
}
