using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Entities;
using System.Data;
using System.Linq;

namespace Jogo_Quiz
{
	public partial class TelaPrincipal : Form
	{
        private quizContext _context = new quizContext();
        private int _contador;

        public TelaPrincipal()
		{
			InitializeComponent();
        }

		public List<Pergunta> ListarPerguntas()
		{
            List<Pergunta> perguntas = new List<Pergunta>();

            using (quizContext quizDao = new quizContext())
			{
                foreach (Pergunta pergunta in quizDao.Pergunta.ToList())
                {
                    perguntas.Add(pergunta);
                }
            }

            return perguntas;
        }

        public void PreencherFormulario()
        {
            var perguntas = ListarPerguntas();
            using (quizContext respostas = new quizContext())
            {

            }


            for (int i = 0; i <= perguntas.Count; i++)
            {
                txtPergunta.Text = perguntas[i].PerguntaQuiz;
                cbPrimeiraResposta.Text = "";
                cbSegundaResposta.Text = "";
                cbTerceiraResposta.Text = "";
            }

            
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            //if (cbPrimeiraResposta.Checked)
            //{
            //    lblPrimeiraResposta.Visible = true;
            //    lblPrimeiraResposta.Text = respostas[_contador].Verdadeiro == true ? "Correta" : "Errada";
            //    lblPrimeiraResposta.BackColor = respostas[_contador].Verdadeiro == true ? Color.Green : Color.Red;
            //}
            //else if (cbSegundaResposta.Checked)
            //{
            //    lblSegundaResposta.Visible = true;
            //    lblSegundaResposta.Text = respostas[_contador].Verdadeiro == true ? "Correta" : "Errada";
            //    lblSegundaResposta.BackColor = respostas[_contador].Verdadeiro == true ? Color.Green : Color.Red;
            //}
            //else if (cbTerceiraResposta.Checked)
            //{
            //    lblTerceiraResposta.Visible = true;
            //    lblTerceiraResposta.Text = respostas[_contador].Verdadeiro == true ? "Correta" : "Errada";
            //    lblTerceiraResposta.BackColor = respostas[_contador].Verdadeiro == true ? Color.Green : Color.Red;
            //}
            //else
            //{
            //    MessageBox.Show("Escolha uma resposta!");
            //}
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
           
        }
    }
}