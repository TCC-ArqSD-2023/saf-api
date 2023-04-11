using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Correçãoprestadoresp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestador_Especialidade_EspecialidadesId",
                schema: "saf",
                table: "Prestador");

            migrationBuilder.RenameColumn(
                name: "EspecialidadesId",
                schema: "saf",
                table: "Prestador",
                newName: "EspecialidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Prestador_EspecialidadesId",
                schema: "saf",
                table: "Prestador",
                newName: "IX_Prestador_EspecialidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestador_Especialidade_EspecialidadeId",
                schema: "saf",
                table: "Prestador",
                column: "EspecialidadeId",
                principalSchema: "saf",
                principalTable: "Especialidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestador_Especialidade_EspecialidadeId",
                schema: "saf",
                table: "Prestador");

            migrationBuilder.RenameColumn(
                name: "EspecialidadeId",
                schema: "saf",
                table: "Prestador",
                newName: "EspecialidadesId");

            migrationBuilder.RenameIndex(
                name: "IX_Prestador_EspecialidadeId",
                schema: "saf",
                table: "Prestador",
                newName: "IX_Prestador_EspecialidadesId");

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
    }
}
