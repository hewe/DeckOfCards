using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckOfCards.Types;
namespace DeckOfCards.Utilities
{
    public class Constants
    {
        #region Card Constants
        public static readonly Card AceOfClubs = new Card(CardFace.Ace, CardSuit.Clubs);
        public static readonly Card TwoOfClubs = new Card(CardFace.Two, CardSuit.Clubs);
        public static readonly Card ThreeOfClubs = new Card(CardFace.Three, CardSuit.Clubs);
        public static readonly Card FourOfClubs = new Card(CardFace.Four, CardSuit.Clubs);
        public static readonly Card FiveOfClubs = new Card(CardFace.Five, CardSuit.Clubs);
        public static readonly Card SixOfClubs = new Card(CardFace.Six, CardSuit.Clubs);
        public static readonly Card SevenOfClubs = new Card(CardFace.Seven, CardSuit.Clubs);
        public static readonly Card EightOfClubs = new Card(CardFace.Eight, CardSuit.Clubs);
        public static readonly Card NineOfClubs = new Card(CardFace.Nine, CardSuit.Clubs);
        public static readonly Card TenOfClubs = new Card(CardFace.Ten, CardSuit.Clubs);
        public static readonly Card JackOfClubs = new Card(CardFace.Jack, CardSuit.Clubs);
        public static readonly Card QueenOfClubs = new Card(CardFace.Queen, CardSuit.Clubs);
        public static readonly Card KingOfClubs = new Card(CardFace.King, CardSuit.Clubs);

        public static readonly Card AceOfDiamonds = new Card(CardFace.Ace, CardSuit.Diamonds);
        public static readonly Card TwoOfDiamonds = new Card(CardFace.Two, CardSuit.Diamonds);
        public static readonly Card ThreeOfDiamonds = new Card(CardFace.Three, CardSuit.Diamonds);
        public static readonly Card FourOfDiamonds = new Card(CardFace.Four, CardSuit.Diamonds);
        public static readonly Card FiveOfDiamonds = new Card(CardFace.Five, CardSuit.Diamonds);
        public static readonly Card SixOfDiamonds = new Card(CardFace.Six, CardSuit.Diamonds);
        public static readonly Card SevenOfDiamonds = new Card(CardFace.Seven, CardSuit.Diamonds);
        public static readonly Card EightOfDiamonds = new Card(CardFace.Eight, CardSuit.Diamonds);
        public static readonly Card NineOfDiamonds = new Card(CardFace.Nine, CardSuit.Diamonds);
        public static readonly Card TenOfDiamonds = new Card(CardFace.Ten, CardSuit.Diamonds);
        public static readonly Card JackOfDiamonds = new Card(CardFace.Jack, CardSuit.Diamonds);
        public static readonly Card QueenOfDiamonds = new Card(CardFace.Queen, CardSuit.Diamonds);
        public static readonly Card KingOfDiamonds = new Card(CardFace.King, CardSuit.Diamonds);

        public static readonly Card AceOfHearts = new Card(CardFace.Ace, CardSuit.Hearts);
        public static readonly Card TwoOfHearts = new Card(CardFace.Two, CardSuit.Hearts);
        public static readonly Card ThreeOfHearts = new Card(CardFace.Three, CardSuit.Hearts);
        public static readonly Card FourOfHearts = new Card(CardFace.Four, CardSuit.Hearts);
        public static readonly Card FiveOfHearts = new Card(CardFace.Five, CardSuit.Hearts);
        public static readonly Card SixOfHearts = new Card(CardFace.Six, CardSuit.Hearts);
        public static readonly Card SevenOfHearts = new Card(CardFace.Seven, CardSuit.Hearts);
        public static readonly Card EightOfHearts = new Card(CardFace.Eight, CardSuit.Hearts);
        public static readonly Card NineOfHearts = new Card(CardFace.Nine, CardSuit.Hearts);
        public static readonly Card TenOfHearts = new Card(CardFace.Ten, CardSuit.Hearts);
        public static readonly Card JackOfHearts = new Card(CardFace.Jack, CardSuit.Hearts);
        public static readonly Card QueenOfHearts = new Card(CardFace.Queen, CardSuit.Hearts);
        public static readonly Card KingOfHearts = new Card(CardFace.King, CardSuit.Hearts);

        public static readonly Card AceOfSpades = new Card(CardFace.Ace, CardSuit.Spades);
        public static readonly Card TwoOfSpades = new Card(CardFace.Two, CardSuit.Spades);
        public static readonly Card ThreeOfSpades = new Card(CardFace.Three, CardSuit.Spades);
        public static readonly Card FourOfSpades = new Card(CardFace.Four, CardSuit.Spades);
        public static readonly Card FiveOfSpades = new Card(CardFace.Five, CardSuit.Spades);
        public static readonly Card SixOfSpades = new Card(CardFace.Six, CardSuit.Spades);
        public static readonly Card SevenOfSpades = new Card(CardFace.Seven, CardSuit.Spades);
        public static readonly Card EightOfSpades = new Card(CardFace.Eight, CardSuit.Spades);
        public static readonly Card NineOfSpades = new Card(CardFace.Nine, CardSuit.Spades);
        public static readonly Card TenOfSpades = new Card(CardFace.Ten, CardSuit.Spades);
        public static readonly Card JackOfSpades = new Card(CardFace.Jack, CardSuit.Spades);
        public static readonly Card QueenOfSpades = new Card(CardFace.Queen, CardSuit.Spades);
        public static readonly Card KingOfSpades = new Card(CardFace.King, CardSuit.Spades);
        #endregion

        #region Deck Constants
        /// <summary>
        /// Standard deck of cards with order listed in <see cref="Constants.StandardOrderedDeckOfCards"/> definition.
        /// </summary>
        public static readonly IEnumerable<Card> StandardOrderedDeckOfCards = new Card[]
        {
            AceOfClubs,
            AceOfDiamonds,
            AceOfHearts,
            AceOfSpades,

            TwoOfClubs,
            TwoOfDiamonds,
            TwoOfHearts,
            TwoOfSpades,

            ThreeOfClubs,
            ThreeOfDiamonds,
            ThreeOfHearts,
            ThreeOfSpades,

            FourOfClubs,
            FourOfDiamonds,
            FourOfHearts,
            FourOfSpades,

            FiveOfClubs,
            FiveOfDiamonds,
            FiveOfHearts,
            FiveOfSpades,

            SixOfClubs,
            SixOfDiamonds,
            SixOfHearts,
            SixOfSpades,

            SevenOfClubs,
            SevenOfDiamonds,
            SevenOfHearts,
            SevenOfSpades,

            EightOfClubs,
            EightOfDiamonds,
            EightOfHearts,
            EightOfSpades,

            NineOfClubs,
            NineOfDiamonds,
            NineOfHearts,
            NineOfSpades,

            TenOfClubs,
            TenOfDiamonds,
            TenOfHearts,
            TenOfSpades,

            JackOfClubs,
            JackOfDiamonds,
            JackOfHearts,
            JackOfSpades,

            QueenOfClubs,
            QueenOfDiamonds,
            QueenOfHearts,
            QueenOfSpades,

            KingOfClubs,
            KingOfDiamonds,
            KingOfHearts,
            KingOfSpades,
        };
        #endregion
    }
}
