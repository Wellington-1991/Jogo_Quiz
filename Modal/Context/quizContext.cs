using Jogo_Quiz.Modal.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jogo_Quiz.Modal.ContextQuiz
{
	public class quizContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost; Initial Catalog=Quiz; Integrated Security=true"); //"Server=DESKTOP-15CIMC2\\SQLEXPRESS; Initial Catalog=Quiz; Integrated Security=true"
		}

		public DbSet<Jogada> Jogada { get; set; }
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<NivelDificuldade> Nivel { get; set; }
        public DbSet<Pergunta> Pergunta { get; set; }
        public DbSet<Resposta> Resposta { get; set; }

		public DbSet<PerguntaResposta> PerguntaResposta { get; set; }
	}
}
