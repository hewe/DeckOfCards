using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckOfCards.Utilities;

namespace DeckOfCards.Types
{
    /// <summary>
    /// This class contains definition of a Card. A Card usually is comprised of 
    /// properties such as Face and Suit to determine its value. 
    /// </summary>
    public partial class Card : IComparable<Card>
    {
        /// <summary>
        /// Face of the card.
        /// </summary>
        public CardFace Face
        {
            get;
            private set;
        }

        /// <summary>
        /// Suit of the card.
        /// </summary>
        public CardSuit Suit
        {
            get;
            private set;
        }


        /// <summary>
        /// This initializes a new instance of Card class.
        /// </summary>
        /// <param name="face">Face of the card.</param>
        /// <param name="suit">Suit of the card.</param>
        public Card(CardFace face, CardSuit suit)
        {
            Face = face;
            Suit = suit;
        }

        /// <summary>
        /// Compares this card to other card first by card's face followed by suit value. 
        /// </summary>
        /// <param name="other">The other card.</param>
        /// <returns>1 if this card is larger than other card,  -1 if this card is smaller
       ///  than other card. 0 if both cards are same.</returns>
        public int CompareTo(Card other)
        {
            if (this.Face > other.Face)
                return 1;

            if(this.Face < other.Face)
                return -1;

            if (this.Suit > other.Suit)
                return 1;

            if (this.Suit < other.Suit)
                return -1;

            return 0;
        }


        public override string ToString()
        {
            string face = this.Face.GetDescription();
            string suit = this.Suit.GetDescription();
            return face + suit;
        }
    }
}
