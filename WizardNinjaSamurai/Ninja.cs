using System;

namespace WizardNinjaSamurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Name = name;
            Dexterity = 175;
        }
    
        public override int Attack(Human target)
        {
            int damage = 5 * Dexterity; // expect 875
            Random rand = new Random();
            int moreDamage = rand.Next(0,5); // 0, 1, 2, 3, 4
            if(moreDamage < 1){ // with 5 numbers there is a 20% chance the random number is 0
                damage += 10; // if the random number is 0 add an additional 10 damage
            }
            target.HealthChange(-damage); // expect 875 or 885 if random number is 0
            Console.WriteLine($"{Name} attacked {target.Name}. {target.Name} was dealt {-damage} damage.");
            return target.Health;
        }

        public int Steal(Human target)
        {
            int damage = 5;
            target.HealthChange(-damage);
            this.health += damage;
            Console.WriteLine($"{Name} is up to no good. They stole {damage} HP from {target.Name}.");
            return target.Health;
        }
    }
}