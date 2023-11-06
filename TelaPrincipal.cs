using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Entities;
using System.Data;
using System.Linq;

namespace Jogo_Quiz
{
	public partial class TelaPrincipal : Form
	{
		private quizContext _context = new quizContext();
		List<Pergunta> perguntas = new List<Pergunta>();
		List<Resposta> respostas = new List<Resposta>();
		private int _contador;

		public TelaPrincipal()
		{
			InitializeComponent();

			ListarPerguntasRespostas();
		}

		public void PreecherFormulario()
		{
			Pergunta pergunta = perguntas.FirstOrDefault();

			var pergun = pergunta.Resposta.ToList();

			if (!String.IsNullOrEmpty(pergunta.ToString()))
			{
				txtPergunta.Text = pergunta.PerguntaQuiz;
				cbPrimeiraResposta.Text = pergunta.Resposta[0].RespostaQuiz;
				cbSegundaResposta.Text = pergunta.Resposta[1].RespostaQuiz;
				cbTerceiraResposta.Text = pergunta.Resposta[2].RespostaQuiz;

				//perguntas.Remove(pergunta);
			}
			else
			{
				MessageBox.Show("Banco de dados vázio, Insira algumas perguntas por favor!");
			}

		}

		public void ListarPerguntasRespostas()
		{
			using (quizContext quizDao = new quizContext())
			{
				foreach (Pergunta pergunta in quizDao.Pergunta.ToList())
				{
					perguntas.Add(pergunta);
				}

				foreach (Resposta resposta in quizDao.Resposta.ToList())
				{
					respostas.Add(resposta);
				}
			}
		}

		private void btnResponder_Click(object sender, EventArgs e)
		{
			bool botaoClicado = false;
			if (cbPrimeiraResposta.Checked)
			{
				lblPrimeiraResposta.Visible = true;
				lblPrimeiraResposta.Text = respostas[_contador].Verdadeiro == true ? "Correta" : "Errada";
				lblPrimeiraResposta.BackColor = respostas[_contador].Verdadeiro == true ? Color.Green : Color.Red;
				botaoClicado = true;
			}
			else if (cbSegundaResposta.Checked)
			{
				lblSegundaResposta.Visible = true;
				lblSegundaResposta.Text = respostas[_contador].Verdadeiro == true ? "Correta" : "Errada";
				lblSegundaResposta.BackColor = respostas[_contador].Verdadeiro == true ? Color.Green : Color.Red;
				botaoClicado = true;
			}
			else if (cbTerceiraResposta.Checked)
			{
				lblTerceiraResposta.Visible = true;
				lblTerceiraResposta.Text = respostas[_contador].Verdadeiro == true ? "Correta" : "Errada";
				lblTerceiraResposta.BackColor = respostas[_contador].Verdadeiro == true ? Color.Green : Color.Red;
				botaoClicado = true;
			}
			else
			{
				MessageBox.Show("Escolha uma resposta!");
			}

			if (botaoClicado == true)
			{
				//perguntas.Remove(pergunta);
			}
		}

		private void btnProximo_Click(object sender, EventArgs e)
		{







			PreecherFormulario();
		}

		private void btnIniciar_Click(object sender, EventArgs e)
		{
			PreecherFormulario();
		}
	}
}