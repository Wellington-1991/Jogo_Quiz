
using System.ComponentModel.DataAnnotations;

namespace Jogo_Quiz.Modal.Entities
{
	internal class Resposta : BaseModel
	{
		[Key]
		public int RespostaID { get; set; }

		[MaxLength(255)]
		public string? RespostaQuiz { get; set; }

		public bool? Verdadeiro { get; set; }

		public Pergunta? pergunta { get; set; }

		public virtual NivelDificuldade? Nivel { get; set; }
	}
}
