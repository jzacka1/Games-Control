using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Card_Games.Cards
{
	class YugiohMonsterCard : YugiohCard
	{
		[Display(Name = "Monster Type")]
		string MonsterType { get; set; }
		[Display(Name = "Monster Tribe")]
		string MonsterTribe { get; set; }
		string Attribute { get; set; }
		int Attack { get; set; }
		int Defense { get; set; }
		int Level { get; set; }
	}
}
