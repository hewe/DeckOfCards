using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DeckOfCards.Types;
using DeckOfCards.Utilities;

namespace DeckOfCards.Test
{
    [TestFixture]
    public class StandardDeckTests
    {
        [Test]
        public void StandardDeckInitalizesAStandardOrderDeckOfCards()
        {
            Deck myDeck = new StandardDeck();
            CollectionAssert.AreEquivalent(Constants.StandardOrderedDeckOfCards, myDeck);
        }

        [Test]
        public void SortDoesNotAddOrRemoveCardsTest()
        {
            Deck myDeck = new StandardDeck();
            myDeck.Shuffle();
            myDeck.Sort();
            CollectionAssert.AreEquivalent(Constants.StandardOrderedDeckOfCards, myDeck);
        }

        [Test]
        public void SortOrdersCardsInTheDeckTest()
        {
            Deck myDeck = new StandardDeck();
            myDeck.Shuffle();
            myDeck.Sort();
            Assert.IsTrue(Enumerable.SequenceEqual(Constants.StandardOrderedDeckOfCards, myDeck));
        }
    }
}
