using System;
using CardsCore;

using Color = System.ConsoleColor;

namespace UnoCards
{
    public class UnoCard : Card
    {
        private UnoColor color;

        public UnoCard(UnoColor c)
        {
            color = c;
        }

        public UnoColor Color {
            get {
                return color;
            }
        }
    }
}
