using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class ConfigInicial : Migration
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cep = table.Column<string>(type: "text", nullable: false),
                    Logradouro = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    Uf = table.Column<int>(type: "integer", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    Complemento = table.Column<string>(type: "text", nullable: false)
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    CodigoAns = table.Column<string>(type: "text", nullable: false),
                    Categoria = table.Column<int>(type: "integer", nullable: false),
                    Tipo = table.Column<int>(type: "integer", nullable: false),
                    Odonto = table.Column<bool>(type: "boolean", nullable: false),
                    IdadeMinima = table.Column<int>(type: "integer", nullable: false),
                    IdadeMaxima = table.Column<int>(type: "integer", nullable: false),
                    QuantidadeConsultasAno = table.Column<int>(type: "integer", nullable: false),
                    QuantidadeExamesAno = table.Column<int>(type: "integer", nullable: false),
                    ValorMensalidade = table.Column<double>(type: "double precision", nullable: false)
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false)
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prestador",
                schema: "saf",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Sobrenome = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    NumeroDocumentoProfissional = table.Column<string>(type: "text", nullable: false),
                    EnderecoAtendimentoId = table.Column<long>(type: "bigint", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false)
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Associado",
                schema: "saf",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Sobrenome = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    EstadoCivil = table.Column<int>(type: "integer", nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    Naturalidade = table.Column<int>(type: "integer", nullable: false),
                    NaturalidadeCidade = table.Column<string>(type: "text", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "text", nullable: false),
                    UfDocumento = table.Column<int>(type: "integer", nullable: false),
                    OrgaoDocumento = table.Column<string>(type: "text", nullable: false),
                    DataEmissaoDocumento = table.Column<DateOnly>(type: "date", nullable: false),
                    NomeMae = table.Column<string>(type: "text", nullable: false),
                    NomePai = table.Column<string>(type: "text", nullable: false),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    Situacao = table.Column<int>(type: "integer", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Associado_Plano_PlanoId",
                        column: x => x.PlanoId,
                        principalSchema: "saf",
                        principalTable: "Plano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_EspecialidadePrestador_PrestadorId",
                schema: "saf",
                table: "EspecialidadePrestador",
                column: "PrestadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestador_EnderecoAtendimentoId",
                schema: "saf",
                table: "Prestador",
                column: "EnderecoAtendimentoId");
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
                name: "EspecialidadePrestador",
                schema: "saf");

            migrationBuilder.DropTable(
                name: "Plano",
                schema: "saf");

            migrationBuilder.DropTable(
                name: "Especialidade",
                schema: "saf");

            migrationBuilder.DropTable(
                name: "Prestador",
                schema: "saf");

            migrationBuilder.DropTable(
                name: "Endereco",
                schema: "saf");
        }
    }
}
