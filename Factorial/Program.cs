using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

          //  Factorial();
            Factorial2();
        }

        public static void Factorial()
        {
            Console.WriteLine("Enter a number of N and K formular is N!/K!");
           var n =  Convert.ToInt32(Console.ReadLine());//6
            var k = Convert.ToInt32(Console.ReadLine());//3
            int numerator = 1;
            int denumerator = 1;
            double answer;
            for (int i = 1; i <= n; i++)
            {
                numerator *= i;
            }
            for (int j = 1; j <=k ; j++)
            {
                denumerator *= j;
            }


            answer = numerator / denumerator;


            Console.WriteLine($" the Answer is {answer}");
        }

        public static void Factorial2()
        {

            Console.WriteLine("Enter a number of N and K formular is N!/K!");
            var n = Convert.ToInt32(Console.ReadLine());//6
            var k = Convert.ToInt32(Console.ReadLine());//3
            int numerator = 1;
            int denumerator = 1;

            double answer;

            int subOfDemoninator = 1;
            for (int i = 1; i <= n; i++)
            {
                numerator *= i;
            }
            for (int j = 1; j <= k; j++)
            {
                denumerator *= j;
            }
            int subtractInputs = n - k;
            for (int j = 1; j <= subtractInputs; j++)
            {
                subOfDemoninator *= j;
            }


            answer = (numerator * denumerator) / subOfDemoninator;


            Console.WriteLine($" the Answer is {answer}");
        }
    }
}
