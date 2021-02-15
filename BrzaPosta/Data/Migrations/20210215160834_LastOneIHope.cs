using Microsoft.EntityFrameworkCore.Migrations;

namespace BrzaPosta.Data.Migrations
{
    public partial class LastOneIHope : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Contact = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Zip = table.Column<string>(nullable: false),
                    Size = table.Column<string>(nullable: false),
                    Details = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Name2 = table.Column<string>(nullable: false),
                    LastName2 = table.Column<string>(nullable: false),
                    Address2 = table.Column<string>(nullable: false),
                    Contact2 = table.Column<string>(nullable: false),
                    City2 = table.Column<string>(nullable: false),
                    State2 = table.Column<string>(nullable: false),
                    Zip2 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "96075747-8b25-498a-816e-48c97d5f6757", "94ded74f-a9de-430a-b6db-f3e241e1a848", "Super Admin", "SUPER ADMIN" },
                    { "57fd2da2-6649-4bfb-a53a-d257093a5dd3", "d9e3ce14-e71e-4fd7-af85-a250a00b5791", "Admin", "ADMIN" },
                    { "2a9c2373-3670-46aa-b45c-5a153eb8e9b0", "16a1c17c-bc24-4564-97ca-458f0fcbb2f1", "Dostavljac", "DOSTAVLJAC" },
                    { "1a6b815e-ff19-4701-9795-7060c2574367", "825bbce7-919d-44bc-b20a-02aa4a7ca592", "Korisnik", "KORISNIK" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a6b815e-ff19-4701-9795-7060c2574367");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a9c2373-3670-46aa-b45c-5a153eb8e9b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57fd2da2-6649-4bfb-a53a-d257093a5dd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96075747-8b25-498a-816e-48c97d5f6757");

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
    }
}
