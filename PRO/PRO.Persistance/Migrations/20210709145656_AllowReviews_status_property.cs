using Microsoft.EntityFrameworkCore.Migrations;

namespace PRO.Persistance.Migrations
{
    public partial class AllowReviews_status_property : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AllowReviews",
                table: "Statuses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ad567813-4e7d-4ca4-8b05-191a1eebf65b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3bce27b4-cb6b-4784-a734-2d8c71bf04a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "303499f1-1728-404c-82ce-86b3d4ee298e");

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "AllowReviews",
                value: true);

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "AllowReviews",
                value: true);

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "AllowReviews",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllowReviews",
                table: "Statuses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8eb5d553-cfa0-40e2-9182-7bca8ba7ede4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7aee8d62-2390-4657-8a7f-6aebc2ccc0d0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c9b2f063-7773-41b3-b089-0a72d70e0be6");
        }
    }
}
