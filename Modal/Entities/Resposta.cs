
using System.ComponentModel.DataAnnotations;

namespace Jogo_Quiz.Modal.Entities
{
	public class Resposta : BaseModel
	{
		[Key]
		private int RespostaID { get; set; }

		[MaxLength(255)]
        private string? RespostaQuiz { get; set; }

        private bool? Verdadeiro { get; set; }

        private int PerguntaID { get; set; }
        private Pergunta? pergunta { get; set; }

        private NivelDificuldade? Nivel { get; set; }
    }
}
