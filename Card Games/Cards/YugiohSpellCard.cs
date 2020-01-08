using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Card_Games.Cards
{
	class YugiohSpellTrapCard : YugiohCard
	{
		[Display(Name ="Card Type")]
		string CardType { get; set; }
		[Display(Name = "Effect Indicator")]
		string EffectIndicator { get; set; }
	}
}
