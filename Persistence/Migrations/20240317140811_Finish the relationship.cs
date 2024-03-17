using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Finishtherelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("463bb2dd-dbea-44a5-a90c-5873323e0fa9"));

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("7a2935ec-c9d1-4518-b253-3d6c36380299"));

            migrationBuilder.InsertData(
                table: "Contributors",
                columns: new[] { "ContributorId", "Name", "RncCedula", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("6dfd832f-b868-4f76-9c02-67a8dda8fa1d"), "CRISTINO ALMANZAR", "04000175463", 1, "PERSONA FISICA" },
                    { new Guid("b7395216-f028-40cf-a225-2ed9f4383f3a"), "MARIO MARTINEZ", "045788655", 1, "PERSONA FISICA" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("6dfd832f-b868-4f76-9c02-67a8dda8fa1d"));

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("b7395216-f028-40cf-a225-2ed9f4383f3a"));

            migrationBuilder.InsertData(
                table: "Contributors",
                columns: new[] { "ContributorId", "Name", "RncCedula", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("463bb2dd-dbea-44a5-a90c-5873323e0fa9"), "MARIO MARTINEZ", "045788655", 1, "PERSONA FISICA" },
                    { new Guid("7a2935ec-c9d1-4518-b253-3d6c36380299"), "CRISTINO ALMANZAR", "04000175463", 1, "PERSONA FISICA" }
                });
        }
    }
}
