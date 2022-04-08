using System;

namespace Human
{
    class Program
    {
        public static void Main(string[] args)
        {
            Human h1 = new Human("Hank Hill", 8, 9, 4, 100);
            Human h2 = new Human("Rusty Shackleford");
            Console.WriteLine(h1.Attack(h2));
        }
    }
}
