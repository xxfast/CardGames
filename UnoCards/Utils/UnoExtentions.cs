using System;
using System.Collections.Generic;

namespace UnoCards
{
    public static class UnoExtentions
    {
		private static Dictionary<UnoColor, ConsoleColor> ColorRegistry = new Dictionary<UnoColor, ConsoleColor>
        {
            { UnoColor.Red, ConsoleColor.Red },
            { UnoColor.Yellow, ConsoleColor.Yellow },
            { UnoColor.Green, ConsoleColor.Green },
			{ UnoColor.Blue, ConsoleColor.Blue },
            { UnoColor.Wild, ConsoleColor.Magenta }
        };

        public static void Print(this UnoCard value)
		{
            if(value is UnoActionCard){
                Print((UnoActionCard)value);
            }else{
                Console.ForegroundColor = ColorRegistry[value.Color];
                Console.WriteLine(value);
                Console.ResetColor();
            }
		}

        public static void Print(this UnoActionCard value)
        {
            if (value.Action == UnoAction.Wild || value.Action == UnoAction.WildDrawFour ){
                List<UnoColor> colors = new List<UnoColor>() { UnoColor.Red, UnoColor.Yellow, UnoColor.Green, UnoColor.Blue};
                string toPrint = value.ToString();
                int i = 0;
                foreach(char c in toPrint){
					Console.ForegroundColor = ColorRegistry[colors[i++]];
                    Console.Write(c);
                    if (i >= colors.Count) i = 0;
                }
                Console.Write("\n");
            }else{
			    Console.ForegroundColor = ColorRegistry[value.Color];
			    Console.WriteLine(value);
			    Console.ResetColor();
            }
		}
    }
}
