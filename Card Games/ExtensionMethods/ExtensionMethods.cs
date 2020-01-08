using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Games.ExtensionMethods
{
	public static class ExtensionMethods
	{
		//Using Fisher-Yates shuffle algorithm
		public static void RandomizeList<T>(this IList<T> list) where T : class {
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = new Random().Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}

		public static T RemoveFirstItem<T>(this IList<T> list) where T : class
		{
			T item = list[0];
			list.Remove(item);
			return item;
		}
	}
}
