using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Entities;

namespace Jogo_Quiz.Modal.Dao
{
    internal class BuscarPerguntaDao : IDisposable
    {
        public void Dispose()
        {
           
        }

        public List<Pergunta> RetornarPerguntas()
        {
            List<Pergunta> perguntas;

            using (Context novaPergunta = new Context())
            {
                perguntas = novaPergunta.pergunta.ToList();
            }

            return perguntas;
        }
    }
}
