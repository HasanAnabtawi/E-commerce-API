using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01e2cc8e-793c-47ba-b2cc-ec354788a6c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "850c189d-140f-4564-88dd-782ba93f7e5d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fceb3ed0-9187-4188-9f9d-3361fdd61912", "823c131c-2651-4963-a082-ca02fca57fd7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c440640-eec4-44e7-9488-83ba78ffad62");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a7fa3c4d-5ef4-4f70-b0f1-c84bec1f6edb", null, "User", "USER" },
                    { "fceb3ed0-9187-4188-9f9d-3361fdd61912", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fa78427d-79a1-4fff-8b6f-1904a7e6fd10", 0, "6989e506-d51b-4395-b6b8-1a5a079295b0", "Hasan@email.com", false, false, null, "HASAN@EMAIL.COM", "HASAN", "AQAAAAIAAYagAAAAEFosimVx3gdqGjwLJip2XhBqeMH0QT+mn3zNoqIpe+lBLFYCwYhz08hyNqMqAijRMA==", null, false, "6f9c54a3-e406-44cd-822f-6b9202dd0894", false, "Hasan" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fceb3ed0-9187-4188-9f9d-3361fdd61912", "fa78427d-79a1-4fff-8b6f-1904a7e6fd10" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7fa3c4d-5ef4-4f70-b0f1-c84bec1f6edb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fceb3ed0-9187-4188-9f9d-3361fdd61912", "fa78427d-79a1-4fff-8b6f-1904a7e6fd10" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fceb3ed0-9187-4188-9f9d-3361fdd61912");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa78427d-79a1-4fff-8b6f-1904a7e6fd10");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01e2cc8e-793c-47ba-b2cc-ec354788a6c1", null, "Admin", "ADMIN" },
                    { "850c189d-140f-4564-88dd-782ba93f7e5d", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fceb3ed0-9187-4188-9f9d-3361fdd61912", "823c131c-2651-4963-a082-ca02fca57fd7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2c440640-eec4-44e7-9488-83ba78ffad62", 0, "8f65ffd6-1edb-4f09-8de8-f2f532fb5f7d", "Hasan@email.com", false, false, null, "HASAN@EMAIL.COM", "HASAN", "AQAAAAIAAYagAAAAEP8InIj7iIJz+PvZSV/YdRfIL0ZdiVgsiIgoGyGFBdM8IEL43bj+SZK7sLLBzyAuXw==", null, false, "c52f7eb2-cb3c-406e-b599-9f3bfb3178e4", false, "Hasan" });
        }
    }
}
