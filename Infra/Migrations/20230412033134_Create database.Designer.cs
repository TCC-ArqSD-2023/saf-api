﻿// <auto-generated />
using System;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(SafDbContexto))]
    [Migration("20230412033134_Create database")]
    partial class Createdatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("saf")
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GisaDominio.Entidades.Associado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DataEmissaoDocumento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("EnderecoId")
                        .HasColumnType("bigint");

                    b.Property<int>("EstadoCivil")
                        .HasColumnType("int");

                    b.Property<int>("Naturalidade")
                        .HasColumnType("int");

                    b.Property<string>("NaturalidadeCidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeMae")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgaoDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PlanoId")
                        .HasColumnType("bigint");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<int>("Situacao")
                        .HasColumnType("int");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UfDocumento")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("PlanoId");

                    b.ToTable("Associado", "saf");
                });

            modelBuilder.Entity("GisaDominio.Entidades.Conveniado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("EnderecoId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Conveniado", "saf");
                });

            modelBuilder.Entity("GisaDominio.Entidades.Endereco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Uf")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Endereco", "saf");
                });

            modelBuilder.Entity("GisaDominio.Entidades.Especialidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Especialidade", "saf");
                });

            modelBuilder.Entity("GisaDominio.Entidades.Plano", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<string>("CodigoAns")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdadeMaxima")
                        .HasColumnType("int");

                    b.Property<int>("IdadeMinima")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Odonto")
                        .HasColumnType("bit");

                    b.Property<int>("QuantidadeConsultasAno")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeExamesAno")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<double>("ValorMensalidade")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Plano", "saf");
                });

            modelBuilder.Entity("GisaDominio.Entidades.Prestador", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<long>("EnderecoAtendimentoId")
                        .HasColumnType("bigint");

                    b.Property<long>("EspecialidadeId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumentoProfissional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoAtendimentoId");

                    b.HasIndex("EspecialidadeId");

                    b.ToTable("Prestador", "saf");
                });

            modelBuilder.Entity("GisaDominio.Entidades.Associado", b =>
                {
                    b.HasOne("GisaDominio.Entidades.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GisaDominio.Entidades.Plano", "Plano")
                        .WithMany()
                        .HasForeignKey("PlanoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Endereco");

                    b.Navigation("Plano");
                });

            modelBuilder.Entity("GisaDominio.Entidades.Conveniado", b =>
                {
                    b.HasOne("GisaDominio.Entidades.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("GisaDominio.Entidades.Prestador", b =>
                {
                    b.HasOne("GisaDominio.Entidades.Endereco", "EnderecoAtendimento")
                        .WithMany()
                        .HasForeignKey("EnderecoAtendimentoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GisaDominio.Entidades.Especialidade", "Especialidade")
                        .WithMany()
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("EnderecoAtendimento");

                    b.Navigation("Especialidade");
                });
#pragma warning restore 612, 618
        }
    }
}
