using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Entities;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Quiz.Modal.Dao
{
    public class JogadaDao : IDisposable
    {
        private readonly quizContext context;
        
        private Jogada _jogada = new Jogada();

        public JogadaDao(quizContext context)
        {
            this.context = context;
        }

        public Jogada CriarJogada(int jogadorID)
        {
            _jogada.Jogador.JogadorID = jogadorID;
            _jogada.Ponto = 0;
            _jogada.DataCriacao = DateTime.Now.Date;
            _jogada.DataAlteracao = DateTime.Now.Date;
            _jogada.DataExclusao = DateTime.Now.Date;
            _jogada.Excluido = false;

            return _jogada;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
