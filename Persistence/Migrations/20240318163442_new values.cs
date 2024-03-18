using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newvalues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "ComprobantesFiscales",
                columns: new[] { "Id", "Itebis", "Monto", "NCF", "RncCedula" },
                values: new object[] { new Guid("31b1ab73-a9fd-4937-a93b-362db6b1e60c"), 486.0, 2700.0, "E310000000003", "98754321012" });

            migrationBuilder.InsertData(
                table: "Contributors",
                columns: new[] { "ContributorId", "Name", "RncCedula", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("6ec9c3a5-869b-474a-bf16-ff21f1aead0a"), "CRISTINO ALMANZAR", "04000175463", 1, "PERSONA FISICA" },
                    { new Guid("fd29c1ac-d8d1-4bd2-bd37-bb3684d0437b"), "MARIO MARTINEZ", "045788655", 1, "PERSONA FISICA" }
                });

            migrationBuilder.InsertData(
                table: "ComprobantesFiscales",
                columns: new[] { "Id", "Itebis", "Monto", "NCF", "RncCedula" },
                values: new object[,]
                {
                    { new Guid("5e8a0bd8-bed9-4908-b94a-b956f3efbd0f"), 450.0, 2500.0, "E310000000001", "04000175463" },
                    { new Guid("b3934379-8b84-4e23-8fc6-7f6bcf9181e4"), 486.0, 2700.0, "E310000000002", "045788655" },
                    { new Guid("d295ee8e-3fcd-4226-a7d4-1b92282b2d4e"), 414.0, 2300.0, "E310000000004", "045788655" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComprobantesFiscales",
                keyColumn: "Id",
                keyValue: new Guid("31b1ab73-a9fd-4937-a93b-362db6b1e60c"));

            migrationBuilder.DeleteData(
                table: "ComprobantesFiscales",
                keyColumn: "Id",
                keyValue: new Guid("5e8a0bd8-bed9-4908-b94a-b956f3efbd0f"));

            migrationBuilder.DeleteData(
                table: "ComprobantesFiscales",
                keyColumn: "Id",
                keyValue: new Guid("b3934379-8b84-4e23-8fc6-7f6bcf9181e4"));

            migrationBuilder.DeleteData(
                table: "ComprobantesFiscales",
                keyColumn: "Id",
                keyValue: new Guid("d295ee8e-3fcd-4226-a7d4-1b92282b2d4e"));

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("6ec9c3a5-869b-474a-bf16-ff21f1aead0a"));

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ContributorId",
                keyValue: new Guid("fd29c1ac-d8d1-4bd2-bd37-bb3684d0437b"));

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
    }
}
