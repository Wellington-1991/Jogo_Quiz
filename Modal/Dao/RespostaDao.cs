using Jogo_Quiz.Modal.ContextQuiz;
using Jogo_Quiz.Modal.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Quiz.Modal.Dao
{
    public class RespostaDao
    {
        private readonly quizContext _context;

        public RespostaDao(quizContext context)
        {
            _context = context;
        }


        public Resposta CriarRespostas()
        {
            Resposta novasRespostas = new Resposta();

            novasRespostas.RespostaQuiz = "nova";
            novasRespostas.Verdadeiro = true;
            novasRespostas.PerguntaID = 1;
            novasRespostas.DataCriacao = DateTime.Now.Date;
            novasRespostas.DataAlteracao = DateTime.Now.Date;
            novasRespostas.DataExclusao = DateTime.Now.Date;
            novasRespostas.Excluido = false;

            _context.resposta.Add(novasRespostas);

            _context.SaveChanges();

            return novasRespostas;
        }
    }
}
