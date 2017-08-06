using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreEcommerce.Migrations
{
    public partial class recurringproductid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_recurringProductproductId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_recurringProductproductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "recurringProductproductId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "recurringProductId",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "recurringProductId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "recurringProductproductId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_recurringProductproductId",
                table: "Products",
                column: "recurringProductproductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_recurringProductproductId",
                table: "Products",
                column: "recurringProductproductId",
                principalTable: "Products",
                principalColumn: "productId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
