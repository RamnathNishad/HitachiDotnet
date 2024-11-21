using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeService.Migrations
{
    /// <inheritdoc />
    public partial class table_name_change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_employees",
                table: "tbl_employees");

            migrationBuilder.RenameTable(
                name: "tbl_employees",
                newName: "employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "Ecode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_employees",
            //    table: "employees");

            //migrationBuilder.RenameTable(
            //    name: "employees",
            //    newName: "tbl_employees");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_tbl_employees",
            //    table: "tbl_employees",
            //    column: "Ecode");
        }
    }
}
