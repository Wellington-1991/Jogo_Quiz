using System.ComponentModel.DataAnnotations;
using System.Drawing.Text;

namespace Jogo_Quiz.Modal.Entities
{
	public class Jogada : BaseModel
	{
		[Key]
        public int JogadaID { get; set; }
		public int Ponto { get; set; }
		public Jogador Jogador { get; set; }
		public Pergunta Pergunta { get; set; } 
	}
}
