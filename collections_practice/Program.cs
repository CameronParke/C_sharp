using System;
using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            int[] intArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            string[] stringArray = { "Tim", "Martin", "Nikki", "Sara" };

            bool[] boolArray = { true, false, true, false, true, false, true, false, true, false };

            List<string> flavors = new List<string>();

            flavors.Add("Boston Cream Pie");
            flavors.Add("Strawberry Buttermilk");
            flavors.Add("Honey Vanilla Bean");
            flavors.Add("Milkiest Chocolate");
            flavors.Add("Brown Sugar Apple");
            flavors.Add("Cookies In Cream");
            flavors.Add("Brown Butter Almond Brittle");
            flavors.Add("Coffee & Homemade Oreo");
            flavors.Add("Thai Iced Tea");
            flavors.Add("Rocky Road");

            Console.WriteLine("The list of ice cream flavors has " + flavors.Count + " flavors in it.");
            Console.WriteLine("");

            Console.WriteLine("The third flavor in the list is " + flavors[2] + ".");
            Console.WriteLine("");

            flavors.RemoveAt(2);

            Console.WriteLine("The list of ice cream flavors now has " + flavors.Count + " flavors in it.");
            Console.WriteLine("");

            Dictionary<string, string> flavorChoice = new Dictionary<string, string>();
            flavorChoice.Add("Tim", "Strawberry Buttermilk");
            flavorChoice.Add("Martin", "Brown Sugar Apple");
            flavorChoice.Add("Nikki", "Boston Cream Pie");
            flavorChoice.Add("Sara", "Milkiest Chocolate");
            foreach (var choice in flavorChoice)
            {
                Console.WriteLine(choice.Key + " has chosen " + choice.Value + ". Excellent choice, " + choice.Key + "!");
                Console.WriteLine("");
            }
        }
    }
}
