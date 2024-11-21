using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeService.Migrations
{
    /// <inheritdoc />
    public partial class emp_col_change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "tbl_employees");

            migrationBuilder.RenameColumn(
                name: "Ename",
                table: "tbl_employees",
                newName: "Empname");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Empname",
                table: "tbl_employees",
                newName: "Ename");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "tbl_employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
