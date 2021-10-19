using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebLibrary.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookPlacement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColumnNum = table.Column<int>(nullable: false),
                    BookGenre = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookPlacement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    YearPublished = table.Column<DateTime>(nullable: false),
                    Publisher = table.Column<string>(nullable: true),
                    BookGenre = table.Column<int>(nullable: false),
                    Author = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    BookInfoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_BookPlacement_BookInfoId",
                        column: x => x.BookInfoId,
                        principalTable: "BookPlacement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookInfoId",
                table: "Books",
                column: "BookInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "BookPlacement");
        }
    }
}
