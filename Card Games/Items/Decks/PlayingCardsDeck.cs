using Card_Games.Characteristics;
using Card_Games.Services.CardGames;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Games.Games
{
	public class PlayingCardsDeck: Deck<PlayingCards>
	{
		private enum suits{ 
			Spades,
			Hearts,
			Clubs,
			Diamonds
		}

		private enum ranks{
			Ace = 'A',
			Two = 2,
			Three = 3,
			Four = 4,
			Five = 5,
			Six = 6,
			Seven = 7,
			Eight = 8,
			Nine = 9,
			Ten = 10,
			Jack = 'J',
			Queen = 'Q',
			King = 'K',
		}

		//public static List<PlayingCards> deck = new List<PlayingCards>();
		
		public static List<PlayingCards> createPlayingCardsDeck(){

			deck = new List<PlayingCards>();

			int num = 1;

			foreach (var suit in Enum.GetNames(typeof(suits)))
			{
				foreach (var rank in Enum.GetValues(typeof(ranks)))
				{
					string _rank = rank.ToString();

					PlayingCards card = new PlayingCards();

					switch (suit)
					{
						case "Spades":
							card.Suit = suit;
							card.Color = "Black";
							break;
						case "Hearts":
							card.Suit = suit;
							card.Color = "Red";
							break;
						case "Clubs":
							card.Suit = suit;
							card.Color = "Black";
							break;
						case "Diamonds":
							card.Suit = suit;
							card.Color = "Red";
							break;
					}

					card.Rank = _rank;
					card.CardID = num++;
					deck.Add(card);
				}
			}

			return deck;
		}

		public PlayingCardsDeck(){
			createPlayingCardsDeck();
		}
		
	}
}
