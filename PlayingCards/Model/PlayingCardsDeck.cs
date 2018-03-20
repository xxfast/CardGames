using System;
using CardsCore;
namespace PlayingCards
{
    public class PlayingCardsDeck : Deck<PlayingCard>
    {
        public static PlayingCardsDeck Generate()
        {
            PlayingCardsDeck toReturn = new PlayingCardsDeck();
            Array suits = Enum.GetValues(typeof(Suit));
            foreach(Suit s in suits){
                for (int i = 0; i < 14 ; i++ ){
                    Rank r = (Rank) i;
                    toReturn.Cards.Push(new PlayingCard(s, r));
                }
            }
            return toReturn;
        }
    }

}
