using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Entities;

namespace Jogo_Quiz
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

           // Cursor.Current = new Cursors.WaitCursor);

            Button button = (Button)sender;

            var nome = button.Name;



            using (quizContext Jogador = new quizContext())
            {
                Jogador adicionarJogador = new Jogador();

                adicionarJogador.Nome = txtNome.Text;
                adicionarJogador.DataCriacao = DateTime.Now;

                Jogador.jogador.Add(adicionarJogador);

                Jogador.SaveChanges();
            }

            this.Close();

           // Cursor.Current = Cursors.Default;
        }

        private void btnFinalizarCadastroPergunta_Click(object sender, EventArgs e)
        {

        }
    }
}
