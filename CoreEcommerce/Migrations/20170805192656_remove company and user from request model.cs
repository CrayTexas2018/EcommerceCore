using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreEcommerce.Migrations
{
    public partial class removecompanyanduserfromrequestmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Companies_companyId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Users_userId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_companyId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_userId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "companyId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Requests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "companyId",
                table: "Requests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Requests",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_companyId",
                table: "Requests",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_userId",
                table: "Requests",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Companies_companyId",
                table: "Requests",
                column: "companyId",
                principalTable: "Companies",
                principalColumn: "companyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Users_userId",
                table: "Requests",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
