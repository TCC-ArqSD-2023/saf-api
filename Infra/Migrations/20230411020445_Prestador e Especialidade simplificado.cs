using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class PrestadoreEspecialidadesimplificado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EspecialidadePrestador",
                schema: "saf");

            migrationBuilder.AddColumn<long>(
                name: "EspecialidadesId",
                schema: "saf",
                table: "Prestador",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Prestador_EspecialidadesId",
                schema: "saf",
                table: "Prestador",
                column: "EspecialidadesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestador_Especialidade_EspecialidadesId",
                schema: "saf",
                table: "Prestador",
                column: "EspecialidadesId",
                principalSchema: "saf",
                principalTable: "Especialidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestador_Especialidade_EspecialidadesId",
                schema: "saf",
                table: "Prestador");

            migrationBuilder.DropIndex(
                name: "IX_Prestador_EspecialidadesId",
                schema: "saf",
                table: "Prestador");

            migrationBuilder.DropColumn(
                name: "EspecialidadesId",
                schema: "saf",
                table: "Prestador");

            migrationBuilder.CreateTable(
                name: "EspecialidadePrestador",
                schema: "saf",
                columns: table => new
                {
                    EspecialidadesId = table.Column<long>(type: "bigint", nullable: false),
                    PrestadorId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspecialidadePrestador", x => new { x.EspecialidadesId, x.PrestadorId });
                    table.ForeignKey(
                        name: "FK_EspecialidadePrestador_Especialidade_EspecialidadesId",
                        column: x => x.EspecialidadesId,
                        principalSchema: "saf",
                        principalTable: "Especialidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EspecialidadePrestador_Prestador_PrestadorId",
                        column: x => x.PrestadorId,
                        principalSchema: "saf",
                        principalTable: "Prestador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EspecialidadePrestador_PrestadorId",
                schema: "saf",
                table: "EspecialidadePrestador",
                column: "PrestadorId");
        }
    }
}
