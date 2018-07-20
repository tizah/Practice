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

            Console.WriteLine("Enter any number");

            var num = Convert.ToUInt64(Console.ReadLine());
            for (UInt64 i =1; i <= num; i++)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
