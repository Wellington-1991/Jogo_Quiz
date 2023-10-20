using Microsoft.EntityFrameworkCore;

namespace Jogo_Quiz.Modal.Entities
{
	public abstract class BaseModel
	{
		public DateTime? DataCriacao { get; set; }
		public DateTime? DataExclusao { get; set; }
		public DateTime? DataAlteracao { get; set; }
        public bool Excluido { get; set; }
    }
}
