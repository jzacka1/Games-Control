using Card_Games.Characteristics;
using Card_Games.Services.CardGames;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Games.Games
{
	public class Poker : PlayingCardGames
	{
		public Poker(List<Player> players)
		{
			this.players = players;
		}

		~Poker(){

		}
	}
}
