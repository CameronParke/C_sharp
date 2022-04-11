using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        
        public Wizard(string name) : base(name)
        {
            Name = name;
            health = 50;
            Intelligence = 25;
        }
        
        public override int Attack(Human target)
        {
            int damage = 5 * Intelligence; // expect 125, got 125
            target.HealthChange(-damage);
            Console.WriteLine($"{Name} attacked {target.Name}. {target.Name} was dealt {-damage} HP.");
            Console.WriteLine($"{Name} is healed by attacking others. {Name} receives an additional {damage} HP.");
            health += damage;
            return target.Health;
        }

        public int Heal(Human target)
        {
            int healing = 10 * Intelligence; // expect 250, got 250
            target.HealthChange(healing);
            Console.WriteLine($"{Name} used their powers to heal {target.Name}. {target.Name}'s health was restored by {healing} HP. {target.Name} says 'Thank You!' to {Name}.");
            return target.Health;
        }
    }
}