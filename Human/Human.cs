using System;

namespace Human
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        public int Health
        {
            get { return health; }
        }

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
        public int Attack(Human target)
        {
            int damage = 5 * Strength;
            target.health -= damage;
            Console.WriteLine($"{Name} blindsided {target.Name}. {target.Name} was dealt {damage} damage. {target.Name}'s health is now {target.health} HP I tell you hwat.");
            return target.health;
        }
    }
}