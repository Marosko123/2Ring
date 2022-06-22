using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newwebapi.Migrations.DataContextPositionsMigrations
{
    public partial class AddNumberOfEmployeesOnPos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfEmployeesOnPos",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfEmployeesOnPos",
                table: "Positions");
        }
    }
}
