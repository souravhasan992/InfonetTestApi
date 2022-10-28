using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InfonetAssociates.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CSharpSkill = table.Column<bool>(type: "bit", nullable: false),
                    CPlusPlusSkill = table.Column<bool>(type: "bit", nullable: false),
                    JavaSkill = table.Column<bool>(type: "bit", nullable: false),
                    PhpSkill = table.Column<bool>(type: "bit", nullable: false),
                    SqlSkill = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
