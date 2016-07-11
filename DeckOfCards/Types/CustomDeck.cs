using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards.Types
{
    /// <summary>
    /// This class represents a custom deck of cards. 
    /// </summary>
    public class CustomDeck : StandardDeck
    {
        /// <summary>
        /// Initialize a custom deck of cards.
        /// </summary>
        /// <param name="cards">Cards to be placed into a custom deck</param>
        public CustomDeck(IEnumerable<DeckOfCards.Types.Card> cards)
            : base(cards)
        { }

        /// <summary>
        /// Sort the deck of cards in ascending order by face and suit value
        /// where the order of card is 2♣, 2♦, 2♥, 2♠, 3♣ ... A♠. The lowest
        /// card is 2♣ and highest card is A♠.
        /// </summary>
        public override void Sort()
        {
            base.Sort();
            List<DeckOfCards.Types.Card> sortedDeck = this.Cards.Where(c => c.Face != DeckOfCards.Types.CardFace.Ace).ToList();
            sortedDeck.AddRange(this.Cards.Where(c => c.Face == DeckOfCards.Types.CardFace.Ace));
            this.Cards = sortedDeck;
        }
    }
}
