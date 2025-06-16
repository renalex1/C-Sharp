using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserEmailUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "id",
                keyValue: "0a72051a-a9f2-4482-9d5f-0bf5020a1498");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "id",
                keyValue: "f095b29d-0408-4757-bb11-0043b1301117");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "id", "concurrency_stamp", "name", "normalized_name" },
                values: new object[,]
                {
                    { "6f991a0f-1656-4452-bf29-ccb34f2ada86", null, "Admin", "ADMIN" },
                    { "dfa48cf8-ef50-4859-bf55-f2cd36eb908a", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "id",
                keyValue: "6f991a0f-1656-4452-bf29-ccb34f2ada86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "id",
                keyValue: "dfa48cf8-ef50-4859-bf55-f2cd36eb908a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "id", "concurrency_stamp", "name", "normalized_name" },
                values: new object[,]
                {
                    { "0a72051a-a9f2-4482-9d5f-0bf5020a1498", null, "User", "USER" },
                    { "f095b29d-0408-4757-bb11-0043b1301117", null, "Admin", "ADMIN" }
                });
        }
    }
}
