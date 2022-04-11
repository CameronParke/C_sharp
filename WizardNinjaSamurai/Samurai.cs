using System;

namespace WizardNinjaSamurai
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            Name = name;
            health = 200;
        }

        public override int Attack(Human target) 
        {
            base.Attack(target); // expect 9 damage, got 9 damage
            if(target.Health < 50){ 
                target.SetHealth(0);
                Console.WriteLine($"{Name} delivered a Special Move and just KO'd {target.Name}. {target.Name} is reduced to {target.Health} HP.");
            }
            return target.Health;
        }

        public int Meditate()
        {
            this.health = 200;
            Console.WriteLine($"{Name} meditated and found Inner Peace. {Name} is restored to full health, {health} HP.");
            return this.health;
        }
    }
}