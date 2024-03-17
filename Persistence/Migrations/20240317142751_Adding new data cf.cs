using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addingnewdatacf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("3720455a-3216-4c85-8a7d-607caf48b8ac"));

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("9991b6ab-3fa3-4bcf-9004-757a1d1c6abc"));

            migrationBuilder.InsertData(
                table: "Contributors",
                columns: new[] { "ContributorId", "Name", "RncCedula", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("0a69f796-861d-4d0d-920e-7906e45f89c6"), "MARIO MARTINEZ", "045788655", 1, "PERSONA FISICA" },
                    { new Guid("3cf3f6be-61d4-4568-b423-20ee5db37620"), "CRISTINO ALMANZAR", "04000175463", 1, "PERSONA FISICA" }
                });

            migrationBuilder.InsertData(
                table: "ComprobantesFiscales",
                columns: new[] { "Id", "Itebis", "Monto", "NCF", "RncCedula" },
                values: new object[,]
                {
                    { new Guid("0457f52e-8245-44ea-bb81-21939364c63a"), 450.0, 2500.0, "E310000000001", "04000175463" },
                    { new Guid("fa32dbb5-c39a-4e18-b527-7e9558c9325a"), 486.0, 2700.0, "E310000000002", "045788655" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComprobantesFiscales",
                keyColumn: "Id",
                keyValue: new Guid("0457f52e-8245-44ea-bb81-21939364c63a"));

            migrationBuilder.DeleteData(
                table: "ComprobantesFiscales",
                keyColumn: "Id",
                keyValue: new Guid("fa32dbb5-c39a-4e18-b527-7e9558c9325a"));

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("0a69f796-861d-4d0d-920e-7906e45f89c6"));

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("3cf3f6be-61d4-4568-b423-20ee5db37620"));

            migrationBuilder.InsertData(
                table: "Contributors",
                columns: new[] { "ContributorId", "Name", "RncCedula", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("3720455a-3216-4c85-8a7d-607caf48b8ac"), "MARIO MARTINEZ", "045788655", 1, "PERSONA FISICA" },
                    { new Guid("9991b6ab-3fa3-4bcf-9004-757a1d1c6abc"), "CRISTINO ALMANZAR", "04000175463", 1, "PERSONA FISICA" }
                });
        }
    }
}
