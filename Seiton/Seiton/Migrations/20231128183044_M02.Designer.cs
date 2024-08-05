﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Seiton.Models;

#nullable disable

namespace Seiton.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20231128183044_M02")]
    partial class M02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Seiton.Models.Colunas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdProjeto")
                        .HasColumnType("int");

                    b.Property<string>("cor_coluna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome_coluna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quant_tarefas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdProjeto");

                    b.ToTable("Colunas");
                });

            modelBuilder.Entity("Seiton.Models.Projeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("nome_projeto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quant_colunas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Projetos");
                });

            modelBuilder.Entity("Seiton.Models.Tarefas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdColuna")
                        .HasColumnType("int");

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome_tarefas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("prioridade")
                        .HasColumnType("int");

                    b.Property<string>("responsavel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdColuna");

                    b.ToTable("Tarefas");
                });

            modelBuilder.Entity("Seiton.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Seiton.Models.Colunas", b =>
                {
                    b.HasOne("Seiton.Models.Projeto", "Projeto")
                        .WithMany("Colunas")
                        .HasForeignKey("IdProjeto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Projeto");
                });

            modelBuilder.Entity("Seiton.Models.Projeto", b =>
                {
                    b.HasOne("Seiton.Models.Usuario", "Usuario")
                        .WithMany("Projeto")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Seiton.Models.Tarefas", b =>
                {
                    b.HasOne("Seiton.Models.Colunas", "Colunas")
                        .WithMany("Tarefas")
                        .HasForeignKey("IdColuna")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colunas");
                });

            modelBuilder.Entity("Seiton.Models.Colunas", b =>
                {
                    b.Navigation("Tarefas");
                });

            modelBuilder.Entity("Seiton.Models.Projeto", b =>
                {
                    b.Navigation("Colunas");
                });

            modelBuilder.Entity("Seiton.Models.Usuario", b =>
                {
                    b.Navigation("Projeto");
                });
#pragma warning restore 612, 618
        }
    }
}
