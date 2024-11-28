using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "4072fba5-a657-43d5-99f4-65ef9bcd5ebf", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEvtDDGJf186M5R3TP0ec/U4gDxNXW6Acks35+a2+6nTamVOqWF2HBaCmJpKivU8Cg==", null, false, "3750733a-2029-460c-a515-4f142b3cdd90", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(544), new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(571), new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(1203), new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(1209), new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(1394), new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(1399), new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(1403), new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(1406), new DateTime(2024, 11, 28, 14, 58, 29, 52, DateTimeKind.Local).AddTicks(1407) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(2870), new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(2885), new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(3086), new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(3088), new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(3167), new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(3169), new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(3171), new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(3172), new DateTime(2024, 11, 28, 10, 55, 18, 681, DateTimeKind.Local).AddTicks(3173) });
        }
    }
}
