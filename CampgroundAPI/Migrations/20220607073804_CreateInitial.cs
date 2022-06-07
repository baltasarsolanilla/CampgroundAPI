using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampgroundAPI.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Geometries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitud = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geometries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ASSET_DESC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ASSET_OWNE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HERITAGE_V = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MGA_EASTIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MGA_NORTHI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MGA_ZONE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PARK_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PARK_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SITE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campgrounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeometryId = table.Column<int>(type: "int", nullable: true),
                    PropertyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campgrounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campgrounds_Geometries_GeometryId",
                        column: x => x.GeometryId,
                        principalTable: "Geometries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Campgrounds_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampgroundId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favourites_Campgrounds_CampgroundId",
                        column: x => x.CampgroundId,
                        principalTable: "Campgrounds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campgrounds_GeometryId",
                table: "Campgrounds",
                column: "GeometryId");

            migrationBuilder.CreateIndex(
                name: "IX_Campgrounds_PropertyId",
                table: "Campgrounds",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_CampgroundId",
                table: "Favourites",
                column: "CampgroundId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "Campgrounds");

            migrationBuilder.DropTable(
                name: "Geometries");

            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}
