using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja ninja = new Ninja();
            Buffet buffet = new Buffet();

            while(!ninja.IsFull)
            {
                ninja.Eat(buffet.Serve());
            }
            Console.WriteLine($"Warning! The ninja has eaten {ninja.NumCalories} calories and is totally full!");
            Console.WriteLine("");
        }
    }
}
