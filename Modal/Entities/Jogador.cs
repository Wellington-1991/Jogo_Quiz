using System.ComponentModel.DataAnnotations;

namespace Jogo_Quiz.Modal.Entities
{
	internal class Jogador : BaseModel 
	{
		[Key]
		public int JogadorID { get; set; }

		[MaxLength(200)]
		public string Nome { get; set; }
    }
}
