using Microsoft.EntityFrameworkCore.Migrations;

namespace PRO.Data.Migrations
{
    public partial class gametagcorrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Tags_TagId",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameTag",
                table: "GameTag");

            migrationBuilder.DropIndex(
                name: "IX_GameTag_GameId",
                table: "GameTag");

            migrationBuilder.DropIndex(
                name: "IX_Games_TagId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "GameTag");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Games");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameTag",
                table: "GameTag",
                columns: new[] { "GameId", "TagId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GameTag",
                table: "GameTag");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "GameTag",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Games",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameTag",
                table: "GameTag",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_GameTag_GameId",
                table: "GameTag",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_TagId",
                table: "Games",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Tags_TagId",
                table: "Games",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
