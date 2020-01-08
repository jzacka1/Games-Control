using Card_Games.Characteristics;
using Card_Games.Services.CardGames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card_Games.Games
{
	public class BlackJack : PlayingCardGames
	{
		public BlackJack(List<Player> players)
		{
			this.players = players;
			this.playingCardsDeck.ShuffleDeck();
			DrawFirstTwoCards();
		}

		private void DrawFirstTwoCards(){

			//Draw first two cards
			for(int i = 0; i < 2; i++){
				foreach (var player in players)
				{
					PlayingCards card = playingCardsDeck.Draw();
					player.Hand.Add(card);
				}
			}

			//Sort hand by 
			foreach(var player in players){
				player.Hand = player.Hand.SortHandByDescending();
			}

			//Determine Score
			foreach(var player in players){
				player.Score = GetHandScore(player.Hand);
				IsOverThan_21(player);
			}
		}

		public int GetHandScore(List<Card> hand)
		{
			int score = 0;
			foreach(PlayingCards card in hand){
				switch(card.Rank.ToLower()){
					case "king":
						score += 10;
						break;
					case "queen":
						score += 10;
						break;
					case "jack":
						score += 10;
						break;
					case "ten":
						score += 10;
						break;
					case "nine":
						score += 9;
						break;
					case "eight":
						score += 8;
						break;
					case "seven":
						score += 7;
						break;
					case "six":
						score += 6;
						break;
					case "five":
						score += 5;
						break;
					case "four":
						score += 4;
						break;
					case "three":
						score += 3;
						break;
					case "two":
						score += 2;
						break;
					case "ace":
						if (score + 11 >= 21)
							score += 11;
						else
							score += 1;
						break;
				}
			}

			return score;
		}

		private void IsOverThan_21(Player player){
			if (player.Score > 21)
				player.EliminatePlayer();
		}

		~BlackJack()
		{

		}
	}
}
