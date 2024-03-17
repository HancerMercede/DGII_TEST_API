using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addingthecontributorconfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Contributors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RncCedula",
                table: "Contributors",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Contributors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Contributors",
                columns: new[] { "ContributorId", "Name", "RncCedula", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("4d2a8cfa-9174-4f25-b6b2-40dad4a88e16"), "CRISTINO ALMANZAR", "04000175463", 1, "PERSONA FISICA" },
                    { new Guid("7eb7d17c-f778-4ef7-a259-c4385741a127"), "MARIO MARTINEZ", "045788655", 1, "PERSONA FISICA" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("4d2a8cfa-9174-4f25-b6b2-40dad4a88e16"));

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("7eb7d17c-f778-4ef7-a259-c4385741a127"));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Contributors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "RncCedula",
                table: "Contributors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Contributors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
