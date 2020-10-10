using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            PokerDeck deck = new PokerDeck();

            Console.ReadLine();
        }
    }

    //Create abstract base class
    public abstract class Deck
    {
        // allow others classes that inherit to use prop by using protect
        protected List<PlayingCard> fullDeck = new List<PlayingCard>();
        private List<PlayingCard> drawPile = new List<PlayingCard>();
        private List<PlayingCard> discardPile = new List<PlayingCard>();

        protected void CreateDeck()
        {
            fullDeck.Clear();
            for (int suit = 0; suit < 4; suit++)
            {
                for (int val = 0; val < 13; val++)
                {
                    fullDeck.Add(new PlayingCard { Suit = (CardSuit)suit, Value = (CardValue)card });
                }
            }

        }
        public virtual void ShuffleDeck()
        {
            //shuffle algo
            //var rand = new Random();
            //var randomList = imagesEasy.OrderBy(x => rand.Next().ToList());
            var rnd = new Random();
            drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();

        }
        public abstract List<PlayingCard> DealCard()
        {

        }
        public virtual PlayingCard DrawOneCard()
        {
            PlayingCard output = drawPile.Take(1).First();
            drawPile.Remove(output);
            return output;
        }

    }
    public class PokerDeck : Deck
    {
        public PokerDeck()
        {
            CreateDeck();
            ShuffleDeck();

        }
        public List<PlayingCard> DrawOneCard(List<PlayingCard> cardsToDiscard)
        {
            List<PlayingCard> output = new List<PlayingCard>();
            foreach (var item in cardsToDiscard)
            {
                output.Add(DrawOneCard());
                discardPile.Add(card);
            }
            return output;
        }
        public override List<PlayingCard> DealCard()
        {
            List<PlayingCard> output = new List<PlayingCard>();
            for (int i = 0; i < 5; i++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }
    }
    public class PlayingCard
    {
        public CardSuit Suit { get; set; }
        public CardValue Value { get; set; }
    }
    public enum CardValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }
    public enum CardSuit
    {
        Hearts,
        CLubs,
        Diamonds,
        Spades,
    }
}
