C# задачи
Решение задач на C#

Я разобью решение на отдельные файлы, как указано в задании.
Упражнение 5.1 — Метод поиска максимума

Exercise5_1.cs
csharp

using System;

namespace HomeWork
{
    public static class Exercise5_1
    {
        /// <summary>
        /// Возвращает наибольшее из двух целых чисел
        /// </summary>
        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public static void Run()
        {
            Console.WriteLine("=== Упражнение 5.1 ===");
            Console.WriteLine($"Max(5, 10) = {Max(5, 10)}");
            Console.WriteLine($"Max(-3, -7) = {Max(-3, -7)}");
            Console.WriteLine($"Max(42, 42) = {Max(42, 42)}");
        }
    }
}

Упражнение 5.2 — Обмен значений через ref

Exercise5_2.cs
csharp

using System;

namespace HomeWork
{
    public static class Exercise5_2
    {
        /// <summary>
        /// Меняет местами значения двух параметров (передача по ссылке)
        /// </summary>
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Run()
        {
            Console.WriteLine("=== Упражнение 5.2 ===");
            int x = 5, y = 10;
            Console.WriteLine($"До:    x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"После: x = {x}, y = {y}");
        }
    }
}

Упражнение 5.3 — Факториал с out и checked

Exercise5_3.cs
csharp

using System;

namespace HomeWork
{
    public static class Exercise5_3
    {
        /// <summary>
        /// Вычисляет факториал. Возвращает true при успехе, false при переполнении.
        /// </summary>
        public static bool TryFactorial(int n, out int result)
        {
            result = 1;
            if (n < 0) return false;

            try
            {
                checked
                {
                    for (int i = 2; i <= n; i++)
                    {
                        result *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                result = 0;
                return false;
            }
        }

        public static void Run()
        {
            Console.WriteLine("=== Упражнение 5.3 ===");

            int[] tests = { 5, 12, 13, 20 };
            foreach (int n in tests)
            {
                if (TryFactorial(n, out int res))
                    Console.WriteLine($"{n}! = {res}");
                else
                    Console.WriteLine($"{n}! — переполнение!");
            }
        }
    }
}

Упражнение 5.4 — Рекурсивный факториал

Exercise5_4.cs
csharp

using System;

namespace HomeWork
{
    public static class Exercise5_4
    {
        /// <summary>
        /// Рекурсивное вычисление факториала
        /// </summary>
        public static long Factorial(int n)
        {
            if (n < 0) throw new ArgumentException("n должно быть >= 0");
            if (n == 0 || n == 1) return 1;
            return n * Factorial(n - 1);
        }

        public static void Run()
        {
            Console.WriteLine("=== Упражнение 5.4 ===");
            for (int i = 0; i <= 10; i++)
                Console.WriteLine($"{i}! = {Factorial(i)}");
        }
    }
}

Домашнее задание 5.1 — НОД (перегрузка методов)

HomeWork5_1.cs
csharp

using System;

namespace HomeWork
{
    public static class project
    {
        
        public static int Nod(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

       
        public static int Nod(int a, int b, int c)
        {
            return Nod(Nod(a, b), c);
        }

        public static void Run()
        {
 
            Console.WriteLine(Nod(48, 36));
            Console.WriteLine(Nod(48, 36, 60));
            Console.WriteLine(Nod(100, 75, 50));
        }
    }
}