using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreEcommerce.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AFFID = table.Column<string>(maxLength: 255, nullable: true),
                    AFID = table.Column<string>(maxLength: 255, nullable: true),
                    AID = table.Column<string>(maxLength: 255, nullable: true),
                    C1 = table.Column<string>(maxLength: 255, nullable: true),
                    C2 = table.Column<string>(maxLength: 255, nullable: true),
                    C3 = table.Column<string>(maxLength: 255, nullable: true),
                    OPT = table.Column<string>(maxLength: 255, nullable: true),
                    SID = table.Column<string>(maxLength: 255, nullable: true),
                    billingAddress1 = table.Column<string>(maxLength: 64, nullable: true),
                    billingAddress2 = table.Column<string>(maxLength: 64, nullable: true),
                    billingCity = table.Column<string>(maxLength: 32, nullable: true),
                    billingCountry = table.Column<string>(maxLength: 2, nullable: true),
                    billingFirstName = table.Column<string>(maxLength: 64, nullable: true),
                    billingLastName = table.Column<string>(maxLength: 64, nullable: true),
                    billingState = table.Column<string>(maxLength: 32, nullable: true),
                    billingZip = table.Column<int>(nullable: false),
                    click_id = table.Column<string>(maxLength: 255, nullable: true),
                    email = table.Column<string>(maxLength: 96, nullable: false),
                    firstName = table.Column<string>(maxLength: 64, nullable: true),
                    ipAddress = table.Column<string>(maxLength: 15, nullable: true),
                    lastName = table.Column<string>(maxLength: 64, nullable: true),
                    phone = table.Column<int>(nullable: false),
                    prospectId = table.Column<int>(nullable: false),
                    shippingAddress1 = table.Column<string>(maxLength: 64, nullable: true),
                    shippingAddress2 = table.Column<string>(maxLength: 64, nullable: true),
                    shippingCity = table.Column<string>(maxLength: 32, nullable: true),
                    shippingCountry = table.Column<string>(maxLength: 2, nullable: true),
                    shippingState = table.Column<string>(maxLength: 32, nullable: true),
                    shippingZip = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
