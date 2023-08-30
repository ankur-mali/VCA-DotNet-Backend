using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VCA.Migrations
{
    /// <inheritdoc />
    public partial class cvv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_alt_comp_id",
                table: "alternate_components");

            migrationBuilder.RenameColumn(
                name: "alt_comp_id",
                table: "alternate_components",
                newName: "AltCompIdId");

            migrationBuilder.RenameIndex(
                name: "IX_alternate_components_alt_comp_id",
                table: "alternate_components",
                newName: "IX_alternate_components_AltCompIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_AltCompIdId",
                table: "alternate_components",
                column: "AltCompIdId",
                principalTable: "components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_AltCompIdId",
                table: "alternate_components");

            migrationBuilder.RenameColumn(
                name: "AltCompIdId",
                table: "alternate_components",
                newName: "alt_comp_id");

            migrationBuilder.RenameIndex(
                name: "IX_alternate_components_AltCompIdId",
                table: "alternate_components",
                newName: "IX_alternate_components_alt_comp_id");

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_alt_comp_id",
                table: "alternate_components",
                column: "alt_comp_id",
                principalTable: "components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
