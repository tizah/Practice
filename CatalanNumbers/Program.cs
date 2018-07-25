using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
             CatalanNum();
           // GetFactorial(6);
        }

        public static void CatalanNum()
        {
            Console.WriteLine("Enter a number to calculate the catalan Number");
            var n = Convert.ToInt32(Console.ReadLine());//6

            int upperFactorial = 1;
            int lowerFactorial = 1;
            int nthFactorial = 1;
            // comment from joe
            int upper = (2 * n);
            for (int i = 1; i <= upper; i++)
            {
                upperFactorial *= i;
            }
            int lower = n + 1;
            for (int i = 1; i <= lower; i++)
            {
                lowerFactorial *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                nthFactorial *= i;
            }


            int catalan = upperFactorial / (lowerFactorial * nthFactorial);
        }


        public  static long GetFactorial(int number)

        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }
    }
}
