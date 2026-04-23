using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_11_Book_My_Doctor.Migrations
{
    /// <inheritdoc />
    public partial class addMockDataInDepartmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Departments (DeptName) values ('Orthopedics');\r\ninsert into Departments (DeptName) values ('Pediatrics');\r\ninsert into Departments (DeptName) values ('Cardiology');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRANCATE TABLE Department");
        }
    }
}
