using System;
namespace UnoCards
{
    public class UnoRankCard : UnoCard , IComparable<UnoRankCard>
    {
		private UnoRank rank;

        public UnoRankCard(UnoColor c, UnoRank r) : base(c)
        {
            rank = r;
        }

        public override string ToString()
        {
            return rank.ToString();
        }

		public int CompareTo(UnoRankCard other)
		{
			if (other == null)
				return 1;
			return rank.CompareTo(other.rank);
		}

		public static bool operator <(UnoRankCard lhs, UnoRankCard rhs)
		{
			return lhs.CompareTo(rhs) < 0;
		}

		public static bool operator >(UnoRankCard lhs, UnoRankCard rhs)
		{
			return lhs.CompareTo(rhs) > 0;
		}

    }
}
