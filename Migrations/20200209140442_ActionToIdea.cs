using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperTodoList.Migrations
{
    public partial class ActionToIdea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemOfList");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "ListsTodo");

            migrationBuilder.CreateTable(
                name: "Ideas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Position = table.Column<int>(nullable: true),
                    ParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ideas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ideas");

            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListsTodo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListsTodo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemOfList",
                columns: table => new
                {
                    ListId = table.Column<int>(type: "int", nullable: false),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOfList", x => new { x.ListId, x.ActionId, x.Position });
                    table.ForeignKey(
                        name: "FK_ItemOfList_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemOfList_ListsTodo_ListId",
                        column: x => x.ListId,
                        principalTable: "ListsTodo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemOfList_ActionId",
                table: "ItemOfList",
                column: "ActionId");
        }
    }
}
