using Microsoft.EntityFrameworkCore.Migrations;

namespace DepartmentServer.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO ""Departments""(""Title"")
                VALUES('IT department'), ('Marketing'); ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
