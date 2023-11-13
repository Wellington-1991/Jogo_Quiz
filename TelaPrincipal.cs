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
                for (int i = 0; i < _respostasAtuais.Count; i++)
                {
                    lbRespostas.Items[i] = "";
                }

                txtPergunta.Text = "";
                btnProximo.Enabled = false;
                btnResponder.Enabled = false;
                lblMostrarResposta.BackColor = Color.White;
                lblMostrarResposta.Text = "Parabéns, você finalizou o jogo!";
			}
		}

		public bool ListarPerguntasRespostas()
		{
			bool conecxaoValida = false;

			using (quizContext quizDao = new quizContext())
			{
				if (quizDao.Database.CanConnect())
				{
                    foreach (Pergunta pergunta in quizDao.Pergunta.ToList())
                    {
                        if (pergunta.Excluido == false)
                        {
                            _perguntas.Add(pergunta);
                        }
                    }
					conecxaoValida = true;
                }
				else
				{
					
                    MessageBox.Show("Erro de conecxão com o banco de dados, verifique se a conectionString está correta!");
                   
                }
			}

			if(_perguntas.Count < 0)
			{
                MessageBox.Show("Não Existem perguntas registradas no banco de dados!");
            }

			return conecxaoValida;
		}

		private void btnResponder_Click(object sender, EventArgs e)
		{
			var items = lbRespostas.Items;

			using (quizContext validarResposta = new quizContext())
			{
				var respostaVerdadeira = validarResposta.Resposta.Where(r => r.PerguntaID == _perguntaAtual.PerguntaID && r.Verdadeiro == true && r.Excluido == false).FirstOrDefault();

				if (respostaVerdadeira.RespostaQuiz == this.lbRespostas.SelectedItem.ToString() && respostaVerdadeira.Verdadeiro == true)
				{
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
			lblMostrarResposta.BackColor = Color.White;

			lblMostrarResposta.Text = "Será que você vai acertar essa?";

			_perguntas.Remove(_perguntaAtual);

			PreecherFormulario();
		}

		private void btnIniciar_Click(object sender, EventArgs e)
		{
			btnIniciar.Enabled = false;

            if (ListarPerguntasRespostas())
			{
				PreecherFormulario();
			}
			else
			{
				this.Close();
			}

			btnProximo.Enabled = true;
			btnResponder.Enabled = true;
		}

        private void btnSair_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}