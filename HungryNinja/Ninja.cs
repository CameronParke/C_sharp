using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Ninja
    {
        private int calorieIntake;
        public int NumCalories
        {
            get { return calorieIntake; }
        }
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
                Console.WriteLine("");
                Console.WriteLine($"The ninja is having {item.Name}. It has {item.Calories} calories.");
                Console.WriteLine("");
                Console.WriteLine($"True or False: {item.Name} is spicy. The answer is {item.IsSpicy}.");
                Console.WriteLine("");
                Console.WriteLine($"True or False: {item.Name} is sweet. The answer is {item.IsSweet}.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("The ninja is too full to eat anymore!");
            }
            return IsFull;
        }
    }
}