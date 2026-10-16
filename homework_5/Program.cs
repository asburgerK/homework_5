using System;


namespace homework
{


    public class Program
    {
        public static bool factorial(int n, out int result)
        {
            try
            {
                checked
                {
                    result = 1;
                    if (n < 0)
                    {
                        return false;
                    }
                    for (int i = 1; i <= n; i++)
                    {
                        result *= i;
                    }
                    return true;
                }
            }
            catch (OverflowException)
            {
                result = 0;
                return false;
            }
        }

        static void Main()
        {
            Console.WriteLine(factorial(5, out int result));
            Console.WriteLine(result);
        }
    }
}