using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        public bool IsFull
        {
            get { return calorieIntake > 1200; }
        }
        public bool Eat(Food item)
        {
            if(!IsFull)
            { 
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"The ninja is having {item.Name}.");
                Console.WriteLine($"True or False: {item.Name} is spicy. The answer is {item.IsSpicy}.");
                Console.WriteLine($"True or False: {item.Name} is sweet. The answer is {item.IsSweet}.");
            }
            else
            {
                Console.WriteLine("The ninja is too full to eat anymore!");
            }
            return IsFull;
        }
    }
}