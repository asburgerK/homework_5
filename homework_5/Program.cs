using System;


namespace homework
{
    

    public class Program
    {
        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        static void Main()
        {
            Console.WriteLine(Max(5, 10));
        }
    }
}