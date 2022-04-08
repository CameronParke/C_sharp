using System;

namespace HungryNinja
{
    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string name, int cals, bool spicy, bool sweet)
        {
            Name = name;
            Calories = cals;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
}