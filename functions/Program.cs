using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene arv.");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv");
            int LastNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Palun vali tehe. Sisesta ( '+','-','*'või'/')");
            char UserOperator = Convert.ToChar(Console.ReadLine());

            switch(UserOperator)
            {
                case '+':
                    AddTwoNumbers(FirstNumber, LastNumber);
                    break;
                case '/':
                    DivideTwoNumbers(FirstNumber, LastNumber);
                    break;
                case '-':
                    MinusTwoNumbers(FirstNumber, LastNumber);
                    break;
                case '*':
                    MultiplyTwoNumbers(FirstNumber, LastNumber);
                    break;

                default:
                    Console.WriteLine("Head päeva!");
                    break;
            }
        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        
        
       
        }
        private static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }

        private static void MinusTwoNumbers(double x, double y)
        {
            double result = x - y;
            Console.WriteLine(result);
        }
        private static void MultiplyTwoNumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }
    }


}
