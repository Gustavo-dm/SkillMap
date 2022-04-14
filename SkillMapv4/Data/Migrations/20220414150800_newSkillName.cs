using Microsoft.EntityFrameworkCore.Migrations;

namespace SkillMapv4.Data.Migrations
{
    public partial class newSkillName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Skill",
                table: "Skills",
                newName: "SkillName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SkillName",
                table: "Skills",
                newName: "Skill");
        }
    }
}
