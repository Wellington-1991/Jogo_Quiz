using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Entities;
using System.Data;
using System.Linq;

namespace Jogo_Quiz
{
	public partial class TelaPrincipal : Form
	{
        IList<Pergunta> perguntas = new List<Pergunta>();
        IList<Resposta> respostas = new List<Resposta>();

        public TelaPrincipal()
		{
			InitializeComponent();
		}

		public void BuscarPerguntaRespostasJogo()
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

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            BuscarPerguntaRespostasJogo();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            using (quizContext quizDao = new quizContext())
            {
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
                else if (cbTerceiraResposta.Checked)
                {
                    lblTerceiraResposta.Visible = true;
                    lblTerceiraResposta.Text = respostas[2].Verdadeiro == true ? "Correta" : "Errada";
                    lblTerceiraResposta.BackColor = respostas[2].Verdadeiro == true ? Color.Green : Color.Red;
                }
                else
                {
                    MessageBox.Show("Escolha uma resposta!");
                }
            }
        }
    }
}