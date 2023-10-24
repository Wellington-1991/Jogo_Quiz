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
				//Jogador jogador = new Jogador();
				//jogador.Nome = "wellington";
				//jogador.Excluido = false;
				//quizDao.Add(jogador);

				var nivel = quizDao.Nivel.ToList();
				var pergunta = quizDao.Pergunta.ToList();

				//Jogada jogada = new Jogada();
				//jogada.Ponto = 0;
				//jogada.nivel = nivel[0];
				//jogada.Jogador = jogador;
				//quizDao.Jogada.Add(jogada);


				//Pergunta pergunta = new Pergunta();
				//pergunta.PerguntaQuiz = "O que é, o que é, clara e saldaga, tem sabor de mar pesa uma tonelada?";
				//pergunta.Nivel = nivel[0];
				//pergunta.DataCriacao = DateTime.Now;
				//pergunta.Excluido = false;
				//quizDao.Pergunta.Add(pergunta);

				Resposta resposta0 = new Resposta();
				resposta0.RespostaQuiz = "Água";
				resposta0.Verdadeiro = false;
				resposta0.Pergunta = pergunta[0];
				resposta0.Nivel = nivel[0];
				resposta0.DataCriacao = DateTime.Now;
				resposta0.Excluido = false;
				quizDao.Resposta.Add(resposta0);

				Resposta resposta01 = new Resposta();
				resposta01.RespostaQuiz = "Coca-Kola";
				resposta01.Verdadeiro = false;
				resposta01.Pergunta = pergunta[0];
				resposta01.Nivel = nivel[0];
				resposta01.DataCriacao = DateTime.Now;
				resposta01.Excluido = false;
				quizDao.Resposta.Add(resposta01);

				Resposta resposta02 = new Resposta();
				resposta02.RespostaQuiz = "Lagrimas";
				resposta02.Verdadeiro = true;
				resposta02.Pergunta = pergunta[0];
				resposta02.Nivel = nivel[0];
				resposta02.DataCriacao = DateTime.Now;
				resposta02.Excluido = false;
				quizDao.Resposta.Add(resposta02);


				quizDao.SaveChanges();
			}

			Application.Run(new TelaPrincipal());

			//string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

		}
	}
}