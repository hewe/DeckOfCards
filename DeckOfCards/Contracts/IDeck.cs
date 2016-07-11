using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards.Contracts
{
    public interface IDeck
    {
        /// <summary>
        /// Sorts a deck of cards.
        /// </summary>
        void Sort();

        /// <summary>
        /// Shuffles a deck of cards.
        /// </summary>
        void Shuffle();
    }
}
