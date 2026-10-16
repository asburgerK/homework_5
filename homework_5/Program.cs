using System;


namespace homework
{


    public class Program
    {
        public static int factorial(int n)
        {
            try
            {
                checked
                {
                    if (n < 0) throw new ArgumentException("n < 0");
                   if (n == 0 || n == 1) return 1;
                    return n * factorial(n - 1);

                }
            }
            catch (OverflowException)
            {
                
                return 0;
                
            }
        }

        static void Main()
        {
            Console.WriteLine(factorial(5));
        }
    }
}