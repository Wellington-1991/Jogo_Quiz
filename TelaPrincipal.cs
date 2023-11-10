using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Entities;
using System.Data;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Jogo_Quiz
{
	public partial class TelaPrincipal : Form
	{
		private List<Pergunta> _perguntas = new List<Pergunta>();
		private Pergunta _perguntaAtual = new Pergunta();
		private List<Resposta> _respostasAtuais = new List<Resposta>();
		private int _totalPerguntas = 0;


		public TelaPrincipal()
		{
			InitializeComponent();

			ListarPerguntasRespostas();
		}

		public void PreecherFormulario()
		{
			_totalPerguntas = _perguntas.Count;

			Pergunta pergunta = _perguntas.FirstOrDefault();
			_perguntaAtual = pergunta;

			if (_totalPerguntas > 0 && !String.IsNullOrEmpty(_perguntaAtual.ToString()))
			{
				if (!String.IsNullOrEmpty(_perguntaAtual.ToString()))
				{
					using (quizContext listarRespostas = new quizContext())
					{
						_respostasAtuais = listarRespostas.Resposta.Where(r => r.PerguntaID == pergunta.PerguntaID).ToList();

						txtPergunta.Text = pergunta.PerguntaQuiz;

						for (int i = 0; i < _respostasAtuais.Count; i++)
						{
							lbRespostas.Items[i] = _respostasAtuais[i].RespostaQuiz;
						}
					}
				}
				else
				{
					MessageBox.Show("Banco de dados vázio, Insira algumas perguntas por favor!");
				}
			}
			else
			{
				//Habilitar o botão para reiniciar o jogo
				MessageBox.Show("Parabéns, você finalizou o jogo!");
				lblMostrarResposta.Text = "Parabéns, você finalizou o jogo!";
			}
			

		}

		public void ListarPerguntasRespostas()
		{
			using (quizContext quizDao = new quizContext())
			{
				foreach (Pergunta pergunta in quizDao.Pergunta.ToList())
				{
					_perguntas.Add(pergunta);
				}
			}
		}

		private void btnResponder_Click(object sender, EventArgs e)
		{
			var items = lbRespostas.Items;

			using (quizContext validarResposta = new quizContext())
			{
				var respostaVerdadeira = validarResposta.Resposta.Where(r => r.PerguntaID == _perguntaAtual.PerguntaID && r.Verdadeiro == true).FirstOrDefault().RespostaQuiz;

				if (respostaVerdadeira == this.lbRespostas.SelectedItem.ToString())
				{
					foreach (var item in items)
					{
						if (item != this.lbRespostas.SelectedItem.ToString())
						{
							this.lbRespostas.Text = "----------";
						}
					}

					lblMostrarResposta.Text = "Respota correta, parabéns!";
					lblMostrarResposta.BackColor = Color.Green;
				}
				else
				{
					lblMostrarResposta.Text = "Respota errada, tente novamente!";
					lblMostrarResposta.BackColor = Color.IndianRed;
				}
			}
		}

		private void btnProximo_Click(object sender, EventArgs e)
		{
			lblMostrarResposta.Text = "Será que você vai acertar essa?";

			_perguntas.Remove(_perguntaAtual);

			PreecherFormulario();
		}

		private void btnIniciar_Click(object sender, EventArgs e)
		{
			PreecherFormulario();
		}
	}
}