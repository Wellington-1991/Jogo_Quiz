using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Entities;
using System.Data;
using System.Linq;

namespace Jogo_Quiz
{
	public partial class TelaPrincipal : Form
	{
		private List<Pergunta> _perguntas = new List<Pergunta>();
		private Pergunta _perguntaAtual = new Pergunta();
		private List<Resposta> _respostasAtuais = new List<Resposta>();


		public TelaPrincipal()
		{
			InitializeComponent();

			ListarPerguntasRespostas();
		}

		public void PreecherFormulario()
		{
			Pergunta pergunta = _perguntas.FirstOrDefault();
			_perguntaAtual = pergunta;

			if (!String.IsNullOrEmpty(_perguntaAtual.ToString()))
			{
				using (quizContext listarRespostas = new quizContext())
				{
					_respostasAtuais = listarRespostas.Resposta.Where(r => r.PerguntaID == pergunta.PerguntaID).ToList();
				}

				for (int i = 0; i < _respostasAtuais.Count; i++)
				{
					cbRespostas.Items[i] = _respostasAtuais[i].RespostaQuiz;
				}

				txtPergunta.Text = pergunta.PerguntaQuiz;
				//cbPrimeiraResposta.Text = _respostasAtuais[0].RespostaQuiz;
				//cbSegundaResposta.Text = _respostasAtuais[1].RespostaQuiz;
				//cbTerceiraResposta.Text = _respostasAtuais[2].RespostaQuiz;
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
					_perguntas.Add(pergunta);
				}
			}
		}

		private void btnResponder_Click(object sender, EventArgs e)
		{


			bool botaoClicado = false;

			//if (cbRespostas)
			//{

			//}
			//if (cbRespostas.Checked)
			//{

			//}
			//if (cbPrimeiraResposta.Checked)
			//{
			//	lblPrimeiraResposta.Visible = true;
			//	lblPrimeiraResposta.Text = _respostasAtuais[0].Verdadeiro == true ? "Correta" : "Errada";
			//	lblPrimeiraResposta.BackColor = _respostasAtuais[0].Verdadeiro == true ? Color.Green : Color.Red;
				
			//}
			//else if (cbSegundaResposta.Checked)
			//{
			//	lblSegundaResposta.Visible = true;
			//	lblSegundaResposta.Text = _respostasAtuais[1].Verdadeiro == true ? "Correta" : "Errada";
			//	lblSegundaResposta.BackColor = _respostasAtuais[1].Verdadeiro == true ? Color.Green : Color.Red;
		
			//}
			//else if (cbTerceiraResposta.Checked)
			//{
			//	lblTerceiraResposta.Visible = true;
			//	lblTerceiraResposta.Text = _respostasAtuais[2].Verdadeiro == true ? "Correta" : "Errada";
			//	lblTerceiraResposta.BackColor = _respostasAtuais[2].Verdadeiro == true ? Color.Green : Color.Red;
				
			//}
			//else
			//{
			//	MessageBox.Show("Escolha uma resposta!");
			//}


		}

		private void btnProximo_Click(object sender, EventArgs e)
		{
			_perguntas.Remove(_perguntaAtual);

			PreecherFormulario();
		}

		private void btnIniciar_Click(object sender, EventArgs e)
		{
			PreecherFormulario();
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var ola = cbRespostas.CheckedItems;
		}
	}
}