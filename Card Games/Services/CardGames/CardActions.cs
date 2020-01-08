using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Games.Services.CardGames
{
	public abstract class CardActions
	{
		public virtual void Flip(){
			Console.WriteLine("Card is Flipped!");
		}

		public virtual void Discard(){
			Console.WriteLine("Card is Discarded!");
		}

		public virtual void PlaceOnTable()
		{
			Console.WriteLine("Card is placed on Table!");
		}

		public virtual void TakeFromPlayerHand(){
			Console.WriteLine("Card is taken from another hand");
		}
	}
}
