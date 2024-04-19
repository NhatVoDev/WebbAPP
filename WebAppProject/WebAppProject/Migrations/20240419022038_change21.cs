using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppProject.Migrations
{
    /// <inheritdoc />
    public partial class change21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
      table: "Roles",
      columns: new[] { "RoleNumber", "RoleName" },
      values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
               table: "Roles",
               columns: new[] { "RoleNumber", "RoleName" },
               values: new object[] { 2, "User" });



            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "EmailAddress", "Password", "RoleNumber" },
                values: new object[] { "admin@gmail.com", "123456", 1});

      //      migrationBuilder.InsertData(
      //table: "Users",
      //columns: new[] { "FirstName", "LastName", "AccountId" }, // Thêm cột AccountId
      //values: new object[] { "Admin", "Admin", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
