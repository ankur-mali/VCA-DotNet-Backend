using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VCA.Migrations
{
    /// <inheritdoc />
    public partial class @as : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompType",
                table: "components");

            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompType = table.Column<int>(type: "int", nullable: false),
                    IsConfigurable = table.Column<int>(type: "int", nullable: false),
                    ModId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    CompId = table.Column<int>(type: "int", nullable: false),
                    ComponentId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vehicles_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehicles_components_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_ComponentId",
                table: "vehicles",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_ModelId",
                table: "vehicles",
                column: "ModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vehicles");

            migrationBuilder.AddColumn<string>(
                name: "CompType",
                table: "components",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
