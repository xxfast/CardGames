using System;
namespace CardsCore
{
    public abstract class Card
    {
        private bool facedUp = true;

        /// <summary>
        /// Gets a value indicating whether this <see cref="T:CardsCore.Card"/> faced up.
        /// </summary>
        /// <value><c>true</c> if faced up; otherwise, <c>false</c>.</value>
        public bool FacedUp 
        {
            get { return facedUp; }
        }

        /// <summary>
        /// Flip this instance.
        /// </summary>
        public virtual void Flip()
        {
            facedUp = !facedUp;
        } 
    }
}
