using System;
using System.Collections.Generic;

namespace PlayingCards
{
    public class BlackJack
    {
        List<Hand> players = new List<Hand>();
        PlayingCardsDeck deck = new PlayingCardsDeck();

        public BlackJack()
        {
        }

        public void Start(){
            deck.Shuffle();
            foreach(PlayingCard c in deck.Cards){
                Console.WriteLine(c);
            }
        }
    }
}
