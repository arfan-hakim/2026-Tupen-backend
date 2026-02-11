using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tupen.Backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialRooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "CreatedAt", "Description", "IsAvailable", "Name", "RoomNumber" },
                values: new object[,]
                {
                    { 1, 40, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(470), "Lantai 1, Gedung A", true, "Ruang Teori A1", "A.101" },
                    { 2, 40, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2699), "Lantai 1, Gedung A", true, "Ruang Teori A2", "A.102" },
                    { 3, 30, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2703), "Lantai 2, Gedung A", true, "Lab Komputer A1", "A.201" },
                    { 4, 30, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2705), "Lantai 2, Gedung A", true, "Lab Komputer A2", "A.202" },
                    { 5, 60, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2707), "Lantai 3, Gedung A", true, "Aula Mini Gedung A", "A.301" },
                    { 6, 40, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2738), "Lantai 1, Gedung B", true, "Ruang Teori B1", "B.101" },
                    { 7, 40, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2740), "Lantai 1, Gedung B", true, "Ruang Teori B2", "B.102" },
                    { 8, 25, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2742), "Lantai 2, Gedung B", true, "Studio Gambar B1", "B.201" },
                    { 9, 25, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2744), "Lantai 2, Gedung B", true, "Studio Gambar B2", "B.202" },
                    { 10, 35, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2745), "Lantai 3, Gedung B", true, "Lab Komputer B3", "B.305" },
                    { 11, 45, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2747), "Lantai 1, Gedung C", true, "Ruang Teori C1", "C.101" },
                    { 12, 45, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2749), "Lantai 1, Gedung C", true, "Ruang Teori C2", "C.102" },
                    { 13, 20, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2750), "Lantai 2, Gedung C", true, "Ruang Rapat C1", "C.201" },
                    { 14, 20, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2752), "Lantai 2, Gedung C", true, "Ruang Rapat C2", "C.202" },
                    { 15, 100, new DateTime(2026, 2, 11, 14, 31, 16, 687, DateTimeKind.Utc).AddTicks(2754), "Lantai 3, Gedung C", true, "Aula Serbaguna", "C.301" },
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15);

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
        }
    }
}
