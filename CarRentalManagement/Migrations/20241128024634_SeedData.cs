using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(6758), new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(6774), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(6777), new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(6778), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(6951), new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(6952), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(6954), new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(6954), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(7055), new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(7056), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(7058), new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(7058), "x5", "System" },
                    { 3, "System", new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(7060), new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(7060), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(7062), new DateTime(2024, 11, 28, 10, 46, 34, 155, DateTimeKind.Local).AddTicks(7063), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
