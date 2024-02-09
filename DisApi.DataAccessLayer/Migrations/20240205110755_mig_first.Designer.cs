﻿// <auto-generated />
using DisApi.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DisApi.DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240205110755_mig_first")]
    partial class mig_first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DisApi.EntityLayer.Concrete.Tooth", b =>
                {
                    b.Property<int>("ToothID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ToothID"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToothName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Toothlocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ToothID");

                    b.ToTable("Teeth");
                });
#pragma warning restore 612, 618
        }
    }
}
