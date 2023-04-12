using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Createdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "saf");

            migrationBuilder.CreateTable(
                name: "Endereco",
                schema: "saf",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uf = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialidade",
                schema: "saf",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plano",
                schema: "saf",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoAns = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Odonto = table.Column<bool>(type: "bit", nullable: false),
                    IdadeMinima = table.Column<int>(type: "int", nullable: false),
                    IdadeMaxima = table.Column<int>(type: "int", nullable: false),
                    QuantidadeConsultasAno = table.Column<int>(type: "int", nullable: false),
                    QuantidadeExamesAno = table.Column<int>(type: "int", nullable: false),
                    ValorMensalidade = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plano", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conveniado",
                schema: "saf",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conveniado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conveniado_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalSchema: "saf",
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prestador",
                schema: "saf",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    NumeroDocumentoProfissional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EspecialidadeId = table.Column<long>(type: "bigint", nullable: false),
                    EnderecoAtendimentoId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestador_Endereco_EnderecoAtendimentoId",
                        column: x => x.EnderecoAtendimentoId,
                        principalSchema: "saf",
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prestador_Especialidade_EspecialidadeId",
                        column: x => x.EspecialidadeId,
                        principalSchema: "saf",
                        principalTable: "Especialidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Associado",
                schema: "saf",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoCivil = table.Column<int>(type: "int", nullable: false),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    Naturalidade = table.Column<int>(type: "int", nullable: false),
                    NaturalidadeCidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UfDocumento = table.Column<int>(type: "int", nullable: false),
                    OrgaoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEmissaoDocumento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomeMae = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomePai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    PlanoId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Associado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Associado_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalSchema: "saf",
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Associado_Plano_PlanoId",
                        column: x => x.PlanoId,
                        principalSchema: "saf",
                        principalTable: "Plano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Associado_EnderecoId",
                schema: "saf",
                table: "Associado",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Associado_PlanoId",
                schema: "saf",
                table: "Associado",
                column: "PlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Conveniado_EnderecoId",
                schema: "saf",
                table: "Conveniado",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestador_EnderecoAtendimentoId",
                schema: "saf",
                table: "Prestador",
                column: "EnderecoAtendimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestador_EspecialidadeId",
                schema: "saf",
                table: "Prestador",
                column: "EspecialidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Associado",
                schema: "saf");

            migrationBuilder.DropTable(
                name: "Conveniado",
                schema: "saf");

            migrationBuilder.DropTable(
                name: "Prestador",
                schema: "saf");

            migrationBuilder.DropTable(
                name: "Plano",
                schema: "saf");

            migrationBuilder.DropTable(
                name: "Endereco",
                schema: "saf");

            migrationBuilder.DropTable(
                name: "Especialidade",
                schema: "saf");
        }
    }
}
