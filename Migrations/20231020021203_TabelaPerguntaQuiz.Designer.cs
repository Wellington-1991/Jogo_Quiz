﻿// <auto-generated />
using System;
using Jogo_Quiz.Modal.ContextQuiz;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jogo_Quiz.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231020021203_TabelaPerguntaQuiz")]
    partial class TabelaPerguntaQuiz
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Jogo_Quiz.Modal.Entities.Jogada", b =>
                {
                    b.Property<int>("JogadaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JogadaID"), 1L, 1);

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Excluido")
                        .HasColumnType("bit");

                    b.Property<int>("JogadorID")
                        .HasColumnType("int");

                    b.Property<int>("PerguntaID")
                        .HasColumnType("int");

                    b.Property<string>("Ponto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JogadaID");

                    b.HasIndex("JogadorID");

                    b.HasIndex("PerguntaID");

                    b.ToTable("jogada");
                });

            modelBuilder.Entity("Jogo_Quiz.Modal.Entities.Jogador", b =>
                {
                    b.Property<int>("JogadorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JogadorID"), 1L, 1);

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Excluido")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("JogadorID");

                    b.ToTable("jogador");
                });

            modelBuilder.Entity("Jogo_Quiz.Modal.Entities.NivelDificuldade", b =>
                {
                    b.Property<int>("NivelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NivelID"), 1L, 1);

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Excluido")
                        .HasColumnType("bit");

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.Property<int?>("PerguntaID")
                        .HasColumnType("int");

                    b.HasKey("NivelID");

                    b.HasIndex("PerguntaID");

                    b.ToTable("nivel");
                });

            modelBuilder.Entity("Jogo_Quiz.Modal.Entities.Pergunta", b =>
                {
                    b.Property<int>("PerguntaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PerguntaID"), 1L, 1);

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Excluido")
                        .HasColumnType("bit");

                    b.Property<string>("PerguntaQuiz")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("PerguntaID");

                    b.ToTable("pergunta");
                });

            modelBuilder.Entity("Jogo_Quiz.Modal.Entities.Resposta", b =>
                {
                    b.Property<int>("RespostaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RespostaID"), 1L, 1);

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Excluido")
                        .HasColumnType("bit");

                    b.Property<int?>("NivelID")
                        .HasColumnType("int");

                    b.Property<int?>("PerguntaID")
                        .HasColumnType("int");

                    b.Property<string>("RespostaQuiz")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("Verdadeiro")
                        .HasColumnType("bit");

                    b.HasKey("RespostaID");

                    b.HasIndex("NivelID");

                    b.HasIndex("PerguntaID");

                    b.ToTable("resposta");
                });

            modelBuilder.Entity("Jogo_Quiz.Modal.Entities.Jogada", b =>
                {
                    b.HasOne("Jogo_Quiz.Modal.Entities.Jogador", "Jogador")
                        .WithMany()
                        .HasForeignKey("JogadorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jogo_Quiz.Modal.Entities.Pergunta", "Pergunta")
                        .WithMany()
                        .HasForeignKey("PerguntaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jogador");

                    b.Navigation("Pergunta");
                });

            modelBuilder.Entity("Jogo_Quiz.Modal.Entities.NivelDificuldade", b =>
                {
                    b.HasOne("Jogo_Quiz.Modal.Entities.Pergunta", "pergunta")
                        .WithMany("nivelDificuldade")
                        .HasForeignKey("PerguntaID");

                    b.Navigation("pergunta");
                });

            modelBuilder.Entity("Jogo_Quiz.Modal.Entities.Resposta", b =>
                {
                    b.HasOne("Jogo_Quiz.Modal.Entities.NivelDificuldade", "Nivel")
                        .WithMany()
                        .HasForeignKey("NivelID");

                    b.HasOne("Jogo_Quiz.Modal.Entities.Pergunta", "pergunta")
                        .WithMany("respostas")
                        .HasForeignKey("PerguntaID");

                    b.Navigation("Nivel");

                    b.Navigation("pergunta");
                });

            modelBuilder.Entity("Jogo_Quiz.Modal.Entities.Pergunta", b =>
                {
                    b.Navigation("nivelDificuldade");

                    b.Navigation("respostas");
                });
#pragma warning restore 612, 618
        }
    }
}
