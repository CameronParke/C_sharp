using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Assignments
    {
        public static void RandomArray()
        {
            Random number = new Random();
            int[] arr = new int[10];
            int min = 25;
            int max = 5;
            int sum = 0;
            for (int value = 0; value < arr.Length; value++)
            {
                arr[value] = number.Next(5, 26);
                if (arr[value] > max)
                {
                    max = arr[value];
                }
                else if (arr[value] < min)
                {
                    min = arr[value];
                }
                sum += arr[value];
            }
            Console.WriteLine("");
            Console.WriteLine($"The first number in the array is {arr[0]}");
            Console.WriteLine("");
            Console.WriteLine($"The second number in the array is {arr[1]}");
            Console.WriteLine("");
            Console.WriteLine($"The third number in the array is {arr[2]}");
            Console.WriteLine("");
            Console.WriteLine($"The fourth number in the array is {arr[3]}");
            Console.WriteLine("");
            Console.WriteLine($"The fifth number in the array is {arr[4]}");
            Console.WriteLine("");
            Console.WriteLine($"The sixth number in the array is {arr[5]}");
            Console.WriteLine("");
            Console.WriteLine($"The seventh number in the array is {arr[6]}");
            Console.WriteLine("");
            Console.WriteLine($"The eigth number in the array is {arr[7]}");
            Console.WriteLine("");
            Console.WriteLine($"The ninth number in the array is {arr[8]}");
            Console.WriteLine("");
            Console.WriteLine($"The tenth number in the array is {arr[9]}");
            Console.WriteLine("");
            Console.WriteLine($"The min value in the array is {min}");
            Console.WriteLine("");
            Console.WriteLine($"The max value in the array is {max}");
            Console.WriteLine("");
            Console.WriteLine($"The sum of the values in the array is {sum}");
            Console.WriteLine("");
        }

        public static string TossCoin()
        {
            Console.WriteLine("");
            Console.WriteLine("Tossing a Coin! Call it in the air!");
            Random toss = new Random();
            string landedOn = "";
            int tossResult = toss.Next(0, 2);
            if (tossResult == 0)
            {
                landedOn = "Heads";
            }
            else
            {
                landedOn = "Tails";
            }
            Console.WriteLine("");
            Console.WriteLine($"The coin landed on {landedOn}. Did you guess right?");
            Console.WriteLine("");
            return landedOn;
        }

        public static double TossMultipleCoins(int num)
        {
            Random toss = new Random();
            double heads = 0;
            double ratio = 0;
            for (int i = 0; i < num; i++)
            {
                if (TossCoin() == "Heads")
                {
                    heads++;
                }
            }
            ratio = heads / num;
            Console.WriteLine($"The ratio of heads tossed to total tosses is {ratio}");
            Console.WriteLine("");
            return ratio;
        }

        public static void Names()
        {
            List<string> nameList = new List<string>();
            List<string> newList = new List<string>();
            Random rand = new Random();
            nameList.Add("Todd");
            nameList.Add("Tiffany");
            nameList.Add("Charlie");
            nameList.Add("Geneva");
            nameList.Add("Sydney");

            for (int i = 0; i < nameList.Count; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"{nameList[i]} is at Index {i} in the original list.");
            }

            Console.WriteLine("");

            for (int i = 0; i < nameList.Count; i++)
            {
                if (nameList[i].Length < 5)
                {
                    nameList.RemoveAt(i);
                }
                newList.Add(nameList[i]);
                Console.WriteLine($"{newList[i]} is at Index {i} in the 'more than 5 characters' list");
                Console.WriteLine("");
            }
        }
        public static void Shuffled()
        {
            List<string> nameList = new List<string>();
            List<string> shuffledNames = new List<string>();
            Random rand = new Random();
            nameList.Add("Todd");
            nameList.Add("Tiffany");
            nameList.Add("Charlie");
            nameList.Add("Geneva");
            nameList.Add("Sydney");

        while(nameList.Count != 0)
            {
                var indexRandom = rand.Next(0, nameList.Count);
                shuffledNames.Add(nameList[indexRandom]);
                Console.WriteLine($"{nameList[indexRandom]} is here now in the shuffled list.");
                nameList.Remove(nameList[indexRandom]);
                Console.WriteLine("");
            }
        }
    }
}

