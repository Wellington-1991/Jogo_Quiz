
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jogo_Quiz.Modal.Entities
{
	public class Resposta : BaseModel
	{
		[Key]
		public int RespostaID { get; set; }

		[MaxLength(255)]
		public string? RespostaQuiz { get; set; }
        public bool? Verdadeiro { get; set; }

		public int PerguntaID { get; set; }
		public virtual Pergunta? Pergunta { get; set; }
		
	}
}
