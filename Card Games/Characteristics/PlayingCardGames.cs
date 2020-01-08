using Card_Games.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Games.Characteristics
{
	public class PlayingCardGames : CardGames
	{
		public List<PlayingCards> playingCardsDeck;

		public PlayingCardGames(){
			playingCardsDeck = PlayingCardsDeck.createPlayingCardsDeck();
			//deck = new PlayingCardsDeck().createPlayingCardsDeck();
		}

		//public int DetermineCardScore(string value){
		//	switch(value.ToLower()){
		//		case "two":
		//			return 2;
		//			break;
		//		case "three":
		//			return 3;
		//			break;
		//		case "four":
		//			return 4;
		//			break;
		//		case "five":
		//			return 5;
		//			break;
		//		case "six":
		//			return 6;
		//			break;
		//		case "seven":
		//			return 7;
		//			break;
		//		case "eight":
		//			return 8;
		//			break;
		//		case "nine":
		//			return 9;
		//			break;
		//		case "ten":
		//			return 10;
		//			break;
		//		case "jack":
		//			return 10;
		//			break;
		//		case "queen":
		//			return 10;
		//			break;
		//		case "king":
		//			return 10;
		//			break;
		//		case "ace":
		//			return 10;
		//			break;
		//	}
				
		//}
	}
}
