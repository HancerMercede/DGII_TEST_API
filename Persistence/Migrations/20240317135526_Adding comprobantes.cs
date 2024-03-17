using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addingcomprobantes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("4d2a8cfa-9174-4f25-b6b2-40dad4a88e16"));

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("7eb7d17c-f778-4ef7-a259-c4385741a127"));

            migrationBuilder.RenameColumn(
                name: "RncCecula",
                table: "ComprobantesFiscales",
                newName: "RncCedula");

            migrationBuilder.AlterColumn<string>(
                name: "NCF",
                table: "ComprobantesFiscales",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ContributorId",
                table: "ComprobantesFiscales",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Contributors",
                columns: new[] { "ContributorId", "Name", "RncCedula", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("0760097d-ba00-4c5f-975a-6a01b3518603"), "MARIO MARTINEZ", "045788655", 1, "PERSONA FISICA" },
                    { new Guid("9114326a-e9a9-40b5-bfb1-2b32756f197d"), "CRISTINO ALMANZAR", "04000175463", 1, "PERSONA FISICA" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComprobantesFiscales_ContributorId",
                table: "ComprobantesFiscales",
                column: "ContributorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComprobantesFiscales_Contributors_ContributorId",
                table: "ComprobantesFiscales",
                column: "ContributorId",
                principalTable: "Contributors",
                principalColumn: "ContributorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComprobantesFiscales_Contributors_ContributorId",
                table: "ComprobantesFiscales");

            migrationBuilder.DropIndex(
                name: "IX_ComprobantesFiscales_ContributorId",
                table: "ComprobantesFiscales");

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("0760097d-ba00-4c5f-975a-6a01b3518603"));

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("9114326a-e9a9-40b5-bfb1-2b32756f197d"));

            migrationBuilder.DropColumn(
                name: "ContributorId",
                table: "ComprobantesFiscales");

            migrationBuilder.RenameColumn(
                name: "RncCedula",
                table: "ComprobantesFiscales",
                newName: "RncCecula");

            migrationBuilder.AlterColumn<string>(
                name: "NCF",
                table: "ComprobantesFiscales",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.InsertData(
                table: "Contributors",
                columns: new[] { "ContributorId", "Name", "RncCedula", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("4d2a8cfa-9174-4f25-b6b2-40dad4a88e16"), "CRISTINO ALMANZAR", "04000175463", 1, "PERSONA FISICA" },
                    { new Guid("7eb7d17c-f778-4ef7-a259-c4385741a127"), "MARIO MARTINEZ", "045788655", 1, "PERSONA FISICA" }
                });
        }
    }
}
