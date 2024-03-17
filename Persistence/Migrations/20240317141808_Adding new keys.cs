using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addingnewkeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("6dfd832f-b868-4f76-9c02-67a8dda8fa1d"));

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("b7395216-f028-40cf-a225-2ed9f4383f3a"));

            migrationBuilder.DropColumn(
                name: "ContributorId",
                table: "ComprobantesFiscales");

            migrationBuilder.AlterColumn<string>(
                name: "RncCedula",
                table: "ComprobantesFiscales",
                type: "nvarchar(11)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Contributors_RncCedula",
                table: "Contributors",
                column: "RncCedula");

            migrationBuilder.InsertData(
                table: "Contributors",
                columns: new[] { "ContributorId", "Name", "RncCedula", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("3720455a-3216-4c85-8a7d-607caf48b8ac"), "MARIO MARTINEZ", "045788655", 1, "PERSONA FISICA" },
                    { new Guid("9991b6ab-3fa3-4bcf-9004-757a1d1c6abc"), "CRISTINO ALMANZAR", "04000175463", 1, "PERSONA FISICA" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComprobantesFiscales_RncCedula",
                table: "ComprobantesFiscales",
                column: "RncCedula");

            migrationBuilder.AddForeignKey(
                name: "FK_ComprobantesFiscales_Contributors_RncCedula",
                table: "ComprobantesFiscales",
                column: "RncCedula",
                principalTable: "Contributors",
                principalColumn: "RncCedula");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComprobantesFiscales_Contributors_RncCedula",
                table: "ComprobantesFiscales");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Contributors_RncCedula",
                table: "Contributors");

            migrationBuilder.DropIndex(
                name: "IX_ComprobantesFiscales_RncCedula",
                table: "ComprobantesFiscales");

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("3720455a-3216-4c85-8a7d-607caf48b8ac"));

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("9991b6ab-3fa3-4bcf-9004-757a1d1c6abc"));

            migrationBuilder.AlterColumn<string>(
                name: "RncCedula",
                table: "ComprobantesFiscales",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
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
                    { new Guid("6dfd832f-b868-4f76-9c02-67a8dda8fa1d"), "CRISTINO ALMANZAR", "04000175463", 1, "PERSONA FISICA" },
                    { new Guid("b7395216-f028-40cf-a225-2ed9f4383f3a"), "MARIO MARTINEZ", "045788655", 1, "PERSONA FISICA" }
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
    }
}
