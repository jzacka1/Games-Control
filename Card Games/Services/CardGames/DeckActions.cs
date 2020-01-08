using Card_Games.Characteristics;
using Card_Games.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Text;


namespace Card_Games.Services.CardGames
{
	public static class DeckActions
	{
		public static void ShuffleDeck<T>(this IList<T> deck) where T : Card
		{
			string cardType = deck.GetType().GenericTypeArguments[0].Name;
			deck.RandomizeList();
			Console.WriteLine("{0} Deck is shuffled", cardType);
		}

		public static T Draw<T>(this IList<T> deck) where T : Card
		{
			T card = deck.RemoveFirstItem();
			Console.WriteLine("Card is drawn");
			return card;
		}
	}
}
