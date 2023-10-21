using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Entities;
using System.Windows.Forms;

namespace Jogo_Quiz.Modal.Dao
{
    public class PerguntaDao 
    {
        private readonly quizContext _context;

        public PerguntaDao(quizContext context)
        {
            _context = context;
        }

        public Pergunta CriarPergunta()
        {
            Pergunta novaPergunta = new Pergunta();

            //novaPergunta.PerguntaQuiz = "nova";
            novaPergunta.DataCriacao = DateTime.Now.Date;
            novaPergunta.DataAlteracao = DateTime.Now.Date;
            novaPergunta.DataExclusao = DateTime.Now.Date;
            novaPergunta.Excluido = false;

            _context.pergunta.Add(novaPergunta);

            _context.SaveChanges();

            return novaPergunta;
        }
    }
}
