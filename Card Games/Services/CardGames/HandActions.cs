using Card_Games.Characteristics;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Card_Games.Services.CardGames
{
	public static class HandActions
	{
		public static List<T> SortHandByDescending<T>(this List<T> hand) where T : Card
		{
			hand = (from card in hand
						orderby card.CardID descending
						select card).ToList();

			Console.WriteLine("Hand is Sorted");

			return hand;
		}
	}
}
