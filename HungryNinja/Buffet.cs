using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Nashville Fried Chicken Sandwich", 750, true, false),
                new Food("Chocolate Milk Shake", 775, false, true),
                new Food("Chili", 350, true, false),
                new Food("Double Cheeseburger", 865, false, false),
                new Food("Challah Bread French Toast", 1100, false, true),
                new Food("Lamb Vindaloo", 400, true, false),
                new Food("Tiramisu", 1300, false, true),
            };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
        
    }
}