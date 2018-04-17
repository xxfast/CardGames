using System;
namespace UnoCards
{
    public class UnoActionCard : UnoCard
    {
        private UnoAction action;

        public UnoActionCard(UnoColor c, UnoAction a): base(c){
            action = a;
        }

        public UnoAction Action {
            get {
                return action;
            }
        }

        public override string ToString()
        {
			String toReturn = null;
			switch (action)
			{
				case UnoAction.Skip:
					toReturn = "✕";
					break;
                case UnoAction.Reverse:
					toReturn = "⏎";
					break;
				case UnoAction.DrawTwo:
					toReturn = "+2";
					break;
				case UnoAction.Wild:
					toReturn = "⌀ wild";
					break;
                case UnoAction.WildDrawFour:
					toReturn = "⌀ wild +4";
					break;
				default:
					toReturn = "✳︎";
					break;
			}
			return toReturn;
        }
    }
}
