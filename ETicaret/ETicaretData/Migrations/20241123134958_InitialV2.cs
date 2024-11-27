using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretData.Migrations
{
    /// <inheritdoc />
    public partial class InitialV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 49, 57, 761, DateTimeKind.Local).AddTicks(7258), new Guid("ea20aee7-adb0-4bbd-8f76-4e977488a18d") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 23, 16, 49, 57, 762, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 23, 16, 49, 57, 762, DateTimeKind.Local).AddTicks(665));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 12, 8, 365, DateTimeKind.Local).AddTicks(6010), new Guid("15260e3b-d496-421d-b646-466e97b89655") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 23, 16, 12, 8, 365, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 23, 16, 12, 8, 365, DateTimeKind.Local).AddTicks(8736));
        }
    }
}
