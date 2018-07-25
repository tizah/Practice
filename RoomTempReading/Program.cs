using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomTempReading
{
    class Program
    {
       static int ones = 0;
         static int zeros = 0;
        static int twos = 0;
       
        static void Main(string[] args)
        {

            Program temperature = new Program();
            temperature.HighDevice();
        }

        public void HighDevice()
        {
            int[] device1 = new int[] { 18, 19, 20, 21, 22, 21, 20, 19, 18, 17, 16, 18 };
            int[] device2 = new int[] { 18, 19, 21, 21, 20, 19, 20, 19, 19, 16, 17, 18 };
            int[] high = new int[12];


            for (int i = 0; i <= device1.Length - 1; i++)
            {


                int firstDevice = device1[i];
                int secondDevice = device2[i];
                if (firstDevice == secondDevice)
                {
                    high[i] = 0;
                }
                else if (firstDevice > secondDevice)
                {
                    high[i] = 1;
                }
                else
                {
                    high[i] = 2;
                }
                Console.WriteLine(high[i]);
            }
            doCount(high);
        }

        public static void doCount(int[] arrays)
        {
            //loop to count the occurence of a particular number in the array
            foreach (int arrayNum in arrays)
            {
               if(arrayNum == 0)
                {
                    zeros++;
                }
               else if(arrayNum == 1)
                {
                    ones++;

                }
                else
                {
                    twos++;
                }
            }
        }
    }
}
