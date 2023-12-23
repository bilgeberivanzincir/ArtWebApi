using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace webapidersi.Migrations
{
    /// <inheritdoc />
    public partial class ekleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Profiles",
                newName: "ProfileId");

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exhibitions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "About", "Name" },
                values: new object[,]
                {
                    { 1, "İtalyan rönesans dönemi ressam, heykeltıraş, mimar ve şairidir.", "Michelangelo" },
                    { 2, "Portekizli ressam ve desinatör", "Paula Rego" }
                });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "ID",
                keyValue: 1,
                column: "ProfileId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "ID",
                keyValue: 2,
                column: "ProfileId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Museums",
                columns: new[] { "ID", "Address", "City", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "Asmalı Mescit, Meşrutiyet Cd. No:65, 34430 Beyoğlu/İstanbul", "İstanbul", "Türkiye", "Pera Müzesi" },
                    { 2, "Via del Proconsolo,4,50122", "Florence", "Italy", "Bargello Müzesi" }
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "ProfileId", "Comment", "Fallowers", "Fallowing", "Favorites", "Visited" },
                values: new object[,]
                {
                    { 1, "Büyüleyici bir eser", 1, 1, null, "fsfsff" },
                    { 2, "Büyüleyici bir yer", 1, 1, null, "jsdjsks" }
                });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "ID", "Aciklama", "ArtistId", "ExhibitionId", "Kunye" },
                values: new object[,]
                {
                    { 1, "Adem'in Yaratılışı, Sistine Şapeli'nin tavanındaki ünlü bir fresktir Tüm zamanların en çok replikası yapılan dinî resimlerinden biridir.", 1, 2, "Michelangelo,Adem'in Yaratılışı,1512,2,8 m x 5,7 m" },
                    { 2, "ay ışığının aydınlattığı bir kumsalda ön planda dans eden sekiz figürün yer aldığı büyük bir tablodur.", 2, 1, "Paula Rego, The Dance, 1988" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_ProfileId",
                table: "Members",
                column: "ProfileId");

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

            migrationBuilder.DeleteData(
                table: "Museums",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Museums",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Members");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "Profiles",
                newName: "ID");

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
    }
}
