using System;
namespace CardsCore
{
    public abstract class Card
    {
        private bool facedUp = true;

        public bool FacedUp 
        {
            get { return facedUp; }
        }

        public virtual void Flip()
        {
            facedUp = !facedUp;
        } 
    }
}
