using System;

namespace homework_5
{
    class Program
    {
        public static void Swap(int[] swaper, int n1, int n2)
        {
            int a = -1, b = -1;

            for (int i = 0; i < swaper.Length; i++)
            {
                if (swaper[i] == n1) a = i;
                if (swaper[i] == n2) b = i;
            }

            if (a == -1 || b == -1)
            {
                Console.WriteLine("Одно из чисел не найдено в массиве.");
                return;
            }

            int memory = swaper[a];
            swaper[a] = swaper[b];
            swaper[b] = memory;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[20];

            Console.WriteLine("Массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 10001);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            
            int a = int.Parse(Console.ReadLine());
            
            int b = int.Parse(Console.ReadLine());

            Swap(arr, a, b);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}