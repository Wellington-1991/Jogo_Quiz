using System.ComponentModel.DataAnnotations;


namespace Jogo_Quiz.Modal.Entities
{
	internal class Jogada : BaseModel
	{
		[Key]
		public int JogadaID { get; set; }
		public string? Ponto { get; set; }

		public virtual Jogador Jogador { get; set; }
		public virtual Pergunta Pergunta { get; set; } 
	}
}
