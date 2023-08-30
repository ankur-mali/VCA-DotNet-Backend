using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VCA.Migrations
{
    /// <inheritdoc />
    public partial class jj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alternate_components",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeltaPrice = table.Column<double>(type: "float", nullable: false),
                    mod_id = table.Column<int>(type: "int", nullable: false),
                    comp_id = table.Column<int>(type: "int", nullable: false),
                    alt_comp_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alternate_components", x => x.Id);
                    table.ForeignKey(
                        name: "FK_alternate_components_Models_mod_id",
                        column: x => x.mod_id,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_alternate_components_components_alt_comp_id",
                        column: x => x.alt_comp_id,
                        principalTable: "components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_alternate_components_components_comp_id",
                        column: x => x.comp_id,
                        principalTable: "components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_alternate_components_alt_comp_id",
                table: "alternate_components",
                column: "alt_comp_id");

            migrationBuilder.CreateIndex(
                name: "IX_alternate_components_comp_id",
                table: "alternate_components",
                column: "comp_id");

            migrationBuilder.CreateIndex(
                name: "IX_alternate_components_mod_id",
                table: "alternate_components",
                column: "mod_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alternate_components");
        }
    }
}
