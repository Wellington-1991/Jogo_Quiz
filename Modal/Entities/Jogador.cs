using System.ComponentModel.DataAnnotations;

namespace Jogo_Quiz.Modal.Entities
{
	public class Jogador : BaseModel 
	{
		[Key]
        public int JogadorID { get; set; }

		[MaxLength(200)]
		public string Nome { get; set; }

		public ICollection<Jogada> jogadas { get; set; }
    }
}
