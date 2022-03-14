using System;

namespace DivideTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            DivideTwoNumbers();
        }

        public static void DivideTwoNumbers(int x, int y)
        {
            int result = x / y;
            Console.WriteLine(result);
        }
    }
}
