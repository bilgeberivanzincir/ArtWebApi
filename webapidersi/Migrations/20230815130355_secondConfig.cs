using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace webapidersi.Migrations
{
    /// <inheritdoc />
    public partial class secondConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "ID", "Email", "Name", "Password", "Surname" },
                values: new object[,]
                {
                    { 1, "zincirberivan@gmail.com", "Bilge Berivan ", 147414, "Zincir" },
                    { 2, "derincagdas@gmail.com", "Derin", 150707, "Çağdaş" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Members");
        }
    }
}
