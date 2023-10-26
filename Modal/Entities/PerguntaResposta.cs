using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Quiz.Modal.Entities
{
	public class PerguntaResposta
	{
		[Key]
        public int PerguntaRespostaID { get; set; }

		//public int PerguntaID { get; set; }
        public virtual Pergunta? Pergunta { get; set; }

		//public int RespostaID { get; set; }
		public virtual Resposta? Resposta { get; set; }
	}
}
