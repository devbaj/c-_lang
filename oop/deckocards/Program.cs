using System;
using System.Collections.Generic;

namespace deckocards
{
    class Card
    {
        public string Suit;
        public string StringVal;
        public int Val;
        public Card(string suit, string stringVal, int val)
        {
            Suit = suit;
            StringVal = stringVal;
            Val = val;
        }
    }
    class Deck
    {
        public List<Card> cards;
        public Deck() {
            cards = new List<Card>();
            MakeDeck(cards);
        }
        public void MakeDeck(List<Card> newDeck)
        {
            string[] suits = {"Hearts", "Diamond", "Spades", "Clubs"};
            string[] valStrings = {"Ace", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
            int[] vals = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
            
            foreach (string i in suits)
            {
                for (int j = 0; j < vals.Length; j++)
                {
                    newDeck.Add(new Card(i, valStrings[j], vals[j]));
                }
            }
        }
        public Card Deal()
        {
            Card draw = cards[0];
            cards.RemoveAt(0);
            return draw;
        }
        public void Reset()
        {
            MakeDeck(cards);
        }
        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = rand.Next(0, i+1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }
    }
    class Player
    {
        public string Name;
        public List<Card> Hand;
        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }
        public Card Draw(Deck deck)
        {
            Card draw = deck.Deal();
            Hand.Add(draw);
            return draw;
        }
        public Card Discard(int idx)
        {
            if (idx < Hand.Count-1 || idx < 0) { return null; }
            else {
                Card discarded = Hand[idx];
                Hand.RemoveAt(idx);
                return discarded;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Player chika = new Player("Fujiwara Chika");
            System.Console.WriteLine($"Player name is {chika.Name}");
            deck.Shuffle();
            chika.Draw(deck);
            chika.Draw(deck);
            foreach (Card card in chika.Hand)
            {
                System.Console.WriteLine($"{card.StringVal} of {card.Suit}");
            }
        }
    }
}
