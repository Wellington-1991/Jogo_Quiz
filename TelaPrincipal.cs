using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Dao;

namespace Jogo_Quiz
{
	public partial class TelaPrincipal : Form
	{
		private quizContext _conexao = new quizContext();

		public TelaPrincipal()
		{
			InitializeComponent();
		}

        private void BtnJogador_Click(object sender, EventArgs e)
        {
			// TelaCadastro cadastro = new TelaCadastro();
			//cadastro.ShowDialog();

			

			using (JogadorDao criarJogador = new JogadorDao(_conexao))
			{
                var jogadorCadastrado = criarJogador.CriarJogador(txtGeral.Text);
                string mensagem = "";

                if (String.IsNullOrEmpty(txtGeral.Text))
				{
					if (jogadorCadastrado.JogadorID > 0)
					{
						mensagem = $"Jogador: {jogadorCadastrado} cadastrado com sucesso! ";
					}
					else
					{
						mensagem = $"Erro ao salvar o Jogador: {jogadorCadastrado} ";
					}
				}
				Console.WriteLine(mensagem);

                //MessageBox.Show(mensagem);
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

        private void gdvGridPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
    }
}