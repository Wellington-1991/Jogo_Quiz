using Jogo_Quiz.Modal.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jogo_Quiz.Modal.ContextQuiz
{
	public class quizContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-15CIMC2\\SQLEXPRESS; Initial Catalog=Quiz; Integrated Security=true"); //"Server=DESKTOP-15CIMC2\\SQLEXPRESS; Initial Catalog=Quiz; Integrated Security=true"
           
		}

        public DbSet<Pergunta>? Pergunta { get; set; }
        public DbSet<Resposta>? Resposta { get; set; }

	}
}
