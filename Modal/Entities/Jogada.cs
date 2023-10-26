using System.ComponentModel.DataAnnotations;
using System.Drawing.Text;

namespace Jogo_Quiz.Modal.Entities
{
	public class Jogada : BaseModel
	{
		[Key]
        public int JogadaID { get; set; }
		public int Ponto { get; set; }

		public int JogadorID { get; set; }
		public virtual Jogador? Jogador { get; set; }
	
		public int NivelID { get; set; }
        public virtual NivelDificuldade? nivel { get; set; }
	}
}
