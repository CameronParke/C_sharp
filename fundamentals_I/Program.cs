using System;

namespace fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a loop that prints all values from 1-255: for loop version
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            Console.WriteLine("End of For Loop version of 1-255");
            Console.WriteLine("");
            // Create a new loop that prints all the values from 1-100 that are divisible by 3 or 5, but not both (15): for loop version
            for(int i = 1; i <= 100; i++)
            {
                bool by3or5 = (i % 3 == 0 || i % 5 == 0);
                bool notby15 = !(i % 3 == 0 && i % 5 == 0);
                
                if (by3or5 && notby15)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("End of For Loop version of 1-100, by 3 or 5, but not 15");
            Console.WriteLine("");
            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5 (15): for loop version
            for (int i = 1; i <= 100; i++)
            {
                bool by3 = (i % 3 == 0);
                bool by5 = (i % 5 == 0);
                bool by15 = (i % 3 == 0 && i % 5 == 0);
                if (by15)
                {
                    Console.WriteLine($"FizzBuzz is {i}");
                }
                else if (by3)
                {
                    Console.WriteLine($"Fizz is {i}");
                }
                else if (by5)
                {
                    Console.WriteLine($"Buzz is {i}");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("End of For Loop version of 1-100, by 3, 5, and 15, where by 3 is Fizz, by 5 is Buzz, and by 15 is FizzBuzz");
            Console.WriteLine("");
            // Create a Loop that prints all values from 1-255: while loop version
            int j = 1;
            while (j <= 255)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine("");
            Console.WriteLine("End of While Loop version of 1-255");
            Console.WriteLine("");
            // // Create a new loop that prints all the values from 1-100 that are divisible by 3 or 5, but not both (15): while loop version
            int k = 1; 
            while (k <= 100)
            {
                bool by3or5 = (k % 3 == 0 || k % 5 == 0);
                bool notby15 = !(k % 3 == 0 && k % 5 == 0);
                if (by3or5 && notby15)
                {
                    Console.WriteLine(k);
                }
                k++;
            }
            Console.WriteLine("");
            Console.WriteLine("End of While Loop version of 1-100, by 3 or 5, but not 15");
            Console.WriteLine("");
            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5 (15): while loop version
            int l = 1;
            while (l <= 100)
            {
                bool by3 = (l % 3 == 0);
                bool by5 = (l % 5 == 0);
                bool by15 = (l % 3 == 0 && l % 5 == 0);
                if (by15)
                {
                    Console.WriteLine("FizzBuzz" + l);
                }
                else if (by3)
                {
                    Console.WriteLine("Fizz" + l);
                }
                else if (by5)
                {
                    Console.WriteLine("Buzz" + l);
                }
                l++;
            }
            Console.WriteLine("");
            Console.WriteLine("End of While Loop version of 1-100, by 3, 5, and 15, where by 3 is Fizz, by 5 is Buzz, and by 15 is FizzBuzz");
            Console.WriteLine("");
        }
    }
}