using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Games.Characteristics
{
	public class Player
	{
		public string Name { get; set; }
		public List<Card> Hand { get; set; }
		public int Score { get; set; }
		public bool IsPlaying { get; set; }
	}
}
