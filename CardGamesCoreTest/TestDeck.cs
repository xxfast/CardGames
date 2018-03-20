using NUnit.Framework;
using CardsCore;
using System;

namespace CardCoreTest.DeckTest
{
    class GenericCard : Card {
        private int val;

        public GenericCard(int val){
            this.val = val;
        }

        public int Value{
            get { return val;  }
        }
    }

    class GenericDeck : Deck<GenericCard>
    {
        protected override void Generate()
        {
            for (int i = 0; i < 10; i++){
                Cards.Push(new GenericCard(i));
            }
        }
    }

    [TestFixture()]
    public class TestDeck
    {
        GenericDeck deck = new GenericDeck();

        [SetUp()]
        public void init(){
            
        }

        [Test()]
        public void TestCase()
        {
        }

    }
}
