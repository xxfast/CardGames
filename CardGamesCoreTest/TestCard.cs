using NUnit.Framework;
using CardsCore;

namespace CardCoreTest.CardTest
{
	class GenericCard : Card
	{
		private int val;

		public GenericCard(int val)
		{
			this.val = val;
		}

		public int Value
		{
			get { return val; }
		}
	}

	[TestFixture()]
	public class TestCard
	{
        GenericCard c;

        [SetUp]
        public void init(){
            c = new GenericCard(0);
        }

		[Test()]
		public void TestConstructor()
        {
            int i = 1;
            string x = i+"";
            bool expect = true;
            bool actual = c.FacedUp;
            Assert.AreEqual(expect,actual);
		}

		[Test()]
		public void TestFlip(int x)
		{
			c.Flip();
            bool expect = false;
			bool actual = c.FacedUp;

			Assert.AreEqual(expect, actual);
		}
	}
}
