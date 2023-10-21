
using System.ComponentModel.DataAnnotations;

namespace Jogo_Quiz.Modal.Entities
{
	public class Pergunta : BaseModel
	{
		[Key]
		private int PerguntaID { get; set; }

		[MaxLength(255)]
        private string? PerguntaQuiz { get; set; }

        private ICollection<Resposta>? respostas { get; set; }

        private ICollection<NivelDificuldade>? nivelDificuldade { get; set; }
	}
}
