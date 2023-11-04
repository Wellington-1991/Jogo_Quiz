
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jogo_Quiz.Modal.Entities
{
	public class Pergunta : BaseModel
	{
		[Key]
		public int PerguntaID { get; set; }

		[MaxLength(255)]
        public string? PerguntaQuiz { get; set; }

		public virtual IList<Resposta>? Resposta { get; set; }
	}
}
