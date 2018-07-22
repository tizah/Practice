using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int a = 1; a <= 9; a++)
            //{
            //    for (int b = 0; b <= 9; b++)
            //    {
            //        for (int c = 0; c <= 9; c++)
            //        {
            //            for (int d = 0; d <= 9; d++)
            //            {
            //                if ((a + b) == (c + d))
            //                {
            //                    Console.WriteLine(
            //                    " " + a + " " + b + " " + c + " " + d);
            //                }
            //            }
            //        }
            //    }
            //}
            // PrintTheNumbers();
            // PrintNumbersNotDivisbleBy3and7();
            //  PrintTheSmallestAndLargestNumToTheScreen();
            DeckGame.StandardDeckGame();

        }

        public static void PrintTheNumbers()
        {
            Console.WriteLine("Enter any number");

            var num = Convert.ToUInt64(Console.ReadLine());
            for (UInt64 i = 1; i <= num; i++)
            {
                Console.WriteLine(i + " ");
            }
        }


        //this method will print to the screen the output of all 
        //number that the user enters but will not print the numbers
        //that are divisible by 3 and 7 
        public static void PrintNumbersNotDivisbleBy3and7()
        {
            Console.WriteLine("Enter any Number");
            var num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {

                //if statement to test if the current number is divisible by 3 or 7 and print empty space
                //else it print the number not divisible to the screen
                if (i % 3 == 0 || i % 7 == 0)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        //user enter a sequence of numbers 
        //and program determine the maximum and minimum numbers
        public static void PrintTheSmallestAndLargestNumToTheScreen()
        {
            Console.WriteLine("How many number will you like to enter ?");
            var range = Convert.ToInt32(Console.ReadLine());
            int num = 1;
            int index = 0;

            //varible to hold the range of user input
            int[] numbs = new int[range];

            //conditional loop to accept the user input
            while (num <= range)
            {
                var numbers = Convert.ToInt32(Console.ReadLine());
                numbs[index] = numbers;
                index++;
                num++;
            }
            Console.WriteLine($"maximum value is {numbs.Max()} and minimum value is {numbs.Min()} ");

         
        }
    }
}
