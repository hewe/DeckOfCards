using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckOfCards.Utilities;

namespace DeckOfCards.Types
{
    /// <summary>
    /// This class represents a standard deck of cards.
    /// </summary>
    public class StandardDeck : Deck
    {
        /// <summary>
        /// Initializes a deck with a given set of cards
        /// </summary>
        /// <param name="cards">Cards to initialize a standard deck.</param>
        protected StandardDeck(IEnumerable<DeckOfCards.Types.Card> cards) : base(cards)
        { }

        /// <summary>
        /// Initializes a standard deck of cards.
        /// </summary>
        public StandardDeck() : this(Constants.StandardOrderedDeckOfCards)
        { }

        /// <summary>
        /// Sort the deck of cards in ascending order by face and suit value
        /// where the order of card is A♣, A♦, A♥, A♠, 2♣ ... K♠.
        /// </summary>
        public override void Sort()
        {
            List<DeckOfCards.Types.Card> cardList = this.Cards.ToList();
            cardList.Sort();
            Cards = cardList;
        }
    }
}
