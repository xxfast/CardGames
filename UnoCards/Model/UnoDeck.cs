using System;
using CardsCore;

namespace UnoCards
{
    public class UnoDeck : Deck<UnoCard>
    {
		public static UnoDeck Generate()
		{
			UnoDeck toReturn = new UnoDeck();
            Array colors = Enum.GetValues(typeof(UnoColor));
            foreach (UnoColor c in colors)
			{
                if (c == UnoColor.Wild) continue;
                Array ranks = Enum.GetValues(typeof(UnoRank));
                foreach (UnoRank r in ranks)
				{
                    toReturn.Cards.Push(new UnoRankCard(c, r));
				}
                Array actions = Enum.GetValues(typeof(UnoAction));
				foreach (UnoAction a in actions)
				{
                    if(a == UnoAction.Wild || a == UnoAction.WildDrawFour){
                        toReturn.Cards.Push(new UnoActionCard(UnoColor.Wild, a));
                    }else{
                        toReturn.Cards.Push(new UnoActionCard(c, a));
                    }
				}
			}
			return toReturn;
		}
    }
}
