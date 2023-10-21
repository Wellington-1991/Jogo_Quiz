using System.ComponentModel.DataAnnotations;
using System.Drawing.Text;

namespace Jogo_Quiz.Modal.Entities
{
	public class Jogada : BaseModel
	{
		[Key]
        private int JogadaID { get; set; }
		private string? Ponto { get; set; }
		private Jogador Jogador { get; set; }
		private Pergunta Pergunta { get; set; } 
	}
}
