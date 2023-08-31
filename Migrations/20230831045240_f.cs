using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VCA.Migrations
{
    /// <inheritdoc />
    public partial class f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_Models_mod_id",
                table: "alternate_components");

            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_AltCompIdId",
                table: "alternate_components");

            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_comp_id",
                table: "alternate_components");

            migrationBuilder.RenameColumn(
                name: "AltCompIdId",
                table: "alternate_components",
                newName: "alt_comp_id");

            migrationBuilder.RenameIndex(
                name: "IX_alternate_components_AltCompIdId",
                table: "alternate_components",
                newName: "IX_alternate_components_alt_comp_id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "registration",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "alternate_components",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ComponentId",
                table: "alternate_components",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    AltCompId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    AuthId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_alternate_components_AltCompId",
                        column: x => x.AltCompId,
                        principalTable: "alternate_components",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Invoices_registration_AuthId",
                        column: x => x.AuthId,
                        principalTable: "registration",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_alternate_components_ComponentId",
                table: "alternate_components",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_AltCompId",
                table: "Invoices",
                column: "AltCompId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_AuthId",
                table: "Invoices",
                column: "AuthId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ModelId",
                table: "Invoices",
                column: "ModelId");

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
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_Models_mod_id",
                table: "alternate_components");

            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_ComponentId",
                table: "alternate_components");

            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_alt_comp_id",
                table: "alternate_components");

            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_comp_id",
                table: "alternate_components");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_alternate_components_ComponentId",
                table: "alternate_components");

            migrationBuilder.DropColumn(
                name: "ComponentId",
                table: "alternate_components");

            migrationBuilder.RenameColumn(
                name: "alt_comp_id",
                table: "alternate_components",
                newName: "AltCompIdId");

            migrationBuilder.RenameIndex(
                name: "IX_alternate_components_alt_comp_id",
                table: "alternate_components",
                newName: "IX_alternate_components_AltCompIdId");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "registration",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "alternate_components",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_Models_mod_id",
                table: "alternate_components",
                column: "mod_id",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_AltCompIdId",
                table: "alternate_components",
                column: "AltCompIdId",
                principalTable: "components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_comp_id",
                table: "alternate_components",
                column: "comp_id",
                principalTable: "components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
