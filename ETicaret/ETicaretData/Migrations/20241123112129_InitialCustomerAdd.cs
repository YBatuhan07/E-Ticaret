using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretData.Migrations
{
    /// <inheritdoc />
    public partial class InitialCustomerAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCustomer",
                table: "AppUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "IsCustomer", "UserGuid" },
                values: new object[] { new DateTime(2024, 11, 23, 14, 21, 28, 508, DateTimeKind.Local).AddTicks(6372), false, new Guid("0d320534-aec7-496e-a65f-72995a19db91") });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCustomer",
                table: "AppUsers");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2024, 10, 27, 16, 21, 21, 763, DateTimeKind.Local).AddTicks(5151), new Guid("da16958a-7694-4c05-880a-59a5430b4911") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 16, 21, 21, 763, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 16, 21, 21, 763, DateTimeKind.Local).AddTicks(8313));
        }
    }
}
