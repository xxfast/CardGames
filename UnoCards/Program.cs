using System;

namespace UnoCards
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            UnoDeck deck = UnoDeck.Generate();
            deck.Shuffle();
            foreach(UnoCard uc in deck.Cards){
                uc.Print();
            }
        }
    }
}
