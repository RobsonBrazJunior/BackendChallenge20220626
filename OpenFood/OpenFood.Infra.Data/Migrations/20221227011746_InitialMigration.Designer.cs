// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenFood.Infra.Data.Context;

#nullable disable

namespace OpenFood.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221227011746_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OpenFood.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brands")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Categories")
                        .IsRequired()
                        .HasColumnType("VARCHAR(512)");

                    b.Property<long>("Code")
                        .HasColumnType("BIGINT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ImportedT")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Packaging")
                        .IsRequired()
                        .HasColumnType("VARCHAR(512)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
