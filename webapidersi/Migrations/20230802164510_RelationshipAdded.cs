using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapidersi.Migrations
{
    /// <inheritdoc />
    public partial class RelationshipAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Exhibitions",
                newName: "ExhibitionId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Artists",
                newName: "ArtistId");

            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Works",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExhibitionId",
                table: "Works",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Works_ArtistId",
                table: "Works",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_ExhibitionId",
                table: "Works",
                column: "ExhibitionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Artists_ArtistId",
                table: "Works",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Exhibitions_ExhibitionId",
                table: "Works",
                column: "ExhibitionId",
                principalTable: "Exhibitions",
                principalColumn: "ExhibitionId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Works_Artists_ArtistId",
                table: "Works");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_Exhibitions_ExhibitionId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_ArtistId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_ExhibitionId",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "ExhibitionId",
                table: "Works");

            migrationBuilder.RenameColumn(
                name: "ExhibitionId",
                table: "Exhibitions",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "Artists",
                newName: "ID");
        }
    }
}
