using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VCA.Migrations
{
    /// <inheritdoc />
    public partial class bb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_Models_mod_id",
                table: "alternate_components");

            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_ComponentId",
                table: "alternate_components");

            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_ComponentId1",
                table: "alternate_components");

            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_alt_comp_id",
                table: "alternate_components");

            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_comp_id",
                table: "alternate_components");

            migrationBuilder.DropIndex(
                name: "IX_alternate_components_comp_id",
                table: "alternate_components");

            migrationBuilder.DropIndex(
                name: "IX_alternate_components_ComponentId",
                table: "alternate_components");

            migrationBuilder.DropIndex(
                name: "IX_alternate_components_ComponentId1",
                table: "alternate_components");

            migrationBuilder.DropColumn(
                name: "ComponentId",
                table: "alternate_components");

            migrationBuilder.DropColumn(
                name: "ComponentId1",
                table: "alternate_components");

            migrationBuilder.RenameColumn(
                name: "comp_id",
                table: "alternate_components",
                newName: "CompId");

            migrationBuilder.RenameColumn(
                name: "alt_comp_id",
                table: "alternate_components",
                newName: "AltComponentId");

            migrationBuilder.RenameIndex(
                name: "IX_alternate_components_alt_comp_id",
                table: "alternate_components",
                newName: "IX_alternate_components_AltComponentId");

            migrationBuilder.AlterColumn<int>(
                name: "mod_id",
                table: "alternate_components",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "FK_alternate_components_Models_mod_id",
                table: "alternate_components",
                column: "mod_id",
                principalTable: "Models",
                principalColumn: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_Models_mod_id",
                table: "alternate_components");

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
                newName: "comp_id");

            migrationBuilder.RenameColumn(
                name: "AltComponentId",
                table: "alternate_components",
                newName: "alt_comp_id");

            migrationBuilder.RenameIndex(
                name: "IX_alternate_components_AltComponentId",
                table: "alternate_components",
                newName: "IX_alternate_components_alt_comp_id");

            migrationBuilder.AlterColumn<int>(
                name: "mod_id",
                table: "alternate_components",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ComponentId",
                table: "alternate_components",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ComponentId1",
                table: "alternate_components",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_alternate_components_comp_id",
                table: "alternate_components",
                column: "comp_id");

            migrationBuilder.CreateIndex(
                name: "IX_alternate_components_ComponentId",
                table: "alternate_components",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_alternate_components_ComponentId1",
                table: "alternate_components",
                column: "ComponentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_Models_mod_id",
                table: "alternate_components",
                column: "mod_id",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_ComponentId",
                table: "alternate_components",
                column: "ComponentId",
                principalTable: "components",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_ComponentId1",
                table: "alternate_components",
                column: "ComponentId1",
                principalTable: "components",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_alt_comp_id",
                table: "alternate_components",
                column: "alt_comp_id",
                principalTable: "components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_comp_id",
                table: "alternate_components",
                column: "comp_id",
                principalTable: "components",
                principalColumn: "Id");
        }
    }
}
