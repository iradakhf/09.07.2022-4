using System;
namespace Arrays
{
    class Program
    {
        public static void Main(string [] args)
        {
            int[] numbersArray = { 7, 4, 25, 12 };
            int sum = SumOfFirstNNaturalnumbers(numbersArray, 2);
            Console.WriteLine(sum);
        }
        public static int SumOfFirstNNaturalnumbers(int[] numbers,int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}