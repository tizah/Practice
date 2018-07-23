using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfFibonnaci
{
    
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciSeries();
        }

        //this method helps calculate the fibonacci series
        public static void FibonacciSeries()
        {
            Console.WriteLine("Enter a number to print the fibonacci series");
            var num = Convert.ToInt32(Console.ReadLine());
            //initialize default values
            int sum = 1;
            int start = 0; 
            int next = 1;

            //loop is used to stop the program at exact number the user enters
            for(int i = 1; i <= num; i++)
            {
                sum = start + next;
                start = next;
                next = sum;

                Console.WriteLine($" {next - start} + {start}  = {sum}");
            }
        }
    }
}
