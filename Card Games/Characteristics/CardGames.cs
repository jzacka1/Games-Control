using Card_Games.Characteristics;
using Card_Games.Services.CardGames;
using System;
using System.Collections.Generic;

namespace Card_Games
{
	public class CardGames: IDisposable
	{
		public List<Player> players;

		public CardGames(){
			//deck = new List<Card>();
			players = new List<Player>();	
		}

		public static void EliminatePlayer(){
			
		}

		public void Dispose()
		{
			//Dispose(true);
			//// tell the GC not to finalize
			//GC.SuppressFinalize(this);
			GC.Collect();
			Console.WriteLine("Garbage Collection Activated");
		}

	}
}
