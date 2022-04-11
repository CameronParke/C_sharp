using System;
using System.Collections.Generic;
using System.Linq;

namespace deck_of_cards
{
    public class Deck
    {
        public List<Card> cards;
        public Deck()
        {
            this.cards = new List<Card>();
            string[] suits = { "Spades", "Diamonds", "Clubs", "Hearts" };
            string[] names = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < names.Length; j++)
                {
                    cards.Add(new Card(names[j], suits[i], values[j]));
                }
            }
        }
        public void printDeck()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine("");
                card.print();
            }
        }

        public void shuffle()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                Random rand = new Random();
                int randvalue = rand.Next(0, cards.Count);
                Card temp = cards[i];
                cards[i] = cards[randvalue];
                cards[randvalue] = temp;
            }
        }

        public Card Deal()
        {
            Card dealtCard = this.cards[0];
            this.cards.RemoveAt(0);
            Console.WriteLine($"The {dealtCard.name} of {dealtCard.suit} has been dealt from the top.");
            return dealtCard;
        }

        // public Deck Reset() // This will print a deck that is reset, but when I print my deck outside of this method it will only print the cards left remaining after dealing, so it didn't actually reset the deck, it just printed a new deck called resetDeck that has no correlation to the newDeck I created in my Program.cs  newDeck in Program.cs remains unchanged
        // {
        //     Deck resetDeck = new Deck();
        //     Console.WriteLine("----The deck has been Reset----");
        //     Console.WriteLine("");
        //     Console.WriteLine("----The following is the original deck after having been Reset.----");
        //     resetDeck.printDeck();
        //     return resetDeck;
        // }
        public void Reset() // this works but needs to be revisited because there absolutely has to be a more concise and DRYer way to do this than repeating 
        {
            this.cards = new List<Card>();
            string[] suits = { "Spades", "Diamonds", "Clubs", "Hearts" };
            string[] names = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < names.Length; j++)
                {
                    cards.Add(new Card(names[j], suits[i], values[j]));
                }
            }
            Console.WriteLine("----The deck has been Reset----");
        }
    }
}
