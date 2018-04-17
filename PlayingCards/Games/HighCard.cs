using System;
using System.Collections.Generic;

namespace PlayingCards
{
    public class HighCardPlayer {
        private StackedHand hand = new StackedHand();
        private int score = 0;
        public StackedHand Hand { get {return hand;} } 
        public int Score { get {return score;} set { score = value; } } 
    }

    public class HighCard
    {
        private HighCardPlayer player1 = new HighCardPlayer();
		private HighCardPlayer player2 = new HighCardPlayer();
        private PlayingCardsDeck deck = PlayingCardsDeck.Generate();
        private int round = 1;

		public HighCardPlayer Player1 
        {
            get {return player1;}
        }

		public HighCardPlayer Player2
		{
			get { return player2; }
		}

		public void Start(){
            Console.WriteLine("Let the game begin!");
            deck.Shuffle();
            int divition = deck.Cards.Count / 2;
            for (int i = 0; i < divition; i++){
                player1.Hand.Add(deck.Draw());
				player2.Hand.Add(deck.Draw());
            }
        }

        public bool NextRound(){
            Console.WriteLine("Round {0}", round++);
            PlayingCard p1 = player1.Hand.Draw();
			PlayingCard p2 = player2.Hand.Draw();

            Console.WriteLine("Draw = p1- {0}  p2- {1}", p1, p2);
            if(p1 > p2)
			{
				Console.WriteLine("Player 1 scored!");
                player1.Score++;
            }
            else if (p1 < p2)
			{
				Console.WriteLine("Player 2 scored!");
				player2.Score++;
            }
            Console.WriteLine("Scores = p1- {0}  p2- {1}", player1.Score, player2.Score);
            return player1.Hand.Cards.Count > 0;
        }

        public void Finish()
        {
            if(player1.Score == player2.Score){
                Console.WriteLine("Draw!");
            }else{
                Console.WriteLine("Player {0} won!", (player1.Score > player2.Score) ? "1" : "2");
            }

		}
    }
}
