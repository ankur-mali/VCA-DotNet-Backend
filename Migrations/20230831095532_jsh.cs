using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VCA.Migrations
{
    /// <inheritdoc />
    public partial class jsh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_AltCompId",
                table: "alternate_components");

            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_AltComponentId",
                table: "alternate_components");

            migrationBuilder.DropIndex(
                name: "IX_alternate_components_AltCompId",
                table: "alternate_components");

            migrationBuilder.DropColumn(
                name: "AltCompId",
                table: "alternate_components");

            migrationBuilder.RenameColumn(
                name: "CompId",
                table: "alternate_components",
                newName: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_alternate_components_ComponentId",
                table: "alternate_components",
                column: "ComponentId");

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_AltComponentId",
                table: "alternate_components",
                column: "AltComponentId",
                principalTable: "components",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_ComponentId",
                table: "alternate_components",
                column: "ComponentId",
                principalTable: "components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_AltComponentId",
                table: "alternate_components");

            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_ComponentId",
                table: "alternate_components");

            migrationBuilder.DropIndex(
                name: "IX_alternate_components_ComponentId",
                table: "alternate_components");

            migrationBuilder.RenameColumn(
                name: "ComponentId",
                table: "alternate_components",
                newName: "CompId");

            migrationBuilder.AddColumn<int>(
                name: "AltCompId",
                table: "alternate_components",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_alternate_components_AltCompId",
                table: "alternate_components",
                column: "AltCompId");

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_AltCompId",
                table: "alternate_components",
                column: "AltCompId",
                principalTable: "components",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_AltComponentId",
                table: "alternate_components",
                column: "AltComponentId",
                principalTable: "components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
