
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
        public Pergunta? pergunta { get; set; }
        public NivelDificuldade? Nivel { get; set; }
    }
}
