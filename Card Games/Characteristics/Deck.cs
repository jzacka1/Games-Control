using Card_Games.Services.CardGames;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Games.Characteristics
{
	public class Deck<T> where T: Card
	{
		public static List<T> deck;
	}
}
