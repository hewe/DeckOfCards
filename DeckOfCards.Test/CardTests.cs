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
    public class CardTests
    {
        [Test]
        public void CardSuitFaceValueTest()
        {
            Card aceOfClubs = new Card(CardFace.Ace, CardSuit.Clubs);
            Card aceOfDiamonds = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card aceOfHearts = new Card(CardFace.Ace, CardSuit.Hearts);
            Card aceOfSpades = new Card(CardFace.Ace, CardSuit.Spades);

            Assert.That(aceOfClubs.Face, Is.EqualTo(CardFace.Ace));
            Assert.That(aceOfDiamonds.Face, Is.EqualTo(CardFace.Ace));
            Assert.That(aceOfHearts.Face, Is.EqualTo(CardFace.Ace));
            Assert.That(aceOfSpades.Face, Is.EqualTo(CardFace.Ace));

            Assert.That(aceOfClubs.Suit, Is.EqualTo(CardSuit.Clubs));
            Assert.That(aceOfDiamonds.Suit, Is.EqualTo(CardSuit.Diamonds));
            Assert.That(aceOfHearts.Suit, Is.EqualTo(CardSuit.Hearts));
            Assert.That(aceOfSpades.Suit, Is.EqualTo(CardSuit.Spades));
        }

        [Test]
        public void CardSuitRankTest()
        {
            Card aceOfClubs = new Card(CardFace.Ace, CardSuit.Clubs);
            Card aceOfDiamonds = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card aceOfHearts = new Card(CardFace.Ace, CardSuit.Hearts);
            Card aceOfSpades = new Card(CardFace.Ace, CardSuit.Spades);

            Assert.That(aceOfClubs, Is.LessThan(aceOfDiamonds));
            Assert.That(aceOfDiamonds, Is.GreaterThan(aceOfClubs));

            Assert.That(aceOfDiamonds, Is.LessThan(aceOfHearts));
            Assert.That(aceOfHearts, Is.GreaterThan(aceOfDiamonds));

            Assert.That(aceOfHearts, Is.LessThan(aceOfSpades));
            Assert.That(aceOfSpades, Is.GreaterThan(aceOfHearts));

            Assert.That(aceOfClubs, Is.EqualTo(aceOfClubs));
            Assert.That(aceOfDiamonds, Is.EqualTo(aceOfDiamonds));
            Assert.That(aceOfHearts, Is.EqualTo(aceOfHearts));
            Assert.That(aceOfSpades, Is.EqualTo(aceOfSpades));
        }

        [Test]
        public void CardFaceRankTest()
        {
            Card aceOfClubs = new Card(CardFace.Ace, CardSuit.Clubs);
            Card twoOfClubs = new Card(CardFace.Two, CardSuit.Clubs);

            Card fiveOfClubs = new Card(CardFace.Six, CardSuit.Clubs);
            Card eightOfClubs = new Card(CardFace.Eight, CardSuit.Clubs);

            Card queenOfClubs = new Card(CardFace.Queen, CardSuit.Clubs);
            Card kingOfClubs = new Card(CardFace.King, CardSuit.Clubs);

            Assert.That(aceOfClubs, Is.LessThan(twoOfClubs));
            Assert.That(twoOfClubs, Is.GreaterThan(aceOfClubs));

            Assert.That(queenOfClubs, Is.LessThan(kingOfClubs));
            Assert.That(kingOfClubs, Is.GreaterThan(queenOfClubs));

            Assert.That(fiveOfClubs, Is.LessThan(eightOfClubs));
            Assert.That(eightOfClubs, Is.GreaterThan(fiveOfClubs));

            Assert.That(aceOfClubs, Is.EqualTo(aceOfClubs));
            Assert.That(eightOfClubs, Is.EqualTo(eightOfClubs));
            Assert.That(kingOfClubs, Is.EqualTo(kingOfClubs));
        }

        [Test]
        public void CardMixedFaceSuitRankTest()
        {
            Card aceOfClubs = new Card(CardFace.Ace, CardSuit.Clubs);
            Card twoOfSpades = new Card(CardFace.Two, CardSuit.Spades);

            Card fiveOfDiamonds = new Card(CardFace.Five, CardSuit.Clubs);
            Card eightOfHearts = new Card(CardFace.Eight, CardSuit.Hearts);

            Card queenOfSpades = new Card(CardFace.Queen, CardSuit.Spades);
            Card kingOfClubs = new Card(CardFace.King, CardSuit.Clubs);

            Assert.That(aceOfClubs, Is.LessThan(twoOfSpades));
            Assert.That(twoOfSpades, Is.GreaterThan(aceOfClubs));

            Assert.That(fiveOfDiamonds, Is.LessThan(eightOfHearts));
            Assert.That(eightOfHearts, Is.GreaterThan(fiveOfDiamonds));

            Assert.That(queenOfSpades, Is.LessThan(kingOfClubs));
            Assert.That(kingOfClubs, Is.GreaterThan(queenOfSpades));
        }

        [Test]
        public void CardToStringTest()
        {
            Card card = Constants.AceOfClubs;
            Assert.AreEqual("A♣", card.ToString());
        }
    }
}