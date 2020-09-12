using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Maya.Project.Migrations
{
    public partial class Edit_Coin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                schema: "Trade",
                table: "Coins");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                schema: "Trade",
                table: "Coins");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                schema: "Trade",
                table: "Coins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                schema: "Trade",
                table: "Coins",
                type: "bigint",
                nullable: true);
        }
    }
}
