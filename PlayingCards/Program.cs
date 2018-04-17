using System;

namespace PlayingCards
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            HighCard hc = new HighCard();
            hc.Start();
            while (hc.NextRound()) {}
            hc.Finish();
        }
    }
}
