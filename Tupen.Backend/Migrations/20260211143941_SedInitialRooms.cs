using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tupen.Backend.Migrations
{
    /// <inheritdoc />
    public partial class SedInitialRooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "CreatedAt", "Description", "IsAvailable", "Name", "RoomNumber" },
                values: new object[,]
                {
                    { 16, 30, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2756), "Lantai 1, Gedung D", true, "Ruang Teori D1", "D.101" },
                    { 17, 30, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2757), "Lantai 1, Gedung D", true, "Ruang Teori D2", "D.102" },
                    { 18, 25, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2759), "Lantai 2, Gedung D", true, "Lab Bahasa D1", "D.201" },
                    { 19, 25, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2761), "Lantai 2, Gedung D", true, "Lab Bahasa D2", "D.202" },
                    { 20, 30, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2763), "Lantai 3, Gedung D", true, "Ruang Teori D3", "D.301" },
                    { 21, 20, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2764), "Lantai 1, Gedung E", true, "Lab Fisika E1", "E.101" },
                    { 22, 20, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2766), "Lantai 1, Gedung E", true, "Lab Kimia E2", "E.102" },
                    { 23, 40, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2768), "Lantai 2, Gedung E", true, "Ruang Teori E1", "E.201" },
                    { 24, 40, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2770), "Lantai 2, Gedung E", true, "Ruang Teori E2", "E.202" },
                    { 25, 35, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2771), "Lantai 3, Gedung E", true, "Lab Komputer E1", "E.301" }
                });
        }
    }
}
