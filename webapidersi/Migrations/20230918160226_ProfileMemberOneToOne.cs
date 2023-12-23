using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapidersi.Migrations
{
    /// <inheritdoc />
    public partial class ProfileMemberOneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "ID",
                keyValue: 1,
                column: "ProfileId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "ID",
                keyValue: 2,
                column: "ProfileId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Members_ProfileId",
                table: "Members",
                column: "ProfileId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Profiles_ProfileId",
                table: "Members",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Profiles_ProfileId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_ProfileId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Members");
        }
    }
}
