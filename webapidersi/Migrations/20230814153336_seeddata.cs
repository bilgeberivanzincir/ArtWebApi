using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapidersi.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkID",
                table: "Museums",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exhibitions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Exhibitions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Museums_WorkID",
                table: "Museums",
                column: "WorkID");

            migrationBuilder.AddForeignKey(
                name: "FK_Museums_Works_WorkID",
                table: "Museums",
                column: "WorkID",
                principalTable: "Works",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Museums_Works_WorkID",
                table: "Museums");

            migrationBuilder.DropIndex(
                name: "IX_Museums_WorkID",
                table: "Museums");

            migrationBuilder.DropColumn(
                name: "WorkID",
                table: "Museums");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exhibitions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Exhibitions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
