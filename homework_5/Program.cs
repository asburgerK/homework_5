using System;


namespace homework
{


    public class Program
    {
        public static void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;

            b= c; 
        }

        static void Main()
        {
            int x = 2; 
            int y = 3;

            swap(ref x, ref y);
        }
    }
}