using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FakeItEasy;
using DeckOfCards.Types;
using DeckOfCards.Utilities;

namespace DeckOfCards.Test
{
    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void ShuffleDoesNotAddOrRemoveCardsTest()
        {
            Deck myDeck = new StandardDeck();
            myDeck.Shuffle();
            CollectionAssert.AreEquivalent(Constants.StandardOrderedDeckOfCards, myDeck);
        }

        [Test]
        public void ShuffleRandomizesOrderOfCardsInTheDeckTest()
        {
            Deck myDeck = new StandardDeck();
            myDeck.Shuffle();
            CollectionAssert.AreNotEqual(Constants.StandardOrderedDeckOfCards, myDeck);
        }

        [Test]
        public void GetEnumeratorTest()
        {
            IEnumerable<Card> fake = A.Fake<IEnumerable<Card>>();
            Deck myDeck = new CustomDeck(fake);
            myDeck.GetEnumerator();
            A.CallTo(() => fake.GetEnumerator()).MustHaveHappened();
        }

        [Test]
        public void DeckToStringTest()
        {
            IEnumerable<Card> myCards = new Card[]
            {
                Constants.AceOfClubs,
                Constants.JackOfClubs,
                Constants.KingOfHearts
            };

            Deck myDeck = new CustomDeck(myCards);
            Assert.AreEqual("A♣ J♣ K♥", myDeck.ToString());
        }
    }
}
