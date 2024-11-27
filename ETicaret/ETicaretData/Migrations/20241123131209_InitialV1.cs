using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretData.Migrations
{
    /// <inheritdoc />
    public partial class InitialV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 7, 18, 289, DateTimeKind.Local).AddTicks(6799), new Guid("a3a28a6b-3583-4f2b-85bf-76b8efa098ab") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 23, 16, 7, 18, 289, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 23, 16, 7, 18, 289, DateTimeKind.Local).AddTicks(9728));
        }
    }
}
