namespace HomeWorkFunction5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandShowArray = "Показать массив";
            const string CommandShuffle = "Перемешать";
            const string CommandExit = "Выход";
            bool isProgramOn = true;
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            ShowMenu(CommandShowArray, CommandShuffle, CommandExit);

            while (isProgramOn)
            {
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandShowArray:
                        ShowArray(numbers);
                        break;
                    case CommandShuffle:
                        Shuffle(numbers);
                        break;
                    case CommandExit:
                        isProgramOn = false;
                        break;
                }
            }
        }

        static void ShowMenu(string CommandShowArray, string CommandShuffle, string CommandExit)
        {
            Console.SetCursorPosition(25, 0);
            Console.WriteLine($"Программа для перемешивания значений элементов массива\n Выберите опцию: \n1-{CommandShowArray}\n2-{CommandShuffle}\n3-{CommandExit}");
        }

        static void Shuffle(int[] numbers)
        {
            Random random = new Random();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int randomNumber = random.Next(i + 1);
                int temporaryNumber = numbers[randomNumber];
                numbers[randomNumber] = numbers[i];
                numbers[i] = temporaryNumber;
            }
            Console.WriteLine("=>Готово");
        }

        static void ShowArray(int[] numbers)
        {
            Console.WriteLine("Массив: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(+numbers[i] + ",");
            }
        }
    }
}