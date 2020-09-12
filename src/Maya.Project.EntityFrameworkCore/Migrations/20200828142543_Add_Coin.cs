using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Maya.Project.Migrations
{
    public partial class Add_Coin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coins",
                schema: "Trade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    Symbol = table.Column<string>(maxLength: 30, nullable: true),
                    Icon = table.Column<string>(maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coins", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coins",
                schema: "Trade");
        }
    }
}
