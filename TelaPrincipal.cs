using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Dao;
using Jogo_Quiz.Modal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Jogo_Quiz
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		

		public void CarregarPerguntas()
		{
		}

		public void EditarPerguntas()
		{

		}

		public void ExcluirPerguntas()
		{

		}

        private void BtnJogador_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

			var nome = button.Name;

            TelaCadastro cadastro = new TelaCadastro();
			cadastro.ShowDialog();

            using (Context ultimoJogadorCadastrado = new Context())
			{
				lblCampoJogador.Text = ultimoJogadorCadastrado.jogador.ToList().Last().Nome;

            }

			
        }

        private void btnCadastrarPerguntas_Click(object sender, EventArgs e)
        {
			Button button = (Button)sender;


			if (true)
			{

			}
            TelaCadastro cadastro = new TelaCadastro();
            cadastro.ShowDialog();






   //         using (Context Cadastrar = new Context())
			//{
			//	Pergunta pergunta = new Pergunta();
			//	pergunta.PerguntaQuiz = "";
			//	//pergunta.nivelID = null;
			//	pergunta.DataCriacao = DateTime.MinValue;
			//	pergunta.DataExclusao = null;
			//	pergunta.DataAlteracao = null;

			//	Cadastrar.SaveChanges();
			//}
        }
    }
}