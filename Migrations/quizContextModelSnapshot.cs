﻿// <auto-generated />
using System;
using Jogo_Quiz.Modal.ContextQuiz;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jogo_Quiz.Migrations
{
    [DbContext(typeof(quizContext))]
    partial class quizContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.ToTable("Pergunta");
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

                    b.Property<int>("PerguntaID")
                        .HasColumnType("int");

                    b.Property<string>("RespostaQuiz")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("Verdadeiro")
                        .HasColumnType("bit");

                    b.HasKey("RespostaID");

                    b.HasIndex("PerguntaID");

                    b.ToTable("Resposta");
                });

            modelBuilder.Entity("Jogo_Quiz.Modal.Entities.Resposta", b =>
                {
                    b.HasOne("Jogo_Quiz.Modal.Entities.Pergunta", "Pergunta")
                        .WithMany("Resposta")
                        .HasForeignKey("PerguntaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pergunta");
                });

            modelBuilder.Entity("Jogo_Quiz.Modal.Entities.Pergunta", b =>
                {
                    b.Navigation("Resposta");
                });
#pragma warning restore 612, 618
        }
    }
}
