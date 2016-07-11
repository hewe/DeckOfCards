using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckOfCards.Contracts;

namespace DeckOfCards.Types
{
    /// <summary>
    /// This class is the default representation of a deck.
    /// </summary>
    public abstract class Deck : IEnumerable<Card>, IDeck
    {
        protected IEnumerable<Card> Cards { get; set; }

        /// <summary>
        /// Initializes a deck with a given set of cards
        /// </summary>
        /// <param name="cards">Cards to initialize a standard deck.</param>
        public Deck(IEnumerable<Card> cards)
        {
            Cards = cards;
        }

        /// <summary>
        /// <see cref="IDeck.Sort"/>
        /// </summary>
        public abstract void Sort();


        /// <summary>
        /// Randomizes the placement of cards in a deck.
        /// </summary>
        public void Shuffle()
        {
            Card[] cardsArray = this.Cards.ToArray();

            Random random = new Random();
            for (int i = 0; i < cardsArray.Length -1 ; i++)
            {
                int j = random.Next(i + 1, cardsArray.Length);
                Card temp = cardsArray[j];
                cardsArray[j] = cardsArray[i];
                cardsArray[i] = temp;
            }
            this.Cards = cardsArray;
        }

        public IEnumerator<Card> GetEnumerator()
        {
            return this.Cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(" ", this.Cards);
        }
    }
}
