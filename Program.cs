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
				//var pergunta = quizDao.Pergunta.ToList();

				//Jogada jogada = new Jogada();
				//jogada.Ponto = 0;
				//jogada.nivel = nivel[0];
				//jogada.Jogador = jogador;
				//quizDao.Jogada.Add(jogada);


				Pergunta pergunta = new Pergunta();
				pergunta.PerguntaQuiz = "O que é, o que é, clara e saldaga, tem sabor de mar pesa uma tonelada?";
				pergunta.Nivel = nivel[0];
				pergunta.DataCriacao = DateTime.Now;
				pergunta.Excluido = false;
				quizDao.Pergunta.Add(pergunta);

				Resposta resposta = new Resposta();
				resposta.RespostaQuiz = "Água";
				resposta.Verdadeiro = false;
				resposta.Nivel = nivel[0];
				resposta.DataCriacao = DateTime.Now;
				resposta.Excluido = false;
				quizDao.Resposta.Add(resposta);

				Resposta resposta0 = new Resposta();
				resposta0.RespostaQuiz = "Lágrimas";
				resposta0.Verdadeiro = false;
				resposta0.Nivel = nivel[0];
				resposta0.DataCriacao = DateTime.Now;
				resposta0.Excluido = false;
				quizDao.Resposta.Add(resposta0);

				PerguntaResposta perguntaResposta = new PerguntaResposta();
				perguntaResposta.Pergunta = pergunta;
				perguntaResposta.Resposta = resposta;
				perguntaResposta.Resposta = resposta0;
				quizDao.PerguntaResposta.Add(perguntaResposta);


				quizDao.SaveChanges();
			}

			Application.Run(new TelaPrincipal());

			//string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

		}
	}
}