using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteBag.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "CreatedTime", "ModifiedTime", "Title" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quam aliquam alias illo vero nemo esse corrupti explicabo magni natus sunt consequatur quo voluptatum nisi accusamus rem, qui quia inventore rerum!", new DateTime(2022, 9, 8, 10, 56, 33, 145, DateTimeKind.Local).AddTicks(9531), new DateTime(2022, 9, 8, 10, 56, 33, 145, DateTimeKind.Local).AddTicks(9544), "Lorem Ipsum Dolor" });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "CreatedTime", "ModifiedTime", "Title" },
                values: new object[] { 2, "Eius iste vitae commodi magnam odit maxime id officiis iusto. A modi quae fugit! Veritatis nihil dolorum repellat laudantium, unde quae a porro quod ipsam possimus, nulla vero praesentium eius?", new DateTime(2022, 9, 8, 10, 56, 33, 145, DateTimeKind.Local).AddTicks(9547), new DateTime(2022, 9, 8, 10, 56, 33, 145, DateTimeKind.Local).AddTicks(9547), "Quis Dolores Est" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
