using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Player
    {
        public string name;
        public List<Card> hand;

        public Player(string Name)
        {
            this.name = Name;
            this.hand = new List<Card>();
        }

        public Card Draw(Deck deck)
        {
            Console.WriteLine("");
            Console.WriteLine($"{this.name} is drawing a card:");
            var cardDrawn = deck.Deal();
            this.hand.Add(cardDrawn);
            return cardDrawn;
        }

        public void printHand()
        {
            Console.WriteLine($"{this.name} has the following hand:");
            foreach (var card in this.hand)
            {
                Console.WriteLine("");
                card.print();
            }
        }

        public Card Discard(int randvalue)
        {
            if (this.hand[randvalue] != null)
            {
                Card discarded = this.hand[randvalue];
                this.hand.Remove(discarded);
                return discarded;
            }
            return null;
        }
    }
}