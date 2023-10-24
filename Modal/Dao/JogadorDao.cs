using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Entities;

namespace Jogo_Quiz.Modal.Dao
{
    public class JogadorDao : IDisposable
    {
        private readonly quizContext _context;

        private Jogador _jogador = new Jogador();

        public JogadorDao(quizContext context)
        {
            _context = context;
        }

        public Jogador CriarJogador(string nome)
        {
            try
            {
                _jogador.Nome = nome;
                _jogador.DataCriacao = DateTime.Now.Date;
                _jogador.DataAlteracao = DateTime.Now.Date;
                _jogador.DataExclusao = DateTime.Now.Date;
                _jogador.Excluido = false;

                _context.Jogador.Add(_jogador);

                _context.SaveChanges();

                return _jogador;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
        }

        public List<Jogador> ListarJogador()
        {
            var listaJogador = _context.Jogador.ToList();            
            
            return listaJogador;
        }
    }
}
