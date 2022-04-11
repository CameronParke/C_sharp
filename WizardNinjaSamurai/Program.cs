using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard w1 = new Wizard("Wizard");
            Ninja n1 = new Ninja("Ninja");
            Samurai s1 = new Samurai("Samurai");
            Console.WriteLine("");
            w1.showStats();
            Console.WriteLine("");
            n1.showStats();
            Console.WriteLine("");
            s1.showStats();
            Console.WriteLine("");
            n1.Attack(s1);
            Console.WriteLine("");
            s1.showStats();
            Console.WriteLine("");
            s1.Meditate();
            Console.WriteLine("");
            s1.showStats();
            Console.WriteLine("");        
            s1.Attack(w1);
            Console.WriteLine("");
            w1.showStats();
            Console.WriteLine("");
            w1.Attack(n1);
            Console.WriteLine("");
            w1.showStats();
            Console.WriteLine("");
            n1.showStats();
            Console.WriteLine("");
            w1.Heal(n1);
            Console.WriteLine("");
            n1.showStats();
            Console.WriteLine("");
            n1.Steal(w1);
            Console.WriteLine("");
            w1.showStats();
            Console.WriteLine("");
            n1.showStats();
            Console.WriteLine("");
        }
    }
}
