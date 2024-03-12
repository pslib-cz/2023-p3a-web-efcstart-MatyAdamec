using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilesBrowser.Migrations
{
    /// <inheritdoc />
    public partial class _01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Folders",
                columns: table => new
                {
                    FolderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ParentFolderId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folders", x => x.FolderId);
                    table.ForeignKey(
                        name: "FK_Folders_Folders_ParentFolderId",
                        column: x => x.ParentFolderId,
                        principalTable: "Folders",
                        principalColumn: "FolderId");
                });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "FolderId", "Name", "ParentFolderId" },
                values: new object[,]
                {
                    { new Guid("80ec3e83-ed43-4162-a4b1-39b2e766742c"), "Music", null },
                    { new Guid("9eb64af5-974f-4c8a-8696-a62920dbb56a"), "Images", null },
                    { new Guid("370a1e80-714e-4fbd-acfa-1fa2f6fb5875"), "MyDadPhotos", new Guid("9eb64af5-974f-4c8a-8696-a62920dbb56a") },
                    { new Guid("3b802dd0-e597-4f8b-99b4-66c134a3ef9f"), "WhiteGirlMusic", new Guid("80ec3e83-ed43-4162-a4b1-39b2e766742c") },
                    { new Guid("508cffbd-ce0d-4106-8429-bc9103924e05"), "GymPlalist", new Guid("80ec3e83-ed43-4162-a4b1-39b2e766742c") },
                    { new Guid("ccd9ba81-1b92-4a15-bf6e-3f1f1e48b3d0"), "MyMomPhotos", new Guid("9eb64af5-974f-4c8a-8696-a62920dbb56a") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Folders_ParentFolderId",
                table: "Folders",
                column: "ParentFolderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Folders");
        }
    }
}
