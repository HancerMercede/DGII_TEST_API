using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddingRelationshipconfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("0760097d-ba00-4c5f-975a-6a01b3518603"));

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("9114326a-e9a9-40b5-bfb1-2b32756f197d"));

            migrationBuilder.InsertData(
                table: "Contributors",
                columns: new[] { "ContributorId", "Name", "RncCedula", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("463bb2dd-dbea-44a5-a90c-5873323e0fa9"), "MARIO MARTINEZ", "045788655", 1, "PERSONA FISICA" },
                    { new Guid("7a2935ec-c9d1-4518-b253-3d6c36380299"), "CRISTINO ALMANZAR", "04000175463", 1, "PERSONA FISICA" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("0760097d-ba00-4c5f-975a-6a01b3518603"), "MARIO MARTINEZ", "045788655", 1, "PERSONA FISICA" },
                    { new Guid("9114326a-e9a9-40b5-bfb1-2b32756f197d"), "CRISTINO ALMANZAR", "04000175463", 1, "PERSONA FISICA" }
                });
        }
    }
}
