using Jogo_Quiz.Modal.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jogo_Quiz.Modal.ContextQuiz
{
	public class quizContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-15CIMC2\\SQLEXPRESS; Initial Catalog=Quiz; Integrated Security=true");
		}

		public DbSet<Jogada> jogada { get; set; }
        public DbSet<Jogador> jogador { get; set; }
        public DbSet<NivelDificuldade> nivel { get; set; }
        public DbSet<Pergunta> pergunta { get; set; }
        public DbSet<Resposta> resposta { get; set; }
    }
}
