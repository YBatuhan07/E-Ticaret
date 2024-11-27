using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretData.Migrations
{
    /// <inheritdoc />
    public partial class InitialCustomerAdd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2024, 11, 23, 14, 21, 28, 508, DateTimeKind.Local).AddTicks(6372), new Guid("0d320534-aec7-496e-a65f-72995a19db91") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 23, 14, 21, 28, 508, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 23, 14, 21, 28, 508, DateTimeKind.Local).AddTicks(9399));
        }
    }
}
