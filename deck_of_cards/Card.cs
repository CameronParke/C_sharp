using System;

namespace deck_of_cards
{
    public class Card 
    {
        public string name; 
        public string suit; 
        public int val; 

        public Card(string Name, string suitType, int value)
        {
            this.name = Name;
            this.suit = suitType; 
            this.val = value; 
        }
        public void print()
        {
            Console.WriteLine($"{name} of {suit}, value: {val}");
        }
    }
}