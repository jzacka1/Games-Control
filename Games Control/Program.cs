using Card_Games.Characteristics;
using Card_Games.Games;
using Card_Games.Services.CardGames;
using System;
using System.Collections.Generic;

namespace Games_Control
{
	class Program
	{
		static void Main(string[] args)
		{
			//Create players
			Player player1 = new Player() { 
				Name = "James",
				Hand = new List<Card>(),
				IsPlaying = true
			};

			Player player2 = new Player()
			{
				Name = "Michael",
				Hand = new List<Card>(),
				IsPlaying = true
			};

			Player player3 = new Player()
			{
				Name = "Johnny",
				Hand = new List<Card>(),
				IsPlaying = true
			};

			//Put players into list
			List<Player> players = new List<Player>(){
				player1, player2, player3
			};

			//POKER GAME 1
			using (Poker poker = new Poker(players)){

				//PlayingCardsDeck.deck.ShuffleDeck();

				poker.playingCardsDeck.ShuffleDeck();

				foreach (var player in players){
					PlayingCards card = poker.playingCardsDeck.Draw();

					//Give Player a card
					player.Hand.Add(card);
				}

				//Return cards to deck
				foreach (var player in players)
				{
					foreach(PlayingCards card in player.Hand){
						poker.playingCardsDeck.Add(card);
					}
					
					player.Hand.Clear();
				}
			}

			//POKER GAME 2
			using (Poker poker = new Poker(players))
			{
				poker.playingCardsDeck.ShuffleDeck();

				foreach (var player in players)
				{
					PlayingCards card = poker.playingCardsDeck.Draw();

					//Give Player a card
					player.Hand.Add(card);
				}

				//Return cards to deck
				foreach (var player in players)
				{
					foreach (PlayingCards card in player.Hand)
					{
						poker.playingCardsDeck.Add(card);
					}

					player.Hand.Clear();
				}
			}
			//BlackJack Game 1
			using (BlackJack blackJack = new BlackJack(players))
			{
				//Return cards to deck
				foreach (var player in players)
				{
					foreach (PlayingCards card in player.Hand)
					{
						PlayingCardsDeck.deck.Add(card);
					}

					player.Hand.Clear();
				}
			}

			Console.WriteLine("All Games Played");
		}
	}
}
