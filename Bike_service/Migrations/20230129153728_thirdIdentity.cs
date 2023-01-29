using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bikeservice.Migrations.Identity
{
    /// <inheritdoc />
    public partial class thirdIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef01e7aa-fadb-4488-b751-175f3959cedb", "1", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", 0, "506d661b-eabb-473b-9f7b-8da46784be9b", "bnalepa@o2.pl", true, null, null, true, null, "BNALEPA@O2.PL", "bnalepa@o2.pl", "AQAAAAEAACcQAAAAEOnh3f0u0M/9pDFKMgpjXBW9olem/abiNd8xkprms3uTBcPlSes13paMYhbNNit/vA==", null, null, false, "e0e9110e-16c5-4306-9460-1b587b401aa0", false, "bnalepa@o2.pl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ef01e7aa-fadb-4488-b751-175f3959cedb", "2c5e174e-3b0e-446f-86af-483d56fd7210" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef01e7aa-fadb-4488-b751-175f3959cedb", "2c5e174e-3b0e-446f-86af-483d56fd7210" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef01e7aa-fadb-4488-b751-175f3959cedb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210");
        }
    }
}
