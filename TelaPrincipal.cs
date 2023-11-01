using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Dao;
using Jogo_Quiz.Modal.Entities;
using System.Data;

namespace Jogo_Quiz
{
	public partial class TelaPrincipal : Form
	{
		private quizContext _conexao = new quizContext();
		private int _perguntaID;
		private int _respostaID;

		public TelaPrincipal()
		{
			InitializeComponent();

			IniciarJogo();
		}

		public void IniciarJogo()
		{
			using (quizContext quizDao = new quizContext())
			{
				IList<int> NaoRepetirPerguntas = new List<int>();

				var listaPerguntas = quizDao.Pergunta.ToList();
				var respostas = quizDao.Resposta.Where(r => r.PerguntaID == listaPerguntas[0].PerguntaID).ToList();

				_perguntaID = listaPerguntas[0].PerguntaID;

				txtPergunta.Text = listaPerguntas[0].PerguntaQuiz;

				cbPrimeiraResposta.Text = respostas[0].RespostaQuiz;
				cbSegundaResposta.Text = respostas[1].RespostaQuiz;
				cbTerceiraResposta.Text = respostas[2].RespostaQuiz;

				NaoRepetirPerguntas.Add(_perguntaID);

			}
		}

		private void ValidarResposta(object sender, EventArgs e)
		{
			using (quizContext quizDao = new quizContext())
			{
				var respostas = quizDao.Resposta.Where(p => p.PerguntaID == _perguntaID).ToList();


				if (cbPrimeiraResposta.Checked)
				{
					lblPrimeiraResposta.Visible = true;
					lblPrimeiraResposta.Text = respostas[0].Verdadeiro == true ? "Correta" : "Errada";
					lblPrimeiraResposta.BackColor = respostas[0].Verdadeiro == true ? Color.Green : Color.Red;
				}
				else if (cbSegundaResposta.Checked)
				{
					lblSegundaResposta.Visible = true;
					lblSegundaResposta.Text = respostas[1].Verdadeiro == true ? "Correta" : "Errada";
					lblSegundaResposta.BackColor = respostas[1].Verdadeiro == true ? Color.Green : Color.Red;
				}
				else if(cbSegundaResposta.Checked)
				{
					lblTerceiraResposta.Visible = true;
					lblTerceiraResposta.Text = respostas[2].Verdadeiro == true ? "Correta" : "Errada";
					lblTerceiraResposta.BackColor = respostas[2].Verdadeiro == true ? Color.Green : Color.Red;
				}
			}
		}
	}
}