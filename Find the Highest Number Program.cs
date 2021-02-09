using System;

namespace L6_1_FindHighestValue
{
    class Program
    {
        //In this program, the highest value in the array is outputted
        static void Main(string[] args)
        {
            uint[] values =
            {
                23456, 354345, 2324, 22, 34, 654, 6754, 74557, 345463, 234, 234,
                234, 43, 25, 6456, 745, 8658, 986, 9678, 2342, 23, 235, 534, 364, 23,
                234234, 56346, 6435, 3643574, 345, 34523, 563, 2, 674, 78568, 8756, 6587
            };

            uint highestValue = 0;

            foreach (uint value in values)
            {

                if(value > highestValue)
                {
                    highestValue = value;
                }
            }

            Console.WriteLine("The highest value is " + highestValue);
        }
    }
}
