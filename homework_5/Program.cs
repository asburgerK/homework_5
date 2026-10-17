using System;

namespace homework_5
{
    class Program
    {

        public enum GrumpinessLevel
        {
            Низкий,
            Средний,
            Высокий,
            Легендарный
        }

        public struct Grandpa
        {
            public string Name;
            public GrumpinessLevel Grumpiness;
            public string[] Phrases;
            public int Bruises;
            public Grandpa(string name, GrumpinessLevel grumpiness, params string[] phrases)
            {
                Name = name;
                Grumpiness = grumpiness;
                Phrases = phrases ?? new string[0];
                Bruises = 0;
            }

            public int CheckProfanity(params string[] badWords)
            {
                int count = 0;

                foreach (string phrase in Phrases)
                {
                    foreach (string bad in badWords)
                    {
                        if (phrase == bad)
                        {
                            count++;                   }
                    }
                }

                return count;  
            }




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

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers) sum += n;
            return sum;
        }

        public static void Product(ref int[] numbers, ref long product)
        {
            product = 1;
            foreach (int n in numbers) product *= n;
        }


        public static void Average(int[] numbers, out double average)
        {
            
            int sum = 0;
            foreach (int n in numbers) 
                sum += n;
            average = (double)sum / numbers.Length;
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


            //2 
            int[] arr2 = {2,4 ,6, 8,10 };

            Console.WriteLine("Сумма: " + Sum(arr2));
            Console.WriteLine();

            long product = 0;

            Product(ref arr2, ref product);
            Console.WriteLine(product);

            Average(arr, out double avg);
            Console.WriteLine(avg);

            //3

            string[] Digits =
            {

                            "#####\n#   #\n#   #\n#   #\n#   #\n#   #\n#####",
            "  #  \n ##  \n  #  \n  #  \n  #  \n  #  \n#####",
            "#####\n    #\n    #\n#####\n#    \n#    \n#####",
            "#####\n    #\n    #\n#####\n    #\n    #\n#####",
            "#   #\n#   #\n#   #\n#####\n    #\n    #\n    #",
            "#####\n#    \n#    \n#####\n    #\n    #\n#####",
            "#####\n#    \n#    \n#####\n#   #\n#   #\n#####",
            "#####\n    #\n    #\n    #\n    #\n    #\n    #",
            "#####\n#   #\n#   #\n#####\n#   #\n#   #\n#####",
            "#####\n#   #\n#   #\n#####\n    #\n    #\n#####"

            };
            while (true)
            {
                Console.WriteLine("Введите номер числа"); 
                string input1 = Console.ReadLine();
                if (input1 == "exit" || input1 == "закрыть")
                    break;
                if (!int.TryParse(input1, out int number))
                {
                    Console.WriteLine("Не число");
                }
                else if (number < 0 || number > 9)
                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Число вне диапазона");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        Console.Clear();   
                }
                else
                {
                    Console.WriteLine(Digits[number]);
                }
                Console.WriteLine();
                


            }

                //4
                string[] badWords = { "Проститутки!", "Гады!", "Чёрт!", "Проклятые!" };

                Grandpa[] grandpas =
                {
            new Grandpa("Иван",    GrumpinessLevel.Средний,     "Проститутки!", "Гады!", "Опять соседи шумят"),
            new Grandpa("Пётр",    GrumpinessLevel.Высокий,     "Чёрт!", "Опять эти голуби"),
            new Grandpa("Николай", GrumpinessLevel.Низкий,      "Хорошо бы чайку"),
            new Grandpa("Семён",   GrumpinessLevel.Легендарный, "Проститутки!", "Гады!", "Проклятые!", "Чёрт!", "Всё не так!"),
            
        };
                foreach (var grandpa in grandpas)
                {
                    Console.WriteLine($"{grandpa.Name}: {grandpa.CheckProfanity(badWords)}");
                }



            }
        }
}