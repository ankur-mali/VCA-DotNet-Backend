using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VCA.Migrations
{
    /// <inheritdoc />
    public partial class fv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_comp_id",
                table: "alternate_components");

            migrationBuilder.AddColumn<int>(
                name: "ComponentId1",
                table: "alternate_components",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_alternate_components_ComponentId1",
                table: "alternate_components",
                column: "ComponentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_ComponentId1",
                table: "alternate_components",
                column: "ComponentId1",
                principalTable: "components",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_comp_id",
                table: "alternate_components",
                column: "comp_id",
                principalTable: "components",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_ComponentId1",
                table: "alternate_components");

            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_comp_id",
                table: "alternate_components");

            migrationBuilder.DropIndex(
                name: "IX_alternate_components_ComponentId1",
                table: "alternate_components");

            migrationBuilder.DropColumn(
                name: "ComponentId1",
                table: "alternate_components");

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_comp_id",
                table: "alternate_components",
                column: "comp_id",
                principalTable: "components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
