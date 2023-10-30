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
				var listaPerguntas = quizDao.Pergunta.ToList();
				IList<int> perguntasSelecionadas = new List<int>();

				Random randon = new Random();

				foreach (var item in listaPerguntas)
				{

					perguntasSelecionadas.Add(item.PerguntaID);




					
				}

				//var perguntaSelecionada = randon.Next(0,listaPerguntas);





				//txtPergunta.Text = listaPerguntas[perguntaAleatoria].PerguntaQuiz.ToString();




			}
		}
	}
}