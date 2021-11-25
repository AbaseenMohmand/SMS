using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementSystem2.Migrations
{
    public partial class monthremfromfeetbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "Fees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "Fees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
