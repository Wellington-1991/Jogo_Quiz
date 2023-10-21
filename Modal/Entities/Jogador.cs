using System.ComponentModel.DataAnnotations;

namespace Jogo_Quiz.Modal.Entities
{
	public class Jogador : BaseModel 
	{
		[Key]
		private int JogadorID { get; set; }

		[MaxLength(200)]
		private string Nome { get; set; }
    }
}
