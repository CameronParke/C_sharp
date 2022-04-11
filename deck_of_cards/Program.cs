using System;

namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Deck newDeck = new Deck();
            Player Hellmuth = new Player("Phil Hellmuth");

            Console.WriteLine("");
            Console.WriteLine("----The following is the ordered list of cards arranged by suit----");
            newDeck.printDeck();
            // newDeck.shuffle();
            // Console.WriteLine("");
            // Console.WriteLine("----The following is the shuffled deck----");
            // newDeck.printDeck();
            Console.WriteLine("");
            Console.WriteLine("----The following are the dealt cards----");
            Console.WriteLine("");
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            newDeck.Deal();
            Console.WriteLine("");
            Console.WriteLine("----The following is what remains in the deck after the above cards have been dealt:----");
            newDeck.printDeck();
            Console.WriteLine("");
            newDeck.Reset();
            Console.WriteLine("");
            Console.WriteLine("----The following is the original deck after it has undergone a Reset----");
            newDeck.printDeck();
            Hellmuth.Draw(newDeck);
            Hellmuth.Draw(newDeck);
            Hellmuth.Draw(newDeck);
            Console.WriteLine("");
            Hellmuth.printHand();
            Console.WriteLine("");
            Hellmuth.Discard(2);
            Hellmuth.Discard(1);
            Hellmuth.Discard(0);
            Hellmuth.printHand();
            // Hellmuth.Discard(0); Produces index out of range when there are no cards left in the hand to Discard 
            Console.WriteLine("");
        }
    }
}
