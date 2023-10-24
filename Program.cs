using Jogo_Quiz.Modal;
using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Dao;
using Jogo_Quiz.Modal.Entities;
using System;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();



			using (quizContext quizDao = new quizContext())
			{
				Jogador jogador = new Jogador();
				jogador.Nome = "wellington";
				jogador.Excluido = false;
				quizDao.Add(jogador);

				var nivel = quizDao.Nivel.ToList();

                Jogada jogada = new Jogada();
				jogada.Ponto = 0;
				jogada.nivel = nivel[0];
				jogada.Jogador = jogador;
				quizDao.Jogada.Add(jogada);


				quizDao.SaveChanges();
			}













			Application.Run(new TelaPrincipal());

			//string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

		}
	}
}