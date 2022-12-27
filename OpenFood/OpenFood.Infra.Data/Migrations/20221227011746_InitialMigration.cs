using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenFood.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "BIGINT", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ImportedT = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Quantity = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Categories = table.Column<string>(type: "VARCHAR(512)", nullable: false),
                    Packaging = table.Column<string>(type: "VARCHAR(512)", nullable: false),
                    Brands = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
