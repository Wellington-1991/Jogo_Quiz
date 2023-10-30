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
		}

		public void IniciarJogo()
		{
			using (quizContext quizDao = new quizContext())
			{
				var listaPerguntas = quizDao.Pergunta.ToList().Select(p => p.PerguntaID);
				IList<int> perguntasSelecionadas = new List<int>();

				Random randon = new Random();

				foreach (var item in listaPerguntas)
				{

					perguntasSelecionadas.Add(item);




					
				}

				var perguntaSelecionada = randon.Next(perguntasSelecionadas.Count());



				//var teste = perguntaSelecionada;
				//Resposta resposta1 = new Resposta();
				//resposta1.PerguntaID = listaPerguntas[perguntaSelecionada].PerguntaID;

				//Resposta respostas = quizDao.Resposta.ToList();




				//txtPergunta.Text = listaPerguntas[perguntaAleatoria].PerguntaQuiz.ToString();




			}
		}
	}
}