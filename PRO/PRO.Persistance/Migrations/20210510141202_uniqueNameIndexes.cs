using Microsoft.EntityFrameworkCore.Migrations;

namespace PRO.Persistance.Migrations
{
    public partial class uniqueNameIndexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b4cd5084-b3a7-4e5c-9ce0-76c7198115c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a9e97ce1-0b8d-4480-841d-7ed6634e79bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "5df491b1-a19a-4226-b331-cefbc733354a");

            migrationBuilder.CreateIndex(
                name: "Name",
                table: "Tags",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Name",
                table: "Statuses",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Name",
                table: "Series",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Name",
                table: "Platforms",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Name",
                table: "ListTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Name",
                table: "Languages",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Name",
                table: "ImageTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Name",
                table: "Genres",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Name",
                table: "Companies",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Name",
                table: "Awards",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Name",
                table: "ArticleTypes",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Name",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "Name",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "Name",
                table: "Series");

            migrationBuilder.DropIndex(
                name: "Name",
                table: "Platforms");

            migrationBuilder.DropIndex(
                name: "Name",
                table: "ListTypes");

            migrationBuilder.DropIndex(
                name: "Name",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "Name",
                table: "ImageTypes");

            migrationBuilder.DropIndex(
                name: "Name",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "Name",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "Name",
                table: "Awards");

            migrationBuilder.DropIndex(
                name: "Name",
                table: "ArticleTypes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c56e9aaa-8727-4ace-9efd-b9ec02c19f6f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a24eabeb-cc60-4090-87e2-ae4135d60718");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "151cf799-546e-4c3d-bbd0-1383847fb61e");
        }
    }
}
