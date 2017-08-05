using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreEcommerce.Migrations
{
    public partial class Products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    employeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    active = table.Column<bool>(nullable: false),
                    companyId = table.Column<int>(nullable: true),
                    created = table.Column<bool>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.employeeID);
                    table.ForeignKey(
                        name: "FK_Employee_Companies_companyId",
                        column: x => x.companyId,
                        principalTable: "Companies",
                        principalColumn: "companyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    active = table.Column<bool>(nullable: false),
                    cogs = table.Column<decimal>(nullable: false),
                    created = table.Column<DateTime>(nullable: false),
                    declaredValue = table.Column<decimal>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    digital = table.Column<bool>(nullable: false),
                    digitalUrl = table.Column<string>(nullable: true),
                    maxQuantity = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    price = table.Column<decimal>(nullable: false),
                    recurringProductproductId = table.Column<int>(nullable: true),
                    restockingFee = table.Column<decimal>(nullable: false),
                    shipping = table.Column<bool>(nullable: false),
                    sku = table.Column<string>(nullable: true),
                    subscription = table.Column<bool>(nullable: false),
                    updated = table.Column<DateTime>(nullable: false),
                    weight = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productId);
                    table.ForeignKey(
                        name: "FK_Products_Products_recurringProductproductId",
                        column: x => x.recurringProductproductId,
                        principalTable: "Products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_companyId",
                table: "Employee",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_recurringProductproductId",
                table: "Products",
                column: "recurringProductproductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
