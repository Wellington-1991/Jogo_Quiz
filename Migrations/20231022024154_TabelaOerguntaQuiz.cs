using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jogo_Quiz.Migrations
{
    public partial class TabelaOerguntaQuiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jogador",
                columns: table => new
                {
                    JogadorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jogador", x => x.JogadorID);
                });

            migrationBuilder.CreateTable(
                name: "pergunta",
                columns: table => new
                {
                    PerguntaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerguntaQuiz = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pergunta", x => x.PerguntaID);
                });

            migrationBuilder.CreateTable(
                name: "jogada",
                columns: table => new
                {
                    JogadaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ponto = table.Column<int>(type: "int", nullable: false),
                    JogadorID = table.Column<int>(type: "int", nullable: false),
                    PerguntaID = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jogada", x => x.JogadaID);
                    table.ForeignKey(
                        name: "FK_jogada_jogador_JogadorID",
                        column: x => x.JogadorID,
                        principalTable: "jogador",
                        principalColumn: "JogadorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_jogada_pergunta_PerguntaID",
                        column: x => x.PerguntaID,
                        principalTable: "pergunta",
                        principalColumn: "PerguntaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nivel",
                columns: table => new
                {
                    NivelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    PerguntaID = table.Column<int>(type: "int", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nivel", x => x.NivelID);
                    table.ForeignKey(
                        name: "FK_nivel_pergunta_PerguntaID",
                        column: x => x.PerguntaID,
                        principalTable: "pergunta",
                        principalColumn: "PerguntaID");
                });

            migrationBuilder.CreateTable(
                name: "resposta",
                columns: table => new
                {
                    RespostaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RespostaQuiz = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Verdadeiro = table.Column<bool>(type: "bit", nullable: true),
                    PerguntaID = table.Column<int>(type: "int", nullable: true),
                    NivelID = table.Column<int>(type: "int", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resposta", x => x.RespostaID);
                    table.ForeignKey(
                        name: "FK_resposta_nivel_NivelID",
                        column: x => x.NivelID,
                        principalTable: "nivel",
                        principalColumn: "NivelID");
                    table.ForeignKey(
                        name: "FK_resposta_pergunta_PerguntaID",
                        column: x => x.PerguntaID,
                        principalTable: "pergunta",
                        principalColumn: "PerguntaID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_jogada_JogadorID",
                table: "jogada",
                column: "JogadorID");

            migrationBuilder.CreateIndex(
                name: "IX_jogada_PerguntaID",
                table: "jogada",
                column: "PerguntaID");

            migrationBuilder.CreateIndex(
                name: "IX_nivel_PerguntaID",
                table: "nivel",
                column: "PerguntaID");

            migrationBuilder.CreateIndex(
                name: "IX_resposta_NivelID",
                table: "resposta",
                column: "NivelID");

            migrationBuilder.CreateIndex(
                name: "IX_resposta_PerguntaID",
                table: "resposta",
                column: "PerguntaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jogada");

            migrationBuilder.DropTable(
                name: "resposta");

            migrationBuilder.DropTable(
                name: "jogador");

            migrationBuilder.DropTable(
                name: "nivel");

            migrationBuilder.DropTable(
                name: "pergunta");
        }
    }
}
