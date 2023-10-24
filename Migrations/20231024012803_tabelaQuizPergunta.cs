using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jogo_Quiz.Migrations
{
    public partial class tabelaQuizPergunta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogador",
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
                    table.PrimaryKey("PK_Jogador", x => x.JogadorID);
                });

            migrationBuilder.CreateTable(
                name: "Nivel",
                columns: table => new
                {
                    NivelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nivel", x => x.NivelID);
                });

            migrationBuilder.CreateTable(
                name: "Jogada",
                columns: table => new
                {
                    JogadaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ponto = table.Column<int>(type: "int", nullable: false),
                    JogadorID = table.Column<int>(type: "int", nullable: true),
                    NivelID = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogada", x => x.JogadaID);
                    table.ForeignKey(
                        name: "FK_Jogada_Jogador_JogadorID",
                        column: x => x.JogadorID,
                        principalTable: "Jogador",
                        principalColumn: "JogadorID");
                    table.ForeignKey(
                        name: "FK_Jogada_Nivel_NivelID",
                        column: x => x.NivelID,
                        principalTable: "Nivel",
                        principalColumn: "NivelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pergunta",
                columns: table => new
                {
                    PerguntaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerguntaQuiz = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NivelID = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pergunta", x => x.PerguntaID);
                    table.ForeignKey(
                        name: "FK_Pergunta_Nivel_NivelID",
                        column: x => x.NivelID,
                        principalTable: "Nivel",
                        principalColumn: "NivelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resposta",
                columns: table => new
                {
                    RespostaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RespostaQuiz = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Verdadeiro = table.Column<bool>(type: "bit", nullable: true),
                    PerguntaID = table.Column<int>(type: "int", nullable: true),
                    NivelID = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resposta", x => x.RespostaID);
                    table.ForeignKey(
                        name: "FK_Resposta_Nivel_NivelID",
                        column: x => x.NivelID,
                        principalTable: "Nivel",
                        principalColumn: "NivelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resposta_Pergunta_PerguntaID",
                        column: x => x.PerguntaID,
                        principalTable: "Pergunta",
                        principalColumn: "PerguntaID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jogada_JogadorID",
                table: "Jogada",
                column: "JogadorID");

            migrationBuilder.CreateIndex(
                name: "IX_Jogada_NivelID",
                table: "Jogada",
                column: "NivelID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pergunta_NivelID",
                table: "Pergunta",
                column: "NivelID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Resposta_NivelID",
                table: "Resposta",
                column: "NivelID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Resposta_PerguntaID",
                table: "Resposta",
                column: "PerguntaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogada");

            migrationBuilder.DropTable(
                name: "Resposta");

            migrationBuilder.DropTable(
                name: "Jogador");

            migrationBuilder.DropTable(
                name: "Pergunta");

            migrationBuilder.DropTable(
                name: "Nivel");
        }
    }
}
