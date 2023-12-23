using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace webapidersi.Migrations
{
    /// <inheritdoc />
    public partial class config : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exhibitions",
                columns: new[] { "ExhibitionId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "kskskjfjffsf", "Hikayelerin Hikayesi" },
                    { 2, "aaaaa", "Varoluş ve Yüzey" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exhibitions",
                keyColumn: "ExhibitionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exhibitions",
                keyColumn: "ExhibitionId",
                keyValue: 2);
        }
    }
}
