using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migration_appuser_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Messages2",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppUserId1",
                table: "Messages2",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthorsId",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages2_AppUserId",
                table: "Messages2",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages2_AppUserId1",
                table: "Messages2",
                column: "AppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuthorsId",
                table: "Blogs",
                column: "AuthorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_AuthorsId",
                table: "Blogs",
                column: "AuthorsId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages2_AspNetUsers_AppUserId",
                table: "Messages2",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages2_AspNetUsers_AppUserId1",
                table: "Messages2",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_AuthorsId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages2_AspNetUsers_AppUserId",
                table: "Messages2");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages2_AspNetUsers_AppUserId1",
                table: "Messages2");

            migrationBuilder.DropIndex(
                name: "IX_Messages2_AppUserId",
                table: "Messages2");

            migrationBuilder.DropIndex(
                name: "IX_Messages2_AppUserId1",
                table: "Messages2");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_AuthorsId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Messages2");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Messages2");

            migrationBuilder.DropColumn(
                name: "AuthorsId",
                table: "Blogs");
        }
    }
}
