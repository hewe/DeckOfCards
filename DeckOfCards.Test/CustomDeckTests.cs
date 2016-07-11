using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using DeckOfCards.Types;
using DeckOfCards.Utilities;

namespace DeckOfCards.Test
{
    [TestFixture]
    public class CustomDeckTests
    {
        /// <summary>
        /// Test case data containing cards to test and cards to expect for validation
        /// </summary>
        public static IEnumerable<ITestCaseData> CustomDeckTestCaseData()
        {
            yield return new TestCaseData(
                new Card[]{ Constants.AceOfClubs }, 
                new Card[] { Constants.AceOfClubs }
            );

            yield return new TestCaseData(
                new Card[] { Constants.AceOfClubs, Constants.AceOfDiamonds },
                new Card[] { Constants.AceOfClubs, Constants.AceOfDiamonds});

            yield return new TestCaseData(
                new Card[] { Constants.AceOfClubs, Constants.AceOfClubs },
                new Card[] { Constants.AceOfClubs, Constants.AceOfClubs });

            yield return new TestCaseData(
                new Card[] { Constants.AceOfClubs, Constants.AceOfDiamonds, Constants.AceOfHearts, Constants.AceOfSpades },
                new Card[] { Constants.AceOfClubs, Constants.AceOfDiamonds, Constants.AceOfHearts, Constants.AceOfSpades });

            yield return new TestCaseData(
                new Card[] { Constants.AceOfSpades, Constants.AceOfHearts, Constants.AceOfDiamonds, Constants.AceOfClubs },
                new Card[] { Constants.AceOfClubs, Constants.AceOfDiamonds, Constants.AceOfHearts, Constants.AceOfSpades });

            yield return new TestCaseData(
                new Card[] { Constants.AceOfSpades, Constants.TwoOfSpades, Constants.ThreeOfHearts, Constants.ThreeOfDiamonds },
                new Card[] { Constants.TwoOfSpades, Constants.ThreeOfDiamonds, Constants.ThreeOfHearts, Constants.AceOfSpades });
        }

        [Test, TestCaseSource(nameof(CustomDeckTestCaseData))]
        public void CustomInitalizesAStandardOrderDeckOfCardsTest(IEnumerable<Card> unsortedCards, IEnumerable<Card>sortedCards)
        {
            Deck myDeck = new CustomDeck(unsortedCards);
            CollectionAssert.AreEquivalent(unsortedCards, myDeck);

            Deck mySortedDeck = new CustomDeck(sortedCards);
            CollectionAssert.AreEquivalent(sortedCards, mySortedDeck);
        }

        [Test, TestCaseSource(nameof(CustomDeckTestCaseData))]
        public void SortDoesNotAddOrRemoveCardsTest(IEnumerable<Card> unsortedCards, IEnumerable<Card> sortedCards)
        {
            Deck myDeck = new CustomDeck(unsortedCards);
            myDeck.Sort();
            CollectionAssert.AreEquivalent(sortedCards, myDeck);
        }

        [Test, TestCaseSource(nameof(CustomDeckTestCaseData))]
        public void SortDoesOrderCardsInTheDeckTest(IEnumerable<Card> unsortedCards, IEnumerable<Card> sortedCards)
        {
            Deck myDeck = new CustomDeck(unsortedCards);
            myDeck.Sort();
            CollectionAssert.AreEqual(sortedCards, myDeck);
        }
    }
}
