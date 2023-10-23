using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Entities;
using System.Windows.Forms;

namespace Jogo_Quiz.Modal.Dao
{
    public class PerguntaDao 
    {
        private readonly quizContext _context;

        private Pergunta _pergunta = new Pergunta();

        public PerguntaDao(quizContext context)
        {
            _context = context;
        }

        public Pergunta CriarPergunta()
        {

            //novaPergunta.PerguntaQuiz = "nova";
            this._pergunta.DataCriacao = DateTime.Now.Date;
            this._pergunta.DataAlteracao = DateTime.Now.Date;
            this._pergunta.DataExclusao = DateTime.Now.Date;
            this._pergunta.Excluido = false;

            _context.pergunta.Add(this._pergunta);

            _context.SaveChanges();

            return _pergunta;
        }

        public Pergunta AlterarPergunta(int perguntaID)
        {

            var alteraPergunta = _context.pergunta.Find(perguntaID);

            return alteraPergunta;
        }
    }
}
