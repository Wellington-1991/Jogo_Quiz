
using System.ComponentModel.DataAnnotations;

namespace Jogo_Quiz.Modal.Entities
{
internal class Pergunta : BaseModel
	{
		[Key]
		public int PerguntaID { get; set; }

		[MaxLength(255)]
		public string? PerguntaQuiz { get; set; }

		public ICollection<Resposta>? respostas { get; set; }

		public ICollection<NivelDificuldade>? nivelDificuldade { get; set; }
	}
}
