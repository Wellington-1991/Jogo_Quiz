﻿using System.ComponentModel.DataAnnotations;


namespace Jogo_Quiz.Modal.Entities
{
	internal class NivelDificuldade : BaseModel
	{
		[Key]
		public int NivelID { get; set; }
		public int Nivel { get; set; }
        public Pergunta? pergunta { get; set; }
    }
}
