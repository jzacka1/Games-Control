using Card_Games.Services.CardGames;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Games.Characteristics
{
	public class PlayingCards : Card
	{
		//public int PlayingCardID { get; set; } 
		public string Suit { get; set; }
		public string Rank { get; set; }
		public string Color { get; set; }
	}
}
