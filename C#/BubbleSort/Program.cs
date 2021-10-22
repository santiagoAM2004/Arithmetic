using System;
using System.Collections.Generic;


namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();

            Random random = new Random();

            Console.WriteLine("type the range of random's number:");
            int numberRange = Convert.ToInt32(Console.ReadLine());

            for(int i = 0;i < numberRange;i++)
            {
                int numberRandom = random.Next(-10,10);
                Console.WriteLine(numberRandom);
                numberList.Add(numberRandom);
            }
        }
    }
}
