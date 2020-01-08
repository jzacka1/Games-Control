using Card_Games.Characteristics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Games.Services.CardGames
{
	public static class PlayerActions
	{
		public static void EliminatePlayer(this Player player){
			player.IsPlaying = false;
		}

		public static void FoldHand(this Player player){

		}

		public static void DealHand(this IList<Player> player){
			
		}
	}
}
