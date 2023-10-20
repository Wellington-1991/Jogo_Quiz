using Jogo_Quiz.Modal;
using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Dao;
using Jogo_Quiz.Modal.Entities;

namespace Jogo_Quiz
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			using (Context c = new Context()) 
			{
				Jogador J = new Jogador();
				J.Nome = "TOM";
				J.Excluido = false;
				//var pergunta = c.pergunta.ToList();
				//Pergunta novaPergunta = new Pergunta();
				//novaPergunta.PerguntaQuiz = "2 + 2";
				//novaPergunta.DataCriacao = DateTime.Now;
				//novaPergunta.DataAlteracao = DateTime.Now;
				//novaPergunta.Excluido = false;


				var teste = c.SaveChanges();

			}
			var pergunta01 = "";

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
			Application.Run(new Form1());

			//string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

		}
	}
}