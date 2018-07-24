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

            Factorial();
        }

        public static void Factorial()
        {
            Console.WriteLine("Enter a number of N and K formular is N!/K!");
           var n =  Convert.ToInt32(Console.ReadLine());
            var k = Convert.ToInt32(Console.ReadLine());
            int numerator = 1;
            int denumerator = 1;
            double answer;
            for (int i = 1; i <= n; i++)
            {
                numerator *= n;
            }
            for (int i = 1; i <= n; i++)
            {
                denumerator *= k;
            }


            answer = numerator / denumerator;


            Console.WriteLine($" the Answer is {answer}");
        }
    }
}
