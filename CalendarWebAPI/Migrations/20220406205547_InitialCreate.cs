using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CalendarWebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DCalendars",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    location = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    runType = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    productName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    receiveBy = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    startDate = table.Column<DateTime>(nullable: false),
                    endDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCalendars", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DCalendars");
        }
    }
}
