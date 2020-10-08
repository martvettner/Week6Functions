using System;

namespace Week6Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //HelloUSer();
            Num();
        }

        public static void HelloUSer()
        {
            Console.WriteLine("enter your name");
            string userName = Console.ReadLine();
            Console.WriteLine($"hello, {userName}");
        }
        public static void Num()
        {
            Console.WriteLine("enter number 1");
            int Num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter number 2");
            int Num2 = Int32.Parse(Console.ReadLine());

            int sum = Num1 + Num2;
            Console.WriteLine(sum);
            
        }

    }
}
