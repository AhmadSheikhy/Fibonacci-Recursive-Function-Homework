using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static int fib(int x)
        {
            if (x < 3)
                return x-1;
            return fib(x - 1) + fib(x - 2);
        }
        static void Main(string[] args)
        {
            int userNum;
            string number;
            number = Console.ReadLine();
            userNum = int.Parse(number);
            Console.WriteLine(fib(userNum));
            Console.ReadKey();
        }
    }
}
