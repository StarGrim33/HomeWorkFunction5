namespace HomeWorkFunction5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isProgramOn = true;
            int[] numbers = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

            ShowMenu();

            while (isProgramOn)
            {
                const string CommandShowArray = "Показать массив";
                const string CommandShuffle = "Перемешать";
                const string CommandExit = "Выход";

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "Показать массив":
                        ShowArray(numbers);
                        break;
                    case "Перемешать":
                        Shuffle(ref numbers);
                        break;
                    case "Выход":
                        isProgramOn = false;
                        break;
                }

            }
           
        }

        static void ShowMenu()
        {
            Console.SetCursorPosition(25, 0);
            Console.WriteLine("Программа для перемешивания значений элементов массива\n Выберите опцию: \n1-Показать массив\n2-Перемешать\n3-Выход");
        }

        static void Shuffle(ref int[] numbers)
        {
            Random random = new Random();

            for (int i = numbers.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                int temporary = numbers[j];
                numbers[j] = numbers[i];
                numbers[i] = temporary;
            }

            Console.WriteLine("=>Готово");

        }

        static void ShowArray(int[] numbers)
        {
            Console.WriteLine("Массив: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(+ numbers[i] + ",");
            }

        }

    }
}