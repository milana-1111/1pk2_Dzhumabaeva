namespace Task_05_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе[n * m].Заполнение
            //случайными числами в диапазоне от - 99 до 99 включительно.Осуществите без создания нового массива преобразование текущего
            //по следующему правилу:
            //• Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
            //• Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом

            // Запрос размеров массива у пользователя
            Console.Write("Введите количество строк (n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов (m): ");
            int m = int.Parse(Console.ReadLine());
            // Создание и заполнение массива случайными числами
            int[,] array = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(-99, 100); // Генерация числа от -99 до 99
                }
            }
            // Преобразование и вывод массива
            Console.WriteLine("Преобразованный массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Задаем зеленый цвет для отрицательных чисел
                        Console.Write(Math.Abs(array[i, j]) + " "); // Выводим модуль числа
                    }
                    else if (array[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Задаем красный цвет для нулей
                        Console.Write(1 + " "); // Выводим единицу вместо нуля
                    }
                    else
                    {
                        Console.ResetColor(); // Сбрасываем цвет для положительных чисел
                        Console.Write(array[i, j] + " "); // Выводим положительное число как есть
                    }
                    Console.ResetColor(); // Сбрасываем цвет после каждого элемента
                }
                Console.WriteLine();
            }
        }
    }
}
