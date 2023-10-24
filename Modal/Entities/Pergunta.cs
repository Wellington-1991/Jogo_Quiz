
using System.ComponentModel.DataAnnotations;

namespace Jogo_Quiz.Modal.Entities
{
	public class Pergunta : BaseModel
	{
		[Key]
		public int PerguntaID { get; set; }

		[MaxLength(255)]
        public string? PerguntaQuiz { get; set; }

        public virtual ICollection<Resposta>? Resposta { get; set; }

        public int NivelID { get; set; }
        public virtual NivelDificuldade? Nivel { get; set; }


    }
}
