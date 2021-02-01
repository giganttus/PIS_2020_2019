using Microsoft.EntityFrameworkCore.Migrations;

namespace BrzaPosta.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5f6f7a6d-e7e3-4ca6-9377-5915e5cf22c7", "b79cdcfc-a545-4c34-876b-265cf58a8c0c", "Super Admin", "SUPER ADMIN" },
                    { "f2c2830b-92bd-4e2d-a298-20f274f9bd4b", "a3b3390e-312f-474f-a323-e495d462cf5a", "Admin", "ADMIN" },
                    { "a36a87a3-627e-4b31-923d-562ed666218f", "df03525e-ebd5-421a-8cf0-b89537eecae6", "Dostavljac", "DOSTAVLJAC" },
                    { "3876c7e2-12f2-4a60-af3e-e2de4237c399", "3accd03d-19ef-4710-99a5-b2408e6fff0a", "Korisnik", "KORISNIK" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3876c7e2-12f2-4a60-af3e-e2de4237c399");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f6f7a6d-e7e3-4ca6-9377-5915e5cf22c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a36a87a3-627e-4b31-923d-562ed666218f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2c2830b-92bd-4e2d-a298-20f274f9bd4b");
        }
    }
}
