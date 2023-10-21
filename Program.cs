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
            ApplicationConfiguration.Initialize();


			var conexao = new quizContext();

			var criarPergunta = new PerguntaDao(conexao);



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
			Application.Run(new Form1());

			//string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

		}
	}
}