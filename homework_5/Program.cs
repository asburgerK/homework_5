using System;

namespace homework_5
{
    class Program
    {
        static public int fib(int n)
        {
            if (n <= 1)
                return n;
            else
                return fib(n - 1) + fib(n - 2);
        }
        static void Main()
        {
            Console.WriteLine(fib(10));
        }
    }
}