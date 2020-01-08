using Card_Games.Services.CardGames;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Games.Characteristics
{
	public class Card : CardActions
	{
		public int CardID { get; set; }
		public int IllustrationID { get; set; }
		public byte[] illustration { get; set; } 
	}
}
