using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Dao;
using Jogo_Quiz.Modal.Entities;

namespace Jogo_Quiz
{
	public partial class TelaPrincipal : Form
	{
		private quizContext _conexao = new quizContext();

		public TelaPrincipal()
		{
			InitializeComponent();

			IniciarJogo();
		}

		public void IniciarJogo()
		{
			using (quizContext quizDao = new quizContext())
			{
				var listaPerguntas = quizDao.Pergunta.ToList();
				var respostas = quizDao.Resposta.Where(r => r.PerguntaID == listaPerguntas[0].PerguntaID).ToList();

				Random randon = new Random();

				//var perguntaSelecionada = randon.Next(perguntasSelecionadas[0], perguntasSelecionadas[2]);





				txtPergunta.Text = listaPerguntas[0].PerguntaQuiz;


				var teste = respostas.Select(r => r.RespostaQuiz).ToList();


				foreach (var item in teste)
				{
					gdvGridResposta.DataSource = item;


				}





			}
		}
	}
}