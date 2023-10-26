
using System.ComponentModel.DataAnnotations;

namespace Jogo_Quiz.Modal.Entities
{
	public class Resposta : BaseModel
	{
		[Key]
		public int RespostaID { get; set; }

		[MaxLength(255)]
		public string? RespostaQuiz { get; set; }
        public bool? Verdadeiro { get; set; }

        public int NivelID { get; set; }
        public virtual NivelDificuldade? Nivel { get; set; }

		public virtual ICollection<PerguntaResposta>? PerguntaResposta { get; set; }
		
	}
}
