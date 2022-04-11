using System;

namespace WizardNinjaSamurai
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;
        public int Health {get {return health;}}

        public Human (string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human (string name, int strength, int intelligence, int dexterity, int hp)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = hp; 
        }
        public virtual int Attack(Human target)
        {
            int damage = 3 * Strength;
            target.health -= damage;
            Console.WriteLine($"{Name} attacked {target.Name}. {target.Name} was dealt {damage} damage.");
            return target.health;
        }

        public void showStats()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Strength: {this.Strength}");
            Console.WriteLine($"Intelligence : {this.Intelligence}");
            Console.WriteLine($"Dexterity: {this.Dexterity}");
            Console.WriteLine($"HP: {this.health}");
        }
        public void HealthChange(int amount)
        {
            this.health += amount;
        }

        public void SetHealth(int amount)
        {
            this.health = amount;
        }
    }
}