using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            ParasSum(5, 5);
        }

        public static void ParasSum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        public static void StringFunction()
        {
            Console.WriteLine("enter string");
            string functionString = Console.ReadLine();
            Console.WriteLine(functionString);
        }
            


    }
}
